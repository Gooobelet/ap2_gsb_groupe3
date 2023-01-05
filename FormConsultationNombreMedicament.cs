using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gsb_gesAMM_APP
{
    public partial class FormConsultationNombreMedicament : Form
    {
        public FormConsultationNombreMedicament()
        {
            InitializeComponent();
        }

        private void FormConsultationNombreMedicament_Load(object sender, EventArgs e)
        {
            lv_famille.Items.Clear();
            Dictionary<string, Famille>.KeyCollection lesClesFamille = Globale.lesFamilles.Keys;

            foreach(string lacle in lesClesFamille)
            {
                    Famille uneFamille = Globale.lesFamilles[lacle];

                    ListViewItem laLigne = new ListViewItem();
                    laLigne.Text = uneFamille.getCode();
                    laLigne.SubItems.Add(uneFamille.getLibelle());

                lv_famille.Items.Add(laLigne);
            }


        }

        private void lv_famille_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numLigClic = lv_famille.Items[lv_famille.FocusedItem.Index].Text;

            lv_médicament.Items.Clear();
            foreach(Medicament med in Globale.lesMedicaments.Values)
            {
                if(med.getFamMed() == numLigClic)
                {
                    ListViewItem ligne = new ListViewItem();
                    ligne.Text = med.getFamMed();
                    

                    lv_médicament.Items.Add(ligne);
                }
            }
            
        }
    }
}
