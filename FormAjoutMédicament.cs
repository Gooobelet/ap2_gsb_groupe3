using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gsb_gesAMM_APP
{
    public partial class FormAjoutMédicament : Form
    {
        public FormAjoutMédicament()
        {
            InitializeComponent();
        }

        private void FormAjoutMédicament_Load(object sender, EventArgs e)
        {
            foreach (Famille fam in Globale.lesFamilles.Values)
            {
                cb_code_famille.Items.Add(fam.getCode());
            }
        }

        private void btn_ajouter_med_Click(object sender, EventArgs e)
        {
            string depotlegale = tb_depot_legale.Text;
            string nomcommerciale = tb_nmo_commerciale.Text;
            string famcode = cb_code_famille.Text;
            string composition = tb_composition.Text;
            string effets = Rtb_effets.Text;
            string contreindication = Rtb_contre_indication.Text;
            string prixechantillon = tb_prix_echantillon.Text;

            if (depotlegale != "" && nomcommerciale != "" && composition != "" && effets != "" && contreindication != "" && prixechantillon!= "" && famcode != "")
            {
                if (!Globale.lesMedicaments.ContainsKey(tb_depot_legale.Text))
                {
                    try
                    {
                        Globale.bdd.setMedicament(depotlegale, nomcommerciale, famcode, composition, effets, contreindication, Convert.ToDouble(prixechantillon));
                        MessageBox.Show("Médicaments bien ajouté !");
                    }
                    catch
                    {
                        MessageBox.Show("La valeur saisis n'est pas un nombre réel", "Erreur", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Erreur dans la saisis des données", "Erreur", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void cb_code_famille_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
