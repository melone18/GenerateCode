using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Windows.Forms;

namespace GenerateCode
{
    public class FolderDialog : FolderNameEditor
     {
         FolderBrowser fDialog = new FolderBrowser();
         public FolderDialog()
         {
         }
         public DialogResult DisplayDialog()
         {
             return DisplayDialog("确定你的文件夹路径！！");
         }
         public DialogResult DisplayDialog(string description)
         {
             fDialog.Description = description;
             return fDialog.ShowDialog();
         }
         public string Path
         {
             get
             {
                 return fDialog.DirectoryPath;
             }
         }
         ~FolderDialog()
         {
             fDialog.Dispose();
         }
 
     }
}
