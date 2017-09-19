
using ABIDAO;
using ABIModel;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ABIDAO
{
    public class DAOToChange
    {
        private static DAOToChange dao;
        private static SortedDictionary<Int32, Collaborateur> collaborateurList;
        private ABIContext context;

        private DAOToChange()
        {
            context = new ABIContext();
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

        public void NewCollaborateur(ref Collaborateur collaborateur)
        {
            try
            {
                context.Collaborateurs.Add(collaborateur);
                Update();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

   
        public SortedDictionary<Int32, Collaborateur> getCollaborateurList()
        {
            return collaborateurList;
        }

        public List<Collaborateur> Collaborateurs()
        {
            return context.Collaborateurs.ToList();
        }

        public void Update()
        {
            context.SaveChanges();
        }
    }
}
