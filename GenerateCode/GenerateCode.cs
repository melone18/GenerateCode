using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Dapper;
using System.IO;
using RazorEngine;

namespace GenerateCode
{
    public partial class GenerateCodeForm : Form
    {
        public GenerateCodeForm()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=.;Initial Catalog = GenerateCode; User ID = sa; Password=mssql2014";

        private void button1_Click(object sender, EventArgs e)
        {
            //获取选中的表
            var selectedTables = GetSelectTables();
            foreach (var item in selectedTables)
            {
                item.Columns = GetColumnByTableName(item.Tablename,item.Type);
                //把数据库字段类型转成c#类型
                foreach (var col in item.Columns)
                {
                    string colType;
                    if (!DataTypeMapping.DataMapping.TryGetValue(col.FileType, out colType))
                    {
                        throw new Exception(string.Format("类型:[{0}]没有匹配到，请配置完整后再尝试",col.FileType));
                    }
                    col.FileType = colType;
                }
            }
            if (ckbModel.Checked)
            {
                
                string str = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "model.cshtml");
                selectedTables.ForEach(o => o.NameSpace = txtModel.Text);
                foreach (var ts in selectedTables)
                {
                    string csString = Razor.Parse(str, ts);

                    string folderPath = txtPath.Text + "\\Model\\";
                    //判断文件夹是否存在
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    using (FileStream aFile = new FileStream(folderPath+ts.Tablename+"PO"+".cs", FileMode.OpenOrCreate))
                    {
                        using (StreamWriter sw = new StreamWriter(aFile, Encoding.UTF8))
                        {
                            sw.WriteLine(csString);
                        }
                    }
                }
                
            }
            if (ckbDB.Checked)
            {
                string str = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "IDbReposition.cshtml");
                selectedTables.ForEach(o => o.NameSpace = txtDB.Text.Trim());
                #region
                //生成接口文件
                foreach (var ts in selectedTables)
                {
                    string csString = Razor.Parse(str, ts);

                    string folderPath = txtPath.Text + "\\IDbReposition\\";
                    //判断文件夹是否存在
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    using (FileStream aFile = new FileStream(folderPath +"I"+ ts.Tablename + "Reposition" + ".cs", FileMode.OpenOrCreate))
                    {
                        using (StreamWriter sw = new StreamWriter(aFile, Encoding.UTF8))
                        {
                            sw.WriteLine(csString);
                        }
                    }
                }

                #endregion
                #region
                //生成实现接口文件
                #endregion
            }
            if (ckbBusiness.Checked)
            {
                selectedTables.ForEach(o => o.NameSpace = txtBusiness.Text.Trim());
            }


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public List<Column> GetColumnByTableName(string tableName, string type)
        {
            try
            {
                IDbConnection conn = new SqlConnection(connectionString);
                using (conn)
                {
                    if (conn.State== ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                   
                    string sql = @"SELECT  /*CASE WHEN col.colorder = 1 THEN obj.name
                                              ELSE ''
                                         END AS TableName,
                                    col.colorder AS Seq ,*/
                                    col.name AS FileName,
                                    ISNULL(ep.[value], '') AS FileDesc,
                                    t.name AS FileType ,
                                    col.length AS Length ,
                                    ISNULL(COLUMNPROPERTY(col.id, col.name, 'Scale'), 0) AS Digits,
                                    CASE WHEN COLUMNPROPERTY(col.id, col.name, 'IsIdentity') = 1 THEN '1'
                                         ELSE ''
                                    END AS Flag ,
                                    CASE WHEN EXISTS(SELECT   1
                                                       FROM     dbo.sysindexes si
                                                                INNER JOIN dbo.sysindexkeys sik ON si.id = sik.id
                                                                                          AND si.indid = sik.indid
                                                                INNER JOIN dbo.syscolumns sc ON sc.id = sik.id
                                                                                          AND sc.colid = sik.colid
                                                                INNER JOIN dbo.sysobjects so ON so.name = si.name
                                                                                          AND so.xtype = 'PK'
                                                       WHERE    sc.id = col.id
                                                                AND sc.colid = col.colid) THEN 'True'
                                         ELSE 'False'
                                    END AS IsPkey ,
                                    CASE WHEN col.isnullable = 1 THEN 'True'
                                         ELSE 'False'
                                    END AS IsNullable /*,
                                    ISNULL(comm.text, '') AS DefaultValue*/
                            FROM    dbo.syscolumns col
                                    LEFT JOIN dbo.systypes t ON col.xtype = t.xusertype
                                    inner JOIN dbo.sysobjects obj ON col.id = obj.id
                                                                     AND obj.xtype = @type
                                                                     AND obj.status >= 0
                                    LEFT JOIN dbo.syscomments comm ON col.cdefault = comm.id
                                    LEFT JOIN sys.extended_properties ep ON col.id = ep.major_id
                                                                                  AND col.colid = ep.minor_id
                                                                                  AND ep.name = 'MS_Description'
                                    LEFT JOIN sys.extended_properties epTwo ON obj.id = epTwo.major_id
                                                                                     AND epTwo.minor_id = 0
                                                                                     AND epTwo.name = 'MS_Description'
                            WHERE obj.name = @tableName--表名
                            ORDER BY col.colorder; ";

                    return conn.Query<Column>(sql, new { tableName = tableName, type = type }).ToList();
                }

            }
            catch (Exception ex)
            {

                throw;
            }



        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderDialog fd = new FolderDialog();
            fd.DisplayDialog();
            txtPath.Text = fd.Path;
        }

        private List<Tableclass> GetSelectTables()
        {
            List<Tableclass> result = new List<Tableclass>();

            for (int i = 0; i < ckblTables.CheckedItems.Count; i++)
            {
                var t = ckblTables.CheckedItems[i] as Table;
                result.Add(new Tableclass { Tablename = t.Tablename.Trim(), Type = t.Type.Trim() });
            }

            return result;
        }

        private void GenerateCode_Load(object sender, EventArgs e)
        {
            try
            {
                IDbConnection conn = new SqlConnection(connectionString);
                using (conn)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string sql = "SELECT NAME As Tablename,xtype AS Type FROM SYSOBJECTS WHERE TYPE='V' OR TYPE='U'";
                    var tbs = conn.Query<Table>(sql).ToList();

                    ckblTables.DataSource = tbs;
                    ckblTables.DisplayMember = "Tablename";
                    ckblTables.ValueMember = "Tablename";
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            //ckblTables.DataSource
        }
    }
}
