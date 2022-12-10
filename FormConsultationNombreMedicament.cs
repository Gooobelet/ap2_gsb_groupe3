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
            Dictionary<string, Famille>.KeyCollection lesClesFamille = Globale.lesFamilles.Keys;
            Dictionary<string, Medicament>.KeyCollection lesClesMedicaments = Globale.lesMedicaments.Keys;

            foreach(string lacle in lesClesFamille)
            {
                foreach(string laclemed in lesClesMedicaments)
                {
                    Medicament unMedicament = Globale.lesMedicaments[laclemed];
                    Famille uneFamille = Globale.lesFamilles[lacle];

                    ListViewItem laLigne = new ListViewItem();
                    laLigne.Text = uneFamille.getCode();
                    laLigne.SubItems.Add(uneFamille.getLibelle());
                    laLigne.SubItems.Add(unMedicament.getComposition());

                lv_famille.Items.Add(laLigne);
                }
            }


        }

        private void lv_famille_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lv_médicament_Click(object sender, EventArgs e)
        {
            int numLigClic = lv_médicament.SelectedIndices[0];

            lv_famille.Items.Clear();
            
        }
    }
}
