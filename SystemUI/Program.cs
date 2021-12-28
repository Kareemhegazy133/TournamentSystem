using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLibrary;

namespace SystemUI
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

            //Initializes the Connections
            SystemLibrary.GlobalConfig.InitializeConnections(DatabaseType.TextFile);
            Application.Run(new CreateTournamentForm());
            //Application.Run(new TournamentDashboardForm());
        }
    }
}
