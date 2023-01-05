using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace gsb_gesAMM_APP
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Globale.bdd = new gestion_bdd("DESKTOP-D046N3G\\SQLEXPRESS", "GSB_gesAMM");
            Globale.bdd.getLesFamilles();
            Globale.bdd.getLesMedicaments();
            Globale.bdd.getLesDecisions();
            Globale.bdd.getLesEtapes();
            Globale.bdd.getLesWorkflows();
            Globale.bdd.getHistModifEtpNormee();

            tb_mdp.PasswordChar = '*';
            tb_mdp.MaxLength = 14;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (tb_nom_utilisateur.Text != "" && tb_mdp.Text != "")
            {
                string idSaisi = tb_nom_utilisateur.Text;

                var bytes = new UTF8Encoding().GetBytes(tb_mdp.Text);
                var hash = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes);
                string mdpSaisi = Convert.ToBase64String(hash);

                if (Globale.bdd.verifConnexion(idSaisi,mdpSaisi))
                {
                    FormMenuMDI obj2 = new FormMenuMDI();
                    obj2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Les données saisies sont incorrectes, veuillez les sasir !", "Erreur : Données d'authentifications incorrectes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Aucune donnée d'authentification n'a été saisi, veuillez les sasir !", "Erreur : Aucune donnée saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
