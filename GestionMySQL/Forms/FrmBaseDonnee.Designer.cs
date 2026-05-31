namespace GestionMySQL.Forms
{
    partial class FrmBaseDonnee
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
            dgvBases = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            txtNomBase = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBases).BeginInit();
            SuspendLayout();
            // 
            // dgvBases
            // 
            dgvBases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBases.Location = new Point(161, 94);
            dgvBases.Name = "dgvBases";
            dgvBases.Size = new Size(471, 288);
            dgvBases.TabIndex = 0;
            dgvBases.CellContentClick += dgvBases_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button1.Location = new Point(503, 408);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Créer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button2.Location = new Point(199, 408);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Afficher";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button3.Location = new Point(503, 463);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Actualiser";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button4.Location = new Point(199, 463);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Supprimer";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(21, 28);
            label1.Name = "label1";
            label1.Size = new Size(145, 22);
            label1.TabIndex = 5;
            label1.Text = "Nom de la base :";
            // 
            // txtNomBase
            // 
            txtNomBase.Location = new Point(213, 30);
            txtNomBase.Name = "txtNomBase";
            txtNomBase.Size = new Size(354, 23);
            txtNomBase.TabIndex = 6;
            // 
            // FrmBaseDonnee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 501);
            Controls.Add(txtNomBase);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvBases);
            Name = "FrmBaseDonnee";
            Text = "FrmBaseDonnee";
            ((System.ComponentModel.ISupportInitialize)dgvBases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBases;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private TextBox txtNomBase;
    }
}