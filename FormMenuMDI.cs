using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gsb_gesAMM_APP
{
    public partial class FormMenuMDI : Form
    {
        public FormMenuMDI()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //Cette form s'ouvrira qu'une seule fois
        private void nombreDeMédicamentParFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FormConsultationNombreMedicament")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (isOpen == false)
            {
                FormConsultationNombreMedicament f4 = new FormConsultationNombreMedicament();
                f4.MdiParent = this;
                f4.Show();
            }
        }

        //Cette form s'ouvrira qu'une seule fois
        private void ajoutDeMédicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FormAjoutMédicament")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (isOpen == false)
            {
                FormAjoutMédicament f3 = new FormAjoutMédicament();
                f3.MdiParent = this;
                f3.Show();
            }
        }

        //Ceci permet de fermer toutes les form ouvert
        private void fermerToutesLesPagesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saisirLaDécisionDuneÉtapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FormSaisieDecision")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (isOpen == false)
            {
                FormSaisieDecision f5 = new FormSaisieDecision();
                f5.MdiParent = this;
                f5.Show();
            }
        }
    }
}
