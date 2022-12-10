
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
            this.lv_famille = new System.Windows.Forms.ListView();
            this.colH_code_famille = new System.Windows.Forms.ColumnHeader();
            this.colH_designation_famille = new System.Windows.Forms.ColumnHeader();
            this.colH_nb_médicament = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_médicament = new System.Windows.Forms.ListView();
            this.colH_code_famille_médicament = new System.Windows.Forms.ColumnHeader();
            this.colH_nom_médicament = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lv_famille
            // 
            this.lv_famille.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colH_code_famille,
            this.colH_designation_famille,
            this.colH_nb_médicament});
            this.lv_famille.HideSelection = false;
            this.lv_famille.Location = new System.Drawing.Point(12, 54);
            this.lv_famille.Name = "lv_famille";
            this.lv_famille.Size = new System.Drawing.Size(535, 419);
            this.lv_famille.TabIndex = 0;
            this.lv_famille.UseCompatibleStateImageBehavior = false;
            this.lv_famille.View = System.Windows.Forms.View.Details;
            this.lv_famille.SelectedIndexChanged += new System.EventHandler(this.lv_famille_SelectedIndexChanged);
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
            // lv_médicament
            // 
            this.lv_médicament.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colH_code_famille_médicament,
            this.colH_nom_médicament});
            this.lv_médicament.HideSelection = false;
            this.lv_médicament.Location = new System.Drawing.Point(553, 54);
            this.lv_médicament.Name = "lv_médicament";
            this.lv_médicament.Size = new System.Drawing.Size(519, 419);
            this.lv_médicament.TabIndex = 2;
            this.lv_médicament.UseCompatibleStateImageBehavior = false;
            this.lv_médicament.View = System.Windows.Forms.View.Details;
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
            this.Controls.Add(this.lv_médicament);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_famille);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsultationNombreMedicament";
            this.Text = "Consultation du nombre de médicament";
            this.Load += new System.EventHandler(this.FormConsultationNombreMedicament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_famille;
        private System.Windows.Forms.ColumnHeader colH_code_famille;
        private System.Windows.Forms.ColumnHeader colH_designation_famille;
        private System.Windows.Forms.ColumnHeader colH_nb_médicament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_médicament;
        private System.Windows.Forms.ColumnHeader colH_code_famille_médicament;
        private System.Windows.Forms.ColumnHeader colH_nom_médicament;
    }
}