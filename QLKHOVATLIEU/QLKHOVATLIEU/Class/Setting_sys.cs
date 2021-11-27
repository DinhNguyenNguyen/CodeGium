using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace QLKHOVATLIEU.Class
{
    public static class Setting_sys
    {
        public static string path = Application.StartupPath+@"\Data\" , term;
         public static void log_save_file(string file_name,string str)
         {
             term = path + file_name;
             if (!File.Exists(term))
             {
                 File.Create(term);
             }
             using (TextWriter tw = new StreamWriter(term))
             {
                 tw.Write(str);
             }
         }
         public static bool check_log_file(string file_name)
         {
             term = path + file_name;      
             if (!File.Exists(term))
             {
                 return false;
             }
             else
             {
                 string log = File.ReadAllText(term);
                 if (log.Length > 0)
                 {
                     return true;
                 }
                    return  false;
             }
         }
         public static string get_val_log_file(string file_name)
         {
             term = path + file_name;
             return File.ReadAllText(path + file_name);
         }
        // land messs
         public static void mess(string str){
             MessageBox.Show(str,"Hệ thống",MessageBoxButtons.OK,MessageBoxIcon.Information);
         }
    }
}
