using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
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
            Application.Run(new Form1());
/*
            var user = new UserControl();
            var users = user.List();
            var filteredUsers = user.List(nome: "joao");
            var uniqueUser = user.findById(1);

            "select * from users";
            "select * from users where name like '%joao%'"
            "select * from users where id = 1"; ;
            */
        }
    }
}
