
namespace gsb_gesAMM_APP
{
    partial class FormConsultationWorkFlowMedicament
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
            this.label1 = new System.Windows.Forms.Label();
            this.lv_med_non_autorisé = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.lv_med_workflow = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultation des médicaments en cours de validation";
            // 
            // lv_med_non_autorisé
            // 
            this.lv_med_non_autorisé.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_med_non_autorisé.HideSelection = false;
            this.lv_med_non_autorisé.Location = new System.Drawing.Point(12, 59);
            this.lv_med_non_autorisé.Name = "lv_med_non_autorisé";
            this.lv_med_non_autorisé.Size = new System.Drawing.Size(527, 388);
            this.lv_med_non_autorisé.TabIndex = 3;
            this.lv_med_non_autorisé.UseCompatibleStateImageBehavior = false;
            this.lv_med_non_autorisé.View = System.Windows.Forms.View.Details;
            this.lv_med_non_autorisé.SelectedIndexChanged += new System.EventHandler(this.lv_med_non_autorisé_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dépot Légale";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom Commercial";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Libellé Famille";
            this.columnHeader3.Width = 100;
            // 
            // lv_med_workflow
            // 
            this.lv_med_workflow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_med_workflow.HideSelection = false;
            this.lv_med_workflow.Location = new System.Drawing.Point(584, 59);
            this.lv_med_workflow.Name = "lv_med_workflow";
            this.lv_med_workflow.Size = new System.Drawing.Size(517, 388);
            this.lv_med_workflow.TabIndex = 4;
            this.lv_med_workflow.UseCompatibleStateImageBehavior = false;
            this.lv_med_workflow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Numéro Étape";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dépot Légale";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date de Décision";
            this.columnHeader6.Width = 115;
            // 
            // FormConsultationWorkFlowMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1113, 574);
            this.Controls.Add(this.lv_med_workflow);
            this.Controls.Add(this.lv_med_non_autorisé);
            this.Controls.Add(this.label1);
            this.Name = "FormConsultationWorkFlowMedicament";
            this.Text = "FormConsultationWorkFlowMedicament";
            this.Load += new System.EventHandler(this.FormConsultationWorkFlowMedicament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_med_non_autorisé;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lv_med_workflow;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}