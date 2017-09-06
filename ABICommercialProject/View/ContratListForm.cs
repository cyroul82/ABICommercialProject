using ABICommercialProject.Controller;
using ABICommercialProject.Model;
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
        private SortedDictionary<Int32, Contrat> listContrat;
        private DataTable dt;
        private Contrat contrat;

        public ContratHandler CloturingContrat;
        public SelectingHandler SelectingContrat;
        public EventHandler CreatingContrat;
        public ContratListForm(SortedDictionary<Int32, Contrat> listContrat)
        {
            InitializeComponent();
            this.listContrat = listContrat;
            initializeDataTable();
            setDataSource();
            contrat = null;
            btnCloturer.Enabled = false;
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
            dt.Columns.Add("Statut");
            dt.Columns.Add("Salaire");
            dt.Columns.Add("Type");
            dt.Columns.Add("Cloturé");
        }


        private DataTable getContrats()
        {
            if (dt != null)
            {
                foreach (KeyValuePair<Int32, Contrat> c in listContrat)
                {
                    addContrat(c.Value);

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
                dr["Numéro"] = contrat.NumeroContrat;
                dr["Début"] = contrat.DateDebutContrat;
                dr["Qualification"] = contrat.Qualification;
                dr["Statut"] = contrat.StatutContrat;
                dr["Salaire"] = contrat.SalaireBrut;
                Console.WriteLine("qualif : " + contrat.Qualification);

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

        private void btnCloturer_Click(object sender, EventArgs e)
        {
            if(contrat != null)
            {
                CloturingContrat?.Invoke(contrat);
                btnCloturer.Enabled = false;
            }
        }

        private void grdListContrat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 numero = Convert.ToInt32(grdListContrat.CurrentRow.Cells[0].Value);
            btnCloturer.Enabled = true;
            if (listContrat.ContainsKey(numero))
            {
                contrat = listContrat[numero];
                if(contrat.Cloture)
                {
                    btnCloturer.Enabled = false;
                }
            }
            else contrat = null;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreatingContrat?.Invoke(sender, e);
        }
    }
}
