using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABICommercialProject
{
    public class DAO
    {

        private static DAO dao;
        private static SortedDictionary<Int32, Collaborateur> collaborateurList;
        private  static Int32 matricule = 0;
        private DAO()
        {
            collaborateurList = new SortedDictionary<int, Collaborateur>();
        }

        public static DAO getInstance()
        {
            if (dao == null)
            {
                dao = new DAO();
            }
            return dao;
        }

        public void NewCollaborateur(ref Collaborateur collaborateur, Contrat contrat)
        {
            try
            {
                collaborateur.Matricule = matricule++;
                Random r = new Random();
                Int32 i = r.Next(1001, 10000);
                contrat.NumeroContrat = i;
                collaborateur.setContratActif(contrat);
                collaborateur.AddContrat(contrat);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateCollaborateur(Collaborateur collaborateur)
        {
            try
            {
                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public SortedDictionary<Int32, Collaborateur> getCollaborateurList()
        {
            return collaborateurList;
        }

    }
}
