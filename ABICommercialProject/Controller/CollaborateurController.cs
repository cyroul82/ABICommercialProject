using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABICommercialProject.Controller
{
    class CollaborateurController
    {
        DataTable dt;
        public CollaborateurController()
        {
            dt = new DataTable();
            dt.Columns.Add("Matricule");
            dt.Columns.Add("Nom");
            dt.Columns.Add("Prénom");
            dt.Columns.Add("Fonction");
        }

        public System.Data.DataTable getCollaborateurs()
        {
            if (dt != null)
            {
                foreach (Collaborateur c in Collaborateur.collaborateurList)
                {
                    DataRow dr = dt.NewRow();
                    dr["Matricule"] = c.Matricule;
                    dr["Nom"] = c.NomCollabo;
                    dr["Prénom"] = c.PrenomCollabo;
                    dr["Fonction"] = c.FonctionCollabo;
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            else return null;
        }

        public void saveCollaborateur(Collaborateur collaborateur, Contrat contrat)
        {
            collaborateur.AddContrat(contrat);
            Collaborateur.collaborateurList.Add(collaborateur);


            DataRow dr = dt.NewRow();
            dr["Matricule"] = collaborateur.Matricule;
            dr["Nom"] = collaborateur.NomCollabo;
            dr["Prénom"] = collaborateur.PrenomCollabo;
            dr["Fonction"] = collaborateur.FonctionCollabo;
            dt.Rows.Add(dr);

        }
    }
}
