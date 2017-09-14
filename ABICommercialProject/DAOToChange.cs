﻿using ABICommercialProject.DAO;
using ABICommercialProject.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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

        internal void Update()
        {
            context.SaveChanges();
        }
    }
}
