using ABIModel;
using System;
using System.Collections.Generic;

namespace ABIDAO
{
    public class DAO
    {
        private static DAO dao;
        private static SortedDictionary<Int32, Collaborateur> collaborateurList;
        private ABIContext context;

        /// <summary>
        /// Constructor 
        /// </summary>
        private DAO()
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

        public List<Collaborateur> GetCollabos()
        {
            List<Collaborateur> list = new List<Collaborateur>();
            var collabos = context.Collaborateurs.Include("Contrats");
            foreach (Collaborateur collabo in collabos)
            {
                list.Add(collabo);
            }
            return list;
        }
        public static DAO getInstance()
        {
            if (dao == null)
            {
                dao = new DAO();
            }
            return dao;
        }
        public void NewCollaborateur(Collaborateur collaborateur)
        {
            try
            {
                context.Collaborateurs.Add(collaborateur);
                UpdateCollorateur(collaborateur);
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
        public void UpdateCollorateur(Collaborateur collaborateur)
        {
            context.Entry(collaborateur).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public Collaborateur GetCollaborateur(int idCollaborateur)
        {
            Collaborateur col = (Collaborateur) context.Collaborateurs.Find(idCollaborateur);
            return col;
        }
    }
}
