namespace ABICommercialProject.Migrations
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ABICommercialProject.DAO.ABIModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ABICommercialProject.DAO.ABIModel context)
        {
            var cc = new Dictionary<Int32, Collaborateur>()
            {
                { 1,  new Collaborateur ( "rat", "cyril", "fonctionDev", "109 Soleillette", "83700", "SaintRaph", "0645248403", "cyril.rat@gmail.com" ) },
                { 2,  new Collaborateur ( "Moiselet", "renaud", "fonctionDev", "turin", "06400", "Nice", "0625879652", "ayss@gmail.com" ) }
        };

            foreach(Collaborateur col in cc.Values)
            {
                Contrat cdi = new Cdi("qualif", DateTime.UtcNow, Statut.Cadre, 25000);
                col.Contrats.Add(cdi);
                context.Collaborateurs.AddOrUpdate(col);
            }

            

        }
    }
}
