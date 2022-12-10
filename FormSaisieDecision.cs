using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gsb_gesAMM_APP
{
    public partial class FormSaisieDecision : Form
    {
        public FormSaisieDecision()
        {
            InitializeComponent();
        }

        private void FormSaisieDecision_Load(object sender, EventArgs e)
        {
            foreach (Medicament unMed in Globale.lesMedicaments.Values)
            {
                cB_Medicament.Items.Add(unMed.getDepotLegal());
            }

            foreach (Decision uneDec in Globale.lesDecisions)
            {
                cB_etatDec.Items.Add(uneDec.getLeLibelle());
            }
        }
    }
}
