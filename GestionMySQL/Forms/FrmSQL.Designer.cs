namespace GestionMySQL.Forms
{
    partial class FrmSQL
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
            rtbSQL = new RichTextBox();
            btnExcecuter = new Button();
            dgvResultat = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultat).BeginInit();
            SuspendLayout();
            // 
            // rtbSQL
            // 
            rtbSQL.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbSQL.Location = new Point(88, 61);
            rtbSQL.Name = "rtbSQL";
            rtbSQL.Size = new Size(462, 96);
            rtbSQL.TabIndex = 0;
            rtbSQL.Text = "";
            // 
            // btnExcecuter
            // 
            btnExcecuter.BackColor = Color.Teal;
            btnExcecuter.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcecuter.Location = new Point(88, 163);
            btnExcecuter.Name = "btnExcecuter";
            btnExcecuter.Size = new Size(100, 32);
            btnExcecuter.TabIndex = 1;
            btnExcecuter.Text = "Excecuter";
            btnExcecuter.UseVisualStyleBackColor = false;
            btnExcecuter.Click += btnExcecuter_Click;
            // 
            // dgvResultat
            // 
            dgvResultat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultat.Location = new Point(90, 262);
            dgvResultat.Name = "dgvResultat";
            dgvResultat.Size = new Size(460, 160);
            dgvResultat.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(295, 223);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 3;
            label1.Text = "Résultat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 192, 0);
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(256, 18);
            label2.Name = "label2";
            label2.Size = new Size(146, 31);
            label2.TabIndex = 4;
            label2.Text = "Script SQL";
            // 
            // FrmSQL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvResultat);
            Controls.Add(btnExcecuter);
            Controls.Add(rtbSQL);
            Name = "FrmSQL";
            Text = "FrmSQL";
            ((System.ComponentModel.ISupportInitialize)dgvResultat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbSQL;
        private Button btnExcecuter;
        private DataGridView dgvResultat;
        private Label label1;
        private Label label2;
    }
}