
namespace gsb_gesAMM_APP
{
    partial class FormConsultationNombreMedicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultationNombreMedicament));
            this.listView1 = new System.Windows.Forms.ListView();
            this.colH_code_famille = new System.Windows.Forms.ColumnHeader();
            this.colH_designation_famille = new System.Windows.Forms.ColumnHeader();
            this.colH_nb_médicament = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.colH_code_famille_médicament = new System.Windows.Forms.ColumnHeader();
            this.colH_nom_médicament = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colH_code_famille,
            this.colH_designation_famille,
            this.colH_nb_médicament});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(535, 419);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colH_code_famille
            // 
            this.colH_code_famille.Text = "Code de la Famille";
            // 
            // colH_designation_famille
            // 
            this.colH_designation_famille.Text = "Désignation de la famille";
            // 
            // colH_nb_médicament
            // 
            this.colH_nb_médicament.Text = "Nombre de médicaments autorisés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultation du nombre de médicament autorisé par famille";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colH_code_famille_médicament,
            this.colH_nom_médicament});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(553, 54);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(519, 419);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // colH_code_famille_médicament
            // 
            this.colH_code_famille_médicament.DisplayIndex = 1;
            this.colH_code_famille_médicament.Text = "Code de la famille";
            // 
            // colH_nom_médicament
            // 
            this.colH_nom_médicament.DisplayIndex = 0;
            this.colH_nom_médicament.Text = "Nom commerciale du médicament";
            // 
            // FormConsultationNombreMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1084, 621);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsultationNombreMedicament";
            this.Text = "Consultation du nombre de médicament";
            this.Load += new System.EventHandler(this.FormConsultationNombreMedicament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colH_code_famille;
        private System.Windows.Forms.ColumnHeader colH_designation_famille;
        private System.Windows.Forms.ColumnHeader colH_nb_médicament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader colH_code_famille_médicament;
        private System.Windows.Forms.ColumnHeader colH_nom_médicament;
    }
}