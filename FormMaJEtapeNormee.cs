using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gsb_gesAMM_APP
{
    public partial class FormMaJEtapeNormee : Form
    {
        private int idx;

        public FormMaJEtapeNormee()
        {
            InitializeComponent();
        }

        private void FormMaJEtapeNormee_Load(object sender, EventArgs e)
        {
            btn_modifierNorme.Enabled = false;

            foreach (Etape uneEtape in Globale.lesEtapes)
            {
                if (uneEtape.GetType().Name == "EtapeNormee")
                {
                    cB_EtapeNormee.Items.Add(uneEtape.getNum() + " - " + uneEtape.getLibelle());
                }
            }
        }

        private void cB_EtapeNormee_SelectedIndexChanged(object sender, EventArgs e)
        {
            lV_historiqueModif.Items.Clear();

            if (cB_EtapeNormee.Text != "")
            {
                btn_modifierNorme.Enabled = true;

                int numEtp = Convert.ToInt32(cB_EtapeNormee.Text[0].ToString());
                idx = 0;

                bool trouve = false;

                while (!trouve && idx < Globale.lesEtapes.Count)
                {
                    if (Globale.lesEtapes[idx].getNum() == numEtp)
                    {
                        trouve = true;
                    }
                    else
                    {
                        idx++;
                    }
                }

                tB_Norme.Text = (Globale.lesEtapes[idx] as EtapeNormee).getNorme();
                dTP_dateNorme.Value = (Globale.lesEtapes[idx] as EtapeNormee).getDateNorme();


                foreach (HistoModifEtpNormee uneModifHisto in Globale.lhistoModifEtpNormee)
                {
                    if (uneModifHisto.getLeLibelle() == Globale.lesEtapes[idx].getLibelle())
                    {
                        ListViewItem uneLigne = new ListViewItem();
                        uneLigne.Text = uneModifHisto.getLeIdModif().ToString();
                        uneLigne.SubItems.Add(uneModifHisto.getLaDateModif().ToShortDateString());
                        uneLigne.SubItems.Add(uneModifHisto.getLeLibelle());
                        uneLigne.SubItems.Add(uneModifHisto.getLaNorme());
                        uneLigne.SubItems.Add(uneModifHisto.getLaDateNorme().ToShortDateString());

                        lV_historiqueModif.Items.Add(uneLigne);
                    }
                }
            }
            else
            {
                btn_modifierNorme.Enabled = false;
            }
        }

        private void btn_modifierNorme_Click(object sender, EventArgs e)
        {
            EtapeNormee uneEtape = (Globale.lesEtapes[idx] as EtapeNormee);

            string laNvlNorme = tB_Norme.Text;
            DateTime laNvlDateNorme = dTP_dateNorme.Value;
            int numEtp = uneEtape.getNum();
            
            if (uneEtape.getDateNorme() != laNvlDateNorme || uneEtape.getNorme() != laNvlNorme)
            {
                if (laNvlNorme != "")
                {
                    if (laNvlDateNorme <= DateTime.Now)
                    {
                        Globale.bdd.setMaJEtapeNormee(numEtp, laNvlNorme, laNvlDateNorme);
                    }
                    else
                    {
                        MessageBox.Show("Erreur : Vous ne pouvez pas avoir une date de norme supérieur à la date de jour !", "Erreur date de la norme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Erreur : Vous n'avez pas saisi de norme !", "Erreur norme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Erreur : Ni la norme, ni la date de la norme n'ont été modifiées !", "Erreur date de la norme et norme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Globale.lhistoModifEtpNormee.Clear();
            Globale.bdd.getHistModifEtpNormee();

            Globale.lesEtapes.Clear();
            Globale.bdd.getLesEtapes();

            Globale.lesMedicaments.Clear();
            Globale.bdd.getLesMedicaments();
            Globale.bdd.getLesWorkflows();

            cB_EtapeNormee.SelectedIndex = -1;
            lV_historiqueModif.Items.Clear();
            tB_Norme.Text = "";
            dTP_dateNorme.Value = DateTime.Now;
        }  
    }
}
