
namespace gsb_gesAMM_APP
{
    partial class FormConsultationEtapesWorkflow
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
            this.cB_Med = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lV_EtapeWorkflow = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cB_Med
            // 
            this.cB_Med.FormattingEnabled = true;
            this.cB_Med.Location = new System.Drawing.Point(336, 53);
            this.cB_Med.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cB_Med.Name = "cB_Med";
            this.cB_Med.Size = new System.Drawing.Size(133, 23);
            this.cB_Med.TabIndex = 0;
            this.cB_Med.SelectedIndexChanged += new System.EventHandler(this.cB_Med_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Médicament :";
            // 
            // lV_EtapeWorkflow
            // 
            this.lV_EtapeWorkflow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lV_EtapeWorkflow.HideSelection = false;
            this.lV_EtapeWorkflow.Location = new System.Drawing.Point(19, 128);
            this.lV_EtapeWorkflow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lV_EtapeWorkflow.Name = "lV_EtapeWorkflow";
            this.lV_EtapeWorkflow.Size = new System.Drawing.Size(745, 286);
            this.lV_EtapeWorkflow.TabIndex = 2;
            this.lV_EtapeWorkflow.UseCompatibleStateImageBehavior = false;
            this.lV_EtapeWorkflow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numéro";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Libellé";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date de la décision";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Libellé de la décision";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Norme";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date de la norme";
            this.columnHeader6.Width = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Etape(s) par médicament :";
            // 
            // FormConsultationEtapesWorkflow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lV_EtapeWorkflow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_Med);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormConsultationEtapesWorkflow";
            this.Text = "FormConsultationEtapesWorkflow";
            this.Load += new System.EventHandler(this.FormConsultationEtapesWorkflow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cB_Med;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lV_EtapeWorkflow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
    }
}