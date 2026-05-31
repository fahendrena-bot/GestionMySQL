namespace GestionMySQL
{
    partial class FrmConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConnexion));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            txtServeur = new TextBox();
            txtPort = new TextBox();
            txtUtilisateur = new TextBox();
            label5 = new Label();
            txtMotPasse = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Name = "label4";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtServeur
            // 
            resources.ApplyResources(txtServeur, "txtServeur");
            txtServeur.Name = "txtServeur";
            // 
            // txtPort
            // 
            resources.ApplyResources(txtPort, "txtPort");
            txtPort.Name = "txtPort";
            // 
            // txtUtilisateur
            // 
            resources.ApplyResources(txtUtilisateur, "txtUtilisateur");
            txtUtilisateur.Name = "txtUtilisateur";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.Teal;
            label5.Name = "label5";
            // 
            // txtMotPasse
            // 
            resources.ApplyResources(txtMotPasse, "txtMotPasse");
            txtMotPasse.Name = "txtMotPasse";
            txtMotPasse.UseSystemPasswordChar = true;
            // 
            // FrmConnexion
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtMotPasse);
            Controls.Add(label5);
            Controls.Add(txtUtilisateur);
            Controls.Add(txtPort);
            Controls.Add(txtServeur);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmConnexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox txtServeur;
        private TextBox txtPort;
        private TextBox txtUtilisateur;
        private Label label5;
        private MaskedTextBox txtMotPasse;
    }
}
