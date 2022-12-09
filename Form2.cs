using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gsb_gesAMM_APP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //Cette form s'ouvrira qu'une seule fois
        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Form3")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (isOpen == false)
            {
                Form3 f3 = new Form3();
                f3.MdiParent = this;
                f3.Show();
            }
        }
    }
}
