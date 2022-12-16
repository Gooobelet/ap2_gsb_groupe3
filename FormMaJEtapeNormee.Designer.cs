
namespace gsb_gesAMM_APP
{
    partial class FormMaJEtapeNormee
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
            this.cB_EtapeNormee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Norme = new System.Windows.Forms.TextBox();
            this.dTP_dateNorme = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_modifierNorme = new System.Windows.Forms.Button();
            this.lV_historiqueModif = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etape normée :";
            // 
            // cB_EtapeNormee
            // 
            this.cB_EtapeNormee.FormattingEnabled = true;
            this.cB_EtapeNormee.Location = new System.Drawing.Point(361, 25);
            this.cB_EtapeNormee.Name = "cB_EtapeNormee";
            this.cB_EtapeNormee.Size = new System.Drawing.Size(121, 23);
            this.cB_EtapeNormee.TabIndex = 1;
            this.cB_EtapeNormee.SelectedIndexChanged += new System.EventHandler(this.cB_EtapeNormee_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Norme :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date de la norme :";
            // 
            // tB_Norme
            // 
            this.tB_Norme.Location = new System.Drawing.Point(15, 53);
            this.tB_Norme.Name = "tB_Norme";
            this.tB_Norme.Size = new System.Drawing.Size(132, 23);
            this.tB_Norme.TabIndex = 4;
            // 
            // dTP_dateNorme
            // 
            this.dTP_dateNorme.Location = new System.Drawing.Point(171, 53);
            this.dTP_dateNorme.Name = "dTP_dateNorme";
            this.dTP_dateNorme.Size = new System.Drawing.Size(200, 23);
            this.dTP_dateNorme.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_modifierNorme);
            this.groupBox1.Controls.Add(this.tB_Norme);
            this.groupBox1.Controls.Add(this.dTP_dateNorme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(161, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 129);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifier la norme :";
            // 
            // btn_modifierNorme
            // 
            this.btn_modifierNorme.Location = new System.Drawing.Point(161, 91);
            this.btn_modifierNorme.Name = "btn_modifierNorme";
            this.btn_modifierNorme.Size = new System.Drawing.Size(75, 23);
            this.btn_modifierNorme.TabIndex = 7;
            this.btn_modifierNorme.Text = "Modifer";
            this.btn_modifierNorme.UseVisualStyleBackColor = true;
            this.btn_modifierNorme.Click += new System.EventHandler(this.btn_modifierNorme_Click);
            // 
            // lV_historiqueModif
            // 
            this.lV_historiqueModif.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lV_historiqueModif.HideSelection = false;
            this.lV_historiqueModif.Location = new System.Drawing.Point(103, 229);
            this.lV_historiqueModif.Name = "lV_historiqueModif";
            this.lV_historiqueModif.Size = new System.Drawing.Size(546, 184);
            this.lV_historiqueModif.TabIndex = 7;
            this.lV_historiqueModif.UseCompatibleStateImageBehavior = false;
            this.lV_historiqueModif.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numéro";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date de la modification";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Libellé";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Norme";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date de la norme";
            this.columnHeader5.Width = 140;
            // 
            // FormMaJEtapeNormee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.lV_historiqueModif);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cB_EtapeNormee);
            this.Controls.Add(this.label1);
            this.Name = "FormMaJEtapeNormee";
            this.Text = "FormMaJEtapeNormee";
            this.Load += new System.EventHandler(this.FormMaJEtapeNormee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_EtapeNormee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Norme;
        private System.Windows.Forms.DateTimePicker dTP_dateNorme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_modifierNorme;
        private System.Windows.Forms.ListView lV_historiqueModif;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}