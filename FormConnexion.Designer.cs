
namespace gsb_gesAMM_APP
{
    partial class FormConnexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.lb_connection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nom_utilisateur = new System.Windows.Forms.TextBox();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-5, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 577);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 226);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_valider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_valider.Location = new System.Drawing.Point(799, 389);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(140, 39);
            this.btn_valider.TabIndex = 12;
            this.btn_valider.Text = "VALIDER";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(710, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mot de passe :";
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(799, 302);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.PasswordChar = '*';
            this.tb_mdp.Size = new System.Drawing.Size(140, 23);
            this.tb_mdp.TabIndex = 10;
            // 
            // lb_connection
            // 
            this.lb_connection.AutoSize = true;
            this.lb_connection.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_connection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_connection.Location = new System.Drawing.Point(747, 96);
            this.lb_connection.Name = "lb_connection";
            this.lb_connection.Size = new System.Drawing.Size(232, 46);
            this.lb_connection.TabIndex = 9;
            this.lb_connection.Text = "CONNECTION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(688, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // tb_nom_utilisateur
            // 
            this.tb_nom_utilisateur.Location = new System.Drawing.Point(799, 264);
            this.tb_nom_utilisateur.Name = "tb_nom_utilisateur";
            this.tb_nom_utilisateur.Size = new System.Drawing.Size(140, 23);
            this.tb_nom_utilisateur.TabIndex = 7;
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_quitter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_quitter.Location = new System.Drawing.Point(967, 511);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(140, 39);
            this.btn_quitter.TabIndex = 14;
            this.btn_quitter.Text = "QUITTER";
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1119, 562);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_mdp);
            this.Controls.Add(this.lb_connection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nom_utilisateur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConnexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.Label lb_connection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nom_utilisateur;
        private System.Windows.Forms.Button btn_quitter;
    }
}

