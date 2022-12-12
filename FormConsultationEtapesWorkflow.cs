using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gsb_gesAMM_APP
{
    public partial class FormConsultationEtapesWorkflow : Form
    {
        public FormConsultationEtapesWorkflow()
        {
            InitializeComponent();
        }

        private void FormConsultationEtapesWorkflow_Load(object sender, EventArgs e)
        {
            foreach (Medicament unMed in Globale.lesMedicaments.Values)
            {
                cB_Med.Items.Add(unMed.getDepotLegal());
            }
        }

        private void cB_Med_SelectedIndexChanged(object sender, EventArgs e)
        {
            lV_EtapeWorkflow.Items.Clear();

            if (cB_Med.Text != "")
            {
                foreach (Workflow uneEtape in Globale.lesMedicaments[cB_Med.Text].getLesEtapes())
                {
                    ListViewItem uneLigne = new ListViewItem();

                    uneLigne.Text = uneEtape.getEtape().getNum().ToString();
                    uneLigne.SubItems.Add(uneEtape.getEtape().getLibelle());

                    if (uneEtape.getDecision() != null)
                    {
                        uneLigne.SubItems.Add(uneEtape.getDateDecision().ToShortDateString());
                        uneLigne.SubItems.Add(uneEtape.getDecision().getLeLibelle());
                    }
                    else
                    {
                        uneLigne.SubItems.Add("");
                        uneLigne.SubItems.Add("");
                    }

                    if (uneEtape.getEtape().GetType().Name == "EtapeNormee")
                    {
                        uneLigne.SubItems.Add((uneEtape.getEtape() as EtapeNormee).getNorme());
                        uneLigne.SubItems.Add((uneEtape.getEtape() as EtapeNormee).getDateNorme().ToShortDateString());
                    }
                    else
                    {
                        uneLigne.SubItems.Add("");
                        uneLigne.SubItems.Add("");
                    }

                    lV_EtapeWorkflow.Items.Add(uneLigne);
                }
            }
        }
    }
}
