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
        private int idx;

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

            btn_ajouterDec.Enabled = false;
        }

        private void cB_Medicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            lV_EtapesValid.Items.Clear();

            string medChoix = cB_Medicament.Text;
            
            if (medChoix != "")
            {
                btn_ajouterDec.Enabled = true;

                bool etapeRefusee = false;
                bool etapeAucuneDec = false;
                idx = 0;
                List<Workflow> lesEtapesChoixMed = Globale.lesMedicaments[medChoix].getLesEtapes();

                while (!etapeRefusee && idx < lesEtapesChoixMed.Count)
                {
                    if (lesEtapesChoixMed[idx].getDecision() != null && lesEtapesChoixMed[idx].getDecision().getLeLibelle() == "Refusé")
                    {
                        etapeRefusee = true;
                    }
                    else
                    {
                        idx++;
                    }
                }

                idx = 0;

                while (!etapeAucuneDec && idx < lesEtapesChoixMed.Count)
                {
                    if (lesEtapesChoixMed[idx].getDecision() == null)
                    {
                        etapeAucuneDec = true;
                    }
                    else
                    {
                        idx++;
                    }
                }

                if (!etapeRefusee)
                {
                    if (etapeAucuneDec)
                    {
                        int idxLv = 0;

                        while (idxLv < idx)
                        {
                            ListViewItem uneLigne = new ListViewItem();

                            uneLigne.Text = lesEtapesChoixMed[idxLv].getEtape().getNum().ToString();
                            uneLigne.SubItems.Add(lesEtapesChoixMed[idxLv].getEtape().getLibelle());

                            if (lesEtapesChoixMed[idxLv].GetType().Name == "EtapeNormee")
                            {
                                uneLigne.SubItems.Add((lesEtapesChoixMed[idxLv].getEtape() as EtapeNormee).getNorme());
                                uneLigne.SubItems.Add((lesEtapesChoixMed[idxLv].getEtape() as EtapeNormee).getDateNorme().ToShortDateString());
                            }
                            else
                            {
                                uneLigne.SubItems.Add("");
                                uneLigne.SubItems.Add("");
                            }

                            uneLigne.SubItems.Add(lesEtapesChoixMed[idxLv].getDateDecision().ToShortDateString());

                            lV_EtapesValid.Items.Add(uneLigne);

                            idxLv++;
                        }

                        tB_numEtape.Text = lesEtapesChoixMed[idx].getEtape().getNum().ToString();
                        tB_Libelle.Text = lesEtapesChoixMed[idx].getEtape().getLibelle();

                        if (lesEtapesChoixMed[idx].GetType().Name == "EtapeNormee")
                        {
                            tB_Norme.Text = (lesEtapesChoixMed[idx].getEtape() as EtapeNormee).getNorme();
                            tB_dateNorme.Text = (lesEtapesChoixMed[idx].getEtape() as EtapeNormee).getDateNorme().ToShortDateString();
                        }
                        else
                        {
                            tB_Norme.Text = "";
                            tB_dateNorme.Text = "";
                        }
                    }
                    else
                    {
                        btn_ajouterDec.Enabled = false;
                        MessageBox.Show("Il n'y a plus d'étape à réalisée pour ce médicament. Soit tout les tests ont été validés avec succès, soit il n'y a pas d'étape(s) de saisie(s) pour ce médicament.", "Il n'y a plus d'étape pour ce médicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    btn_ajouterDec.Enabled = false;
                    MessageBox.Show("Erreur : Le médicament séléctionné a été refusé lors d'un test, vous ne pouvez plus saisir de décision pour ce médicament !", "Erreur test refusé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_ajouterDec_Click(object sender, EventArgs e)
        {
            if (cB_Medicament.Text != "")
            {
                List<Workflow> lesEtapesChoixMed = Globale.lesMedicaments[cB_Medicament.Text].getLesEtapes();
                int numEtape = lesEtapesChoixMed[idx].getEtape().getNum();
                string medDL = cB_Medicament.Text;

                if (cB_etatDec.Text != "")
                {
                    if (dTP_dateDec.Value <= DateTime.Now)
                    {
                        int idxDec = 0;
                        bool trouveDec = false;
                        int idDec = 0;

                        while (idxDec < Globale.lesDecisions.Count && !trouveDec)
                        {
                            if (Globale.lesDecisions[idxDec].getLeLibelle() == cB_etatDec.Text)
                            {
                                idDec = Globale.lesDecisions[idxDec].getLeId();
                                trouveDec = true;
                            }
                            else
                            {
                                idxDec++;
                            }
                        }

                        DateTime dateDec = dTP_dateDec.Value;

                        Globale.bdd.setDecisionEtape(numEtape, medDL, dateDec, idDec);
                        lesEtapesChoixMed[idx].setDateDecision(dateDec);
                        lesEtapesChoixMed[idx].setDecision(Globale.lesDecisions[idxDec]);

                        cB_Medicament.SelectedIndex = -1;
                        cB_etatDec.SelectedIndex = -1;
                        tB_dateNorme.Text = "";
                        tB_Libelle.Text = "";
                        tB_Norme.Text = "";
                        tB_numEtape.Text = "";
                        lV_EtapesValid.Items.Clear();
                        dTP_dateDec.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Erreur : Vous ne pouvez pas saisir une date de décision supérieur à la date du jour, veuillez la resaisir !", "Erreur date saisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Erreur : Aucun état n'a été sélectionné pour cette décision, veuillez la saisir !", "Erreur état saisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                btn_ajouterDec.Enabled = false;
                MessageBox.Show("Erreur : Aucun médicament n'a été séléctionné, veuillez en saisir un !", "Erreur aucun medicament séléctionné", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
