
namespace gsb_gesAMM_APP
{
    partial class FormSaisieDecision
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
            this.cB_Medicament = new System.Windows.Forms.ComboBox();
            this.lV_EtapesValid = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tB_dateNorme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_Norme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_Libelle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_Date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_numEtape = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dTP_dateDec = new System.Windows.Forms.DateTimePicker();
            this.cB_etatDec = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_ajouterDec = new System.Windows.Forms.Button();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Médicament :";
            // 
            // cB_Medicament
            // 
            this.cB_Medicament.FormattingEnabled = true;
            this.cB_Medicament.Location = new System.Drawing.Point(315, 57);
            this.cB_Medicament.Name = "cB_Medicament";
            this.cB_Medicament.Size = new System.Drawing.Size(121, 23);
            this.cB_Medicament.TabIndex = 1;
            // 
            // lV_EtapesValid
            // 
            this.lV_EtapesValid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lV_EtapesValid.HideSelection = false;
            this.lV_EtapesValid.Location = new System.Drawing.Point(95, 126);
            this.lV_EtapesValid.Name = "lV_EtapesValid";
            this.lV_EtapesValid.Size = new System.Drawing.Size(540, 97);
            this.lV_EtapesValid.TabIndex = 2;
            this.lV_EtapesValid.UseCompatibleStateImageBehavior = false;
            this.lV_EtapesValid.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_dateNorme);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tB_Norme);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tB_Libelle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tB_Date);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tB_numEtape);
            this.groupBox1.Location = new System.Drawing.Point(77, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etape en attente de décision";
            // 
            // tB_dateNorme
            // 
            this.tB_dateNorme.Location = new System.Drawing.Point(466, 46);
            this.tB_dateNorme.Name = "tB_dateNorme";
            this.tB_dateNorme.Size = new System.Drawing.Size(103, 23);
            this.tB_dateNorme.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date de la norme :";
            // 
            // tB_Norme
            // 
            this.tB_Norme.Location = new System.Drawing.Point(388, 46);
            this.tB_Norme.Name = "tB_Norme";
            this.tB_Norme.Size = new System.Drawing.Size(72, 23);
            this.tB_Norme.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Norme :";
            // 
            // tB_Libelle
            // 
            this.tB_Libelle.Location = new System.Drawing.Point(184, 46);
            this.tB_Libelle.Name = "tB_Libelle";
            this.tB_Libelle.Size = new System.Drawing.Size(198, 23);
            this.tB_Libelle.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Libellé :";
            // 
            // tB_Date
            // 
            this.tB_Date.Location = new System.Drawing.Point(81, 46);
            this.tB_Date.Name = "tB_Date";
            this.tB_Date.Size = new System.Drawing.Size(97, 23);
            this.tB_Date.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numéro :";
            // 
            // tB_numEtape
            // 
            this.tB_numEtape.Location = new System.Drawing.Point(18, 46);
            this.tB_numEtape.Name = "tB_numEtape";
            this.tB_numEtape.Size = new System.Drawing.Size(57, 23);
            this.tB_numEtape.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Etape(s) précédement validée(s) :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ajouterDec);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dTP_dateDec);
            this.groupBox2.Controls.Add(this.cB_etatDec);
            this.groupBox2.Location = new System.Drawing.Point(111, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 120);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajout de la décision";
            // 
            // dTP_dateDec
            // 
            this.dTP_dateDec.Location = new System.Drawing.Point(251, 47);
            this.dTP_dateDec.Name = "dTP_dateDec";
            this.dTP_dateDec.Size = new System.Drawing.Size(200, 23);
            this.dTP_dateDec.TabIndex = 6;
            // 
            // cB_etatDec
            // 
            this.cB_etatDec.FormattingEnabled = true;
            this.cB_etatDec.Location = new System.Drawing.Point(59, 47);
            this.cB_etatDec.Name = "cB_etatDec";
            this.cB_etatDec.Size = new System.Drawing.Size(121, 23);
            this.cB_etatDec.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Etat :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Date :";
            // 
            // btn_ajouterDec
            // 
            this.btn_ajouterDec.Location = new System.Drawing.Point(205, 89);
            this.btn_ajouterDec.Name = "btn_ajouterDec";
            this.btn_ajouterDec.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouterDec.TabIndex = 11;
            this.btn_ajouterDec.Text = "Ajouter";
            this.btn_ajouterDec.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numéro";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Libellé";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Norme";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date de la norme";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date de la décision";
            this.columnHeader6.Width = 115;
            // 
            // FormSaisieDecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lV_EtapesValid);
            this.Controls.Add(this.cB_Medicament);
            this.Controls.Add(this.label1);
            this.Name = "FormSaisieDecision";
            this.Text = "FormSaisieDecision";
            this.Load += new System.EventHandler(this.FormSaisieDecision_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_Medicament;
        private System.Windows.Forms.ListView lV_EtapesValid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tB_Norme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tB_Libelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_numEtape;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_dateNorme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dTP_dateDec;
        private System.Windows.Forms.ComboBox cB_etatDec;
        private System.Windows.Forms.Button btn_ajouterDec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}