using RazorEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateCode
{
    public partial class Form1 : Form
    {
   

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tableclass ts = new Tableclass
            {
                Tablename = "tsts",
                Columns = new List<Column> { new Column { FileType="int",FileName="id" },
                new Column {FileType="string",FileName="name" }
            }
            };

            string template = "Hello @Model.Name! Welcome to Razor!";
           string str=  File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory+"model.cshtml");
            string result = Razor.Parse(str, ts);
        }
    }

    
    
}
