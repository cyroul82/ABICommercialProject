using ABICommercialProject.Controller;
using ABICommercialProject.Model;
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
                CollaborateurController cc = CollaborateurController.getCollaboInstance();
                Collaborateur c = new Collaborateur("RAT", "Cyril", "Concepteur");
                Cdi contrat = new Cdi("qualifié", DateTime.Now, Statut.Cadre, 1850);
                cc.newCollaborateur(c, contrat);

                c = new Collaborateur("Moiselet", "Renaud", "Développeur");
                Cdd cont = new Cdd("motif", DateTime.Now.AddYears(1), "qualifié", DateTime.Now, Statut.Cadre, 1850);
                cc.newCollaborateur(c, cont);
                Console.WriteLine(c + " " + cont);
                //cc.clotureContratCollaborateur(c);
                //Console.WriteLine(c);
                //c.AddContrat(new Stage("ecole", "mission", "motif", DateTime.Now.AddYears(1), "qualif", DateTime.Now, Statut.NonCadre, 1850));
            }
            catch(ArgumentNullException nullEx)
            {
                Console.WriteLine(nullEx.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine("Exception :" + e);
            }
       

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainApp());
            
        }
    }
}
