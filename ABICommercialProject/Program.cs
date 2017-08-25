using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABICommercialProject
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            try
            {
                MissionInterim m = new MissionInterim("", "motif", DateTime.Now.AddYears(1), "qualifications",
                                                                DateTime.Now.AddMonths(-6), Statut.Cadre, 1850);
                Console.WriteLine(m);
            }
            catch (Exception e)
            {

                Console.WriteLine("Exception :" + e);
            }
       

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainApp.Instance());
            
        }
    }
}
