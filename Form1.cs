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
            Globale.bdd = new gestion_bdd("DESKTOP-D046N3G\\SQLEXPRESS", "GSB_gesAMM");
            Globale.bdd.getLesFamilles();
            Globale.bdd.getLesMedicaments();
            Globale.bdd.getLesDecisions();
        }
    }
}
