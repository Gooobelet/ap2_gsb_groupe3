
namespace gsb_gesAMM_APP
{
    partial class FormMenuMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuMDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToutesLesPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDeMédicamentParFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDeMédicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.médicamentToolStripMenuItem,
            this.etapeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fermerToutesLesPagesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // fermerToutesLesPagesToolStripMenuItem
            // 
            this.fermerToutesLesPagesToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.fermerToutesLesPagesToolStripMenuItem.Name = "fermerToutesLesPagesToolStripMenuItem";
            this.fermerToutesLesPagesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.fermerToutesLesPagesToolStripMenuItem.Text = "Fermer toutes les pages";
            this.fermerToutesLesPagesToolStripMenuItem.Click += new System.EventHandler(this.fermerToutesLesPagesToolStripMenuItem_Click_1);
            // 
            // médicamentToolStripMenuItem
            // 
            this.médicamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreDeMédicamentParFamilleToolStripMenuItem,
            this.ajoutDeMédicamentToolStripMenuItem});
            this.médicamentToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.médicamentToolStripMenuItem.Name = "médicamentToolStripMenuItem";
            this.médicamentToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.médicamentToolStripMenuItem.Text = "Médicament";
            // 
            // nombreDeMédicamentParFamilleToolStripMenuItem
            // 
            this.nombreDeMédicamentParFamilleToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.nombreDeMédicamentParFamilleToolStripMenuItem.Name = "nombreDeMédicamentParFamilleToolStripMenuItem";
            this.nombreDeMédicamentParFamilleToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.nombreDeMédicamentParFamilleToolStripMenuItem.Text = "Nombre de médicament par famille";
            this.nombreDeMédicamentParFamilleToolStripMenuItem.Click += new System.EventHandler(this.nombreDeMédicamentParFamilleToolStripMenuItem_Click);
            // 
            // ajoutDeMédicamentToolStripMenuItem
            // 
            this.ajoutDeMédicamentToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.ajoutDeMédicamentToolStripMenuItem.Name = "ajoutDeMédicamentToolStripMenuItem";
            this.ajoutDeMédicamentToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.ajoutDeMédicamentToolStripMenuItem.Text = "Ajout de médicament";
            this.ajoutDeMédicamentToolStripMenuItem.Click += new System.EventHandler(this.ajoutDeMédicamentToolStripMenuItem_Click);
            // 
            // etapeToolStripMenuItem
            // 
            this.etapeToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.etapeToolStripMenuItem.Name = "etapeToolStripMenuItem";
            this.etapeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.etapeToolStripMenuItem.Text = "Etape";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // FormMenuMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuMDI";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDeMédicamentParFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDeMédicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToutesLesPagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}