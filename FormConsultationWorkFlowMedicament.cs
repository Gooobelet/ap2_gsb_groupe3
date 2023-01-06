using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gsb_gesAMM_APP
{
    public partial class FormConsultationWorkFlowMedicament : Form
    {
        public FormConsultationWorkFlowMedicament()
        {
            InitializeComponent();
        }

        private void FormConsultationWorkFlowMedicament_Load(object sender, EventArgs e)
        {
            Globale.lesMedicaments.Clear();
            Globale.bdd.getLesMedicaments();
            Globale.bdd.getLesWorkflows();

            lv_med_non_autorisé.Items.Clear();
            Dictionary<string, Medicament>.KeyCollection lesClesMedicaments = Globale.lesMedicaments.Keys;

            foreach (string lacle in lesClesMedicaments)
            {
                
                Medicament unMed = Globale.lesMedicaments[lacle];

                ListViewItem laLigne = new ListViewItem();
                laLigne.Text = unMed.getDepotLegal();
                laLigne.SubItems.Add(unMed.getNomCommercial());
                laLigne.SubItems.Add(unMed.getFamMed());

                lv_med_non_autorisé.Items.Add(laLigne);
            }
        }

        private void lv_med_non_autorisé_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string numLigClic = lv_med_non_autorisé.Items[lv_med_non_autorisé.FocusedItem.Index].Text;

            lv_med_workflow.Items.Clear();
            foreach (Workflow E in Globale.lesMedicaments[numLigClic].getLesEtapes())
            {

                ListViewItem ligne = new ListViewItem();
                ligne.Text = E.getEtape().getNum().ToString();
                ligne.SubItems.Add(numLigClic);
                ligne.SubItems.Add(E.getDateDecision().ToString());

                lv_med_workflow.Items.Add(ligne);
            }
        }

    }
}
