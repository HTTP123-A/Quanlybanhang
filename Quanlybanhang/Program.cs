using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhang
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
            Application.Run(new General_Form());
        }
    }
    static class Login_Data
    {
        private static string _global_username = "admin";
        private static string _global_password = "admin";

        public static string Global_username
        {
            get { return _global_username; }
            set { _global_username = value; }
        }
        public static string Global_password
        {
            get { return _global_password; }
            set { _global_password = value; }
        }
    }
}
