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

            //var query = from c in context.Collaborateurs.Include("Contrats")
            //            select c;

            var collabos = context.Collaborateurs.Include("Contrats");
            foreach (var collabo in collabos)
            {
                collaborateurList.Add(collabo.Id, collabo);
            }
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
                context.Collaborateurs.Add(collaborateur);
                context.SaveChanges();

                //Get the new collaborateur and load! it in the context
                Collaborateur col = context.Collaborateurs.Find(collaborateur.Id);


                contrat.Collaborateur = col;

                col.setContratActif(contrat);
                col.AddContrat(contrat);

                context.Contrats.Add(contrat);
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
            return collaborateurList;
        }

    }
}
