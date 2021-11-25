using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBSQLHelper;

namespace ListFood
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //SQLHelper.SERVER_NAME = "(local)";
            //SQLHelper.USERNAME_DB = "sa";
            //SQLHelper.PASSWORD_DB = "minh123";
            //SQLHelper.DATABASE = "foody";
            //SQLHelper.ConnectString();
            Application.Run(new Form1());
        }
    }
}
