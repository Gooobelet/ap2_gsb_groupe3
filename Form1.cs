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

namespace gsb_gesAMM_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Globale.bdd = new gestion_bdd("DESKTOP-U0QO0RV\\SQLEXPRESS", "GSB_gesAMM");
            Globale.bdd.getLesFamilles();
            Globale.bdd.getLesMedicaments();
            Globale.bdd.getLesDecisions();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            string idSaisi = tb_nom_utilisateur.Text;
            string mdpSaisi = tb_mdp.Text;

            if (idSaisi != "" && mdpSaisi != "")
            {
                if (Globale.bdd.verifConnexion(idSaisi,mdpSaisi))
                {

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
    }
}
