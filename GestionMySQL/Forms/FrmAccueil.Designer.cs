namespace GestionMySQL
{
    partial class FrmAccueil
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
            button_table = new Button();
            button_sql = new Button();
            deconnexion = new Button();
            btnBase = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_table
            // 
            button_table.BackColor = Color.FromArgb(128, 255, 128);
            button_table.Font = new Font("Times New Roman", 9F);
            button_table.Location = new Point(449, 163);
            button_table.Name = "button_table";
            button_table.Size = new Size(94, 23);
            button_table.TabIndex = 0;
            button_table.Text = "Gestion Tables";
            button_table.UseVisualStyleBackColor = false;
            button_table.Click += button_table_Click;
            // 
            // button_sql
            // 
            button_sql.BackColor = Color.FromArgb(128, 64, 64);
            button_sql.Font = new Font("Times New Roman", 9F);
            button_sql.Location = new Point(196, 263);
            button_sql.Name = "button_sql";
            button_sql.Size = new Size(101, 23);
            button_sql.TabIndex = 1;
            button_sql.Text = "Excecuter SQL";
            button_sql.UseVisualStyleBackColor = false;
            button_sql.Click += button_sql_Click;
            // 
            // deconnexion
            // 
            deconnexion.Font = new Font("Times New Roman", 9F);
            deconnexion.Location = new Point(449, 263);
            deconnexion.Name = "deconnexion";
            deconnexion.Size = new Size(94, 23);
            deconnexion.TabIndex = 2;
            deconnexion.Text = "Deconnexion";
            deconnexion.UseVisualStyleBackColor = true;
            deconnexion.Click += deconnexion_Click;
            // 
            // btnBase
            // 
            btnBase.BackColor = Color.Teal;
            btnBase.Font = new Font("Times New Roman", 9F);
            btnBase.ForeColor = Color.Black;
            btnBase.Location = new Point(196, 163);
            btnBase.Name = "btnBase";
            btnBase.Size = new Size(101, 23);
            btnBase.TabIndex = 3;
            btnBase.Text = "Gestion Bases";
            btnBase.UseVisualStyleBackColor = false;
            btnBase.Click += btnBase_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(281, 72);
            label1.Name = "label1";
            label1.Size = new Size(184, 24);
            label1.TabIndex = 4;
            label1.Text = "GESTION MYSQL";
            // 
            // FrmAccueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 349);
            Controls.Add(label1);
            Controls.Add(btnBase);
            Controls.Add(deconnexion);
            Controls.Add(button_sql);
            Controls.Add(button_table);
            Name = "FrmAccueil";
            Text = "FrmAcceuil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_table;
        private Button button_sql;
        private Button deconnexion;
        private Button btnBase;
        private Label label1;
    }
}