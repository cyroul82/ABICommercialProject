using ABICommercialProject.DAO;
using ABICommercialProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABICommercialProject
{
    public class DAOToChange
    {

        private static DAOToChange dao;
        private static SortedDictionary<Int32, Collaborateur> collaborateurList;
        ABIModel context;

        private DAOToChange()
        {
            context = new ABIModel();
            collaborateurList = new SortedDictionary<int, Collaborateur>();
        }

        public static DAOToChange getInstance()
        {
            if (dao == null)
            {
                dao = new DAOToChange();
            }
            return dao;
        }

        public void NewCollaborateur(ref Collaborateur collaborateur, Contrat contrat)
        {
            try
            {
                Random r = new Random();
                Int32 i = r.Next(1001, 10000);
                contrat.Id = i;
                collaborateur.setContratActif(contrat);
                collaborateur.AddContrat(contrat);
                context.Collaborateurs.Add(collaborateur);
                context.SaveChanges();

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
                //var collabo = context.Collaborateurs.Find(collaborateur.Id);
                var col = context.Collaborateurs.Single(c => c.Id == collaborateur.Id);
                col = collaborateur;
                context.SaveChanges();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public SortedDictionary<Int32, Collaborateur> getCollaborateurList()
        {
            //var query = from c in context.Collaborateurs
            //            select c;
            var collabos = context.Collaborateurs;
            foreach(var collabo in collabos)
            {
                collaborateurList.Add(collabo.Id, collabo);
            }
            return collaborateurList;
        }

    }
}
