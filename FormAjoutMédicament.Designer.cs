
namespace gsb_gesAMM_APP
{
    partial class FormAjoutMédicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjoutMédicament));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rtb_contre_indication = new System.Windows.Forms.RichTextBox();
            this.Rtb_effets = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_composition = new System.Windows.Forms.TextBox();
            this.tb_nmo_commerciale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_depot_legale = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ajouter_med = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_code_famille = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_prix_echantillon = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ajout d\'un medicament";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_prix_echantillon);
            this.groupBox1.Controls.Add(this.Rtb_contre_indication);
            this.groupBox1.Controls.Add(this.Rtb_effets);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_composition);
            this.groupBox1.Controls.Add(this.tb_nmo_commerciale);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_depot_legale);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(327, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 314);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout medicament";
            // 
            // Rtb_contre_indication
            // 
            this.Rtb_contre_indication.Location = new System.Drawing.Point(141, 195);
            this.Rtb_contre_indication.Name = "Rtb_contre_indication";
            this.Rtb_contre_indication.Size = new System.Drawing.Size(180, 63);
            this.Rtb_contre_indication.TabIndex = 10;
            this.Rtb_contre_indication.Text = "";
            // 
            // Rtb_effets
            // 
            this.Rtb_effets.Location = new System.Drawing.Point(141, 126);
            this.Rtb_effets.Name = "Rtb_effets";
            this.Rtb_effets.Size = new System.Drawing.Size(180, 63);
            this.Rtb_effets.TabIndex = 5;
            this.Rtb_effets.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contre indication :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Effets :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Composition :";
            // 
            // tb_composition
            // 
            this.tb_composition.Location = new System.Drawing.Point(141, 97);
            this.tb_composition.Name = "tb_composition";
            this.tb_composition.Size = new System.Drawing.Size(180, 23);
            this.tb_composition.TabIndex = 4;
            // 
            // tb_nmo_commerciale
            // 
            this.tb_nmo_commerciale.Location = new System.Drawing.Point(141, 68);
            this.tb_nmo_commerciale.Name = "tb_nmo_commerciale";
            this.tb_nmo_commerciale.Size = new System.Drawing.Size(180, 23);
            this.tb_nmo_commerciale.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom Commerciale :";
            // 
            // tb_depot_legale
            // 
            this.tb_depot_legale.Location = new System.Drawing.Point(141, 39);
            this.tb_depot_legale.Name = "tb_depot_legale";
            this.tb_depot_legale.Size = new System.Drawing.Size(180, 23);
            this.tb_depot_legale.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Depot légale :";
            // 
            // btn_ajouter_med
            // 
            this.btn_ajouter_med.Location = new System.Drawing.Point(578, 455);
            this.btn_ajouter_med.Name = "btn_ajouter_med";
            this.btn_ajouter_med.Size = new System.Drawing.Size(97, 30);
            this.btn_ajouter_med.TabIndex = 4;
            this.btn_ajouter_med.Text = "Ajouter";
            this.btn_ajouter_med.UseVisualStyleBackColor = true;
            this.btn_ajouter_med.Click += new System.EventHandler(this.btn_ajouter_med_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(397, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Famille :";
            // 
            // cb_code_famille
            // 
            this.cb_code_famille.FormattingEnabled = true;
            this.cb_code_famille.Location = new System.Drawing.Point(454, 70);
            this.cb_code_famille.Name = "cb_code_famille";
            this.cb_code_famille.Size = new System.Drawing.Size(121, 23);
            this.cb_code_famille.TabIndex = 6;
            this.cb_code_famille.SelectedIndexChanged += new System.EventHandler(this.cb_code_famille_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Prix Echantillon :";
            // 
            // tb_prix_echantillon
            // 
            this.tb_prix_echantillon.Location = new System.Drawing.Point(141, 264);
            this.tb_prix_echantillon.Name = "tb_prix_echantillon";
            this.tb_prix_echantillon.Size = new System.Drawing.Size(180, 23);
            this.tb_prix_echantillon.TabIndex = 11;
            // 
            // FormAjoutMédicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1039, 574);
            this.Controls.Add(this.cb_code_famille);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_ajouter_med);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjoutMédicament";
            this.Text = "Ajout d\'un médicament";
            this.Load += new System.EventHandler(this.FormAjoutMédicament_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_composition;
        private System.Windows.Forms.TextBox tb_nmo_commerciale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_depot_legale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Rtb_contre_indication;
        private System.Windows.Forms.RichTextBox Rtb_effets;
        private System.Windows.Forms.Button btn_ajouter_med;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_code_famille;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_prix_echantillon;
    }
}