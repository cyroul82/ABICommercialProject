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
    
    public partial class CollaborateurListForm : Form
    {
        private DataTable dt;
        private SortedDictionary<Int32, Collaborateur> collaborateurList;

        public EventHandler CreatingCollabo;
        public SelectingHandler SelectingCollabo;

        public CollaborateurListForm(SortedDictionary<Int32, Collaborateur> collaborateurList)
        {
            InitializeComponent();
            this.collaborateurList = collaborateurList;
            initializeDataTable();
            setDataSource();
        }

        public void setDataSource()
        {
            dt.Clear();
            collaborateurDataGrid.DataSource = getCollaborateurs();
            collaborateurDataGrid.Refresh();
        }

        private void initializeDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Matricule");
            dt.Columns.Add("Nom");
            dt.Columns.Add("Prénom");
            dt.Columns.Add("Fonction");
            dt.Columns.Add("Qualification");
            dt.Columns.Add("Contrat");
            dt.Columns.Add("Statut");
            dt.Columns.Add("SalaireBrut");
            dt.Columns.Add("Actif");
        }

        public void display()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.Activate();
            }
        }

        private DataTable getCollaborateurs()
        {
            if (dt != null)
            {
                foreach (KeyValuePair<Int32, Collaborateur> c in collaborateurList)
                {
                    
                addCollaborateur(c.Value);

                }
                return dt;
            }
            else return null;
        }

        private void addCollaborateur(Collaborateur collaborateur)
        {
            if (dt != null)
            {
                DataRow dr = dt.NewRow();
                dr["Matricule"] = collaborateur.Matricule;
                dr["Nom"] = collaborateur.NomCollabo;
                dr["Prénom"] = collaborateur.PrenomCollabo;
                dr["Fonction"] = collaborateur.FonctionCollabo;

                if (collaborateur.getContratActif() != null)
                {
                    dr["Qualification"] = collaborateur.getContratActif().Qualification;

                    TypeContrat type = TypeContrat.CDI;

                    if (collaborateur.getContratActif() is Cdi) type = TypeContrat.CDI;
                    if (collaborateur.getContratActif() is Cdd) type = TypeContrat.CDD;
                    if (collaborateur.getContratActif() is Stage) type = TypeContrat.Stage;
                    if (collaborateur.getContratActif() is MissionInterim) type = TypeContrat.Interim;


                    dr["Contrat"] = type.ToString();
                    dr["Statut"] = collaborateur.getContratActif().StatutContrat;
                    dr["SalaireBrut"] = collaborateur.getContratActif().SalaireBrut;
                    
                }
                dr["Actif"] = collaborateur.hasContratActif() ? "Actif" : "Cloturé";
                dt.Rows.Add(dr);
            }
        }

        private void btnNewCollabo_Click(object sender, EventArgs e)
        {
            CreatingCollabo?.Invoke(sender, e);
        }

        

        private void collaborateurDataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            //if (collaborateurDataGrid.SelectedRows.Count > 0 &&
            //    collaborateurDataGrid.SelectedRows[0].Index != collaborateurDataGrid.Rows.Count - 1)
            //{

            //}
            //if(collaborateurDataGrid.RowCount > 0)
            //{
            //    selectedCollaborateur = CollaborateurController.getCollaboInstance().getCollaborateur(Convert.ToInt32(collaborateurDataGrid.CurrentRow.Cells[0].Value));
            //    btnCloture.Enabled = true;
            //    Console.WriteLine(selectedCollaborateur);
            //}
       }

        private void collaborateurDataGrid_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCloture_Click(object sender, EventArgs e)
        {
            //CollaborateurController.getCollaboInstance().clotureContratCollaborateur(selectedCollaborateur);
        }

        private void collaborateurDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Int32 id = Convert.ToInt32(collaborateurDataGrid.CurrentRow.Cells[0].Value);
            SelectingCollabo(id);
        }
    }

}
