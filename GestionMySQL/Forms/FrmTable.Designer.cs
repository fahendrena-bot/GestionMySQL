namespace GestionMySQL.Forms
{
    partial class FrmTable
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
            cmbBases = new ComboBox();
            label1 = new Label();
            dgvTables = new DataGridView();
            label2 = new Label();
            txtNomTable = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTables).BeginInit();
            SuspendLayout();
            // 
            // cmbBases
            // 
            cmbBases.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            cmbBases.FormattingEnabled = true;
            cmbBases.Location = new Point(201, 80);
            cmbBases.Name = "cmbBases";
            cmbBases.Size = new Size(247, 27);
            cmbBases.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(30, 78);
            label1.Name = "label1";
            label1.Size = new Size(155, 22);
            label1.TabIndex = 1;
            label1.Text = "Base de données :";
            // 
            // dgvTables
            // 
            dgvTables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTables.Location = new Point(471, 80);
            dgvTables.Name = "dgvTables";
            dgvTables.Size = new Size(464, 229);
            dgvTables.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(30, 139);
            label2.Name = "label2";
            label2.Size = new Size(109, 22);
            label2.TabIndex = 3;
            label2.Text = "Nom Table :";
            // 
            // txtNomTable
            // 
            txtNomTable.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtNomTable.Location = new Point(201, 141);
            txtNomTable.Name = "txtNomTable";
            txtNomTable.Size = new Size(247, 26);
            txtNomTable.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button1.Location = new Point(201, 214);
            button1.Name = "button1";
            button1.Size = new Size(91, 29);
            button1.TabIndex = 5;
            button1.Text = "Afficher";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button2.Location = new Point(350, 214);
            button2.Name = "button2";
            button2.Size = new Size(88, 29);
            button2.TabIndex = 6;
            button2.Text = "Créer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button3.Location = new Point(201, 282);
            button3.Name = "button3";
            button3.Size = new Size(91, 27);
            button3.TabIndex = 7;
            button3.Text = "Supprimer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button4.Location = new Point(350, 282);
            button4.Name = "button4";
            button4.Size = new Size(88, 27);
            button4.TabIndex = 8;
            button4.Text = "Actualiser";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(680, 43);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 9;
            label3.Text = "Resultat";
            // 
            // FrmTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 339);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNomTable);
            Controls.Add(label2);
            Controls.Add(dgvTables);
            Controls.Add(label1);
            Controls.Add(cmbBases);
            Name = "FrmTable";
            Text = "Formulaire_Table";
            Load += FrmTable_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTables).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBases;
        private Label label1;
        private DataGridView dgvTables;
        private Label label2;
        private TextBox txtNomTable;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
    }
}