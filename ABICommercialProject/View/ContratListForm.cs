using ABICommercialProject.Controller;
using ABIModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABICommercialProject.View
{
    
    public partial class ContratListForm : Form
    {
        private DataTable dt;
        private Collaborateur collaborateur;
        public EventHandler CloturingContrat;
        public SelectingHandler SelectingContrat;
        public EventHandler CreatingContrat;
        public ContratListForm(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;
            InitializeComponent();
            this.Text = "Liste des contrats :" + collaborateur.Name + " " + collaborateur.Firstname;
            initializeDataTable();
            setDataSource();
        }


        public void setDataSource()
        {
            dt.Clear();
            grdListContrat.DataSource = getContrats();
            grdListContrat.Refresh();
        }

        private void initializeDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Numéro");
            dt.Columns.Add("Début");
            dt.Columns.Add("Qualification");
            //dt.Columns.Add("Statut");
            //dt.Columns.Add("Salaire");
            dt.Columns.Add("Type");
            dt.Columns.Add("Cloturé");
        }


        private DataTable getContrats()
        {
            if (dt != null)
            {
                foreach (Contrat c in collaborateur.Contrats)
                {
                    addContrat(c);

                }
                return dt;
            }
            else return null;
        }

        private void addContrat(Contrat  contrat)
        {
            if (dt != null)
            {
                DataRow dr = dt.NewRow();
                dr["Numéro"] = contrat.Id;
                dr["Début"] = contrat.DateDebutContrat.Date.ToShortDateString();
                dr["Qualification"] = contrat.Qualification;
                //dr["Statut"] = contrat.StatutContrat;
                //dr["Salaire"] = contrat.SalaireBrut;

                TypeContrat type = TypeContrat.CDI;

                if (contrat is Cdi) type = TypeContrat.CDI;
                if (contrat is Cdd) type = TypeContrat.CDD;
                if (contrat is Stage) type = TypeContrat.Stage;
                if (contrat is MissionInterim) type = TypeContrat.Interim;

                dr["Type"] = type.ToString();
                dr["Cloturé"] = contrat.Cloture ? "Oui" : " Non";

                dt.Rows.Add(dr);
            }
        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            CreatingContrat?.Invoke(sender, e);
        }

        private void grdListContrat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            detailContrat();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            detailContrat();
        }

        private void detailContrat()
        {
            Int32 id = Convert.ToInt32(grdListContrat.CurrentRow.Cells[0].Value);

            SelectingContrat?.Invoke(id);
        }
    }
}
