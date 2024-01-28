using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassDepartement;

namespace WinDEPT
{
    public partial class FrmDept : Form
    {
        // déclaration du tableau lesDepartements
        Departement[] lesDepartements = new Departement[95];
        int nbDepartements = 0; // nombre de départements crées

        public FrmDept()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click sur le bouton VALIDER","EVENEMENT");
            // récupération des valeurs saisies dans les zones de texte
            string numDept = txtNumero.Text;
            string nomDept = txtNom.Text;
            double popDept = double.Parse(txtPopulation.Text);
            double supDept = double.Parse(txtSuperficie.Text);
            string regDept = txtRegion.Text;
            
            // création d'un département (instanciation d'un objet de la classe Departement)
            Departement d = new Departement(numDept, nomDept, supDept, popDept, regDept);
            
            // ajout du département crée dans le tableau lesDepartements
            lesDepartements[nbDepartements] = d;
            
            // incrémentation du nombre de départements crées
            nbDepartements++;
            
            // activation de l'onglet "Liste departements"
            tbcPrincipal.SelectedTab = tbpListe;
        }

        private void tbcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Sélection d'un onglet", "EVENEMENT");
                        
            // si l'onglet "LISTE DEPARTEMENTS" est sélectionné
            if (tbcPrincipal.SelectedTab == tbpListe)
            {
                MessageBox.Show("Onglet LISTE DEPARTEMENTS", "ONGLET SELECTIONNE");
                
                // appel à la méthode ChargerListDept
                ChargerListDept();
            }
            // si l'onglet "NOUVEAU" est sélectionné
            else
            {
                MessageBox.Show("Onglet NOUVEAU", "ONGLET SELECTIONNE");
            }
        }

        private void listDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Sélection d'un élément dans la liste", "EVENEMENT");
            
            // récupération de l'index de l'item sélectionné dans la listbox (base 0)
            int indexSelect = listDept.SelectedIndex;
            
            // obtention de l'objet Departement correspondant dans le tableau lesDepartements
            Departement deptSelect = lesDepartements[indexSelect];
            
            // affichage des informations du département
            txtInfoNumero.Text = deptSelect.GetNumero();
            txtInfoNom.Text = deptSelect.GetNom();
        }

        /// <summary>
        /// Méthode permettant de charger la liste des départements
        /// </summary>
        private void ChargerListDept()
        {
            // suppression des éléments (items) de la listbox
            listDept.Items.Clear();

            // parcours du tableau lesDepartements
            for (int i = 0; i <= nbDepartements - 1; i++)
            {
                string item = lesDepartements[i].GetNom();
                // ajout d'un item dans la listBox
                listDept.Items.Add(item);
            }
        }
    }
}
