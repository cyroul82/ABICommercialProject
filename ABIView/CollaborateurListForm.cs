using ABIModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ABIView
{
    
    public partial class CollaborateurListForm : Form
    {
        private DataTable dt;
        private SortedDictionary<Int32, Collaborateur> collaborateurList;

        public event EventHandler CreatingCollabo;
        public event SelectingHandler SelectingCollabo;

        public CollaborateurListForm(SortedDictionary<Int32, Collaborateur> collaborateurList)
        {
            InitializeComponent();
            this.collaborateurList = collaborateurList;
            InitializeDataTable();
            SetDataSource();

        }

        public void SetDataSource()
        {
            dt.Clear();
            collaborateurDataGrid.DataSource = GetCollaborateurs();
            collaborateurDataGrid.Refresh();
        }

        public void RefreshList(SortedDictionary<Int32, Collaborateur> collaborateurList)
        {
            this.collaborateurList = collaborateurList;
            SetDataSource();
        }

        private void InitializeDataTable()
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

        public void Display()
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

        private DataTable GetCollaborateurs()
        {
            if (dt != null)
            {
                foreach (KeyValuePair<Int32, Collaborateur> c in collaborateurList)
                {
                    
                AddCollaborateur(c.Value);

                }
                return dt;
            }
            else return null;
        }

        private void AddCollaborateur(Collaborateur collaborateur)
        {
            if (dt != null)
            {
                DataRow dr = dt.NewRow();
                dr["Matricule"] = collaborateur.Id;
                dr["Nom"] = collaborateur.Name;
                dr["Prénom"] = collaborateur.Firstname;
                dr["Fonction"] = collaborateur.FonctionCollabo;

                Contrat contratActif = null;
                foreach(Contrat c in collaborateur.Contrats)
                {
                    if(!c.Cloture)
                    {
                        contratActif = c;
                    }
                }

                if (contratActif != null)
                {
                    dr["Qualification"] = contratActif.Qualification;

                    TypeContrat type = TypeContrat.CDI;

                    if (contratActif is Cdi) type = TypeContrat.CDI;
                    if (contratActif is Cdd) type = TypeContrat.CDD;
                    if (contratActif is Stage) type = TypeContrat.Stage;
                    if (contratActif is MissionInterim) type = TypeContrat.Interim;


                    dr["Contrat"] = type.ToString();
                    dr["Statut"] = contratActif.StatutContrat;
                    dr["SalaireBrut"] = contratActif.SalaireBrut;
                    
                }
                dr["Actif"] = contratActif == null ? "Inactif" : "Actif";
                dt.Rows.Add(dr);
            }
        }

        private void BtnNewCollabo_Click(object sender, EventArgs e)
        {
            CreatingCollabo?.Invoke(sender, e);
        }

        

        private void CollaborateurDataGrid_MouseClick(object sender, MouseEventArgs e)
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

        private void CollaborateurDataGrid_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnCloture_Click(object sender, EventArgs e)
        {
            //CollaborateurController.getCollaboInstance().clotureContratCollaborateur(selectedCollaborateur);
        }

        private void CollaborateurDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Int32 id = Convert.ToInt32(collaborateurDataGrid.CurrentRow.Cells[0].Value);
            SelectingCollabo?.Invoke(id);
        }
    }

}
