namespace Teretana
{
    partial class ListaClanova
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbIme = new TextBox();
            tbPrezime = new TextBox();
            gbPretraga = new GroupBox();
            btnOcisti = new Button();
            btnPretrazi = new Button();
            dgVelika = new DataGridView();
            lbConnection = new Label();
            gbPretraga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgVelika).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 19);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 0;
            label1.Text = "Pretraga:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 52);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Ime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 81);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Prezime:";
            // 
            // tbIme
            // 
            tbIme.Location = new Point(100, 49);
            tbIme.Name = "tbIme";
            tbIme.Size = new Size(100, 23);
            tbIme.TabIndex = 3;
            // 
            // tbPrezime
            // 
            tbPrezime.Location = new Point(100, 78);
            tbPrezime.Name = "tbPrezime";
            tbPrezime.Size = new Size(100, 23);
            tbPrezime.TabIndex = 4;
            // 
            // gbPretraga
            // 
            gbPretraga.Controls.Add(btnOcisti);
            gbPretraga.Controls.Add(btnPretrazi);
            gbPretraga.Controls.Add(label1);
            gbPretraga.Controls.Add(tbPrezime);
            gbPretraga.Controls.Add(label2);
            gbPretraga.Controls.Add(tbIme);
            gbPretraga.Controls.Add(label3);
            gbPretraga.Location = new Point(12, 12);
            gbPretraga.Name = "gbPretraga";
            gbPretraga.Size = new Size(246, 183);
            gbPretraga.TabIndex = 5;
            gbPretraga.TabStop = false;
            // 
            // btnOcisti
            // 
            btnOcisti.Location = new Point(126, 117);
            btnOcisti.Name = "btnOcisti";
            btnOcisti.Size = new Size(100, 33);
            btnOcisti.TabIndex = 6;
            btnOcisti.Text = "Ocisti/Osvezi";
            btnOcisti.UseVisualStyleBackColor = true;
            btnOcisti.Click += btnOcisti_Click;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(20, 117);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(100, 33);
            btnPretrazi.TabIndex = 5;
            btnPretrazi.Text = "Pretrazi";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // dgVelika
            // 
            dgVelika.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgVelika.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgVelika.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVelika.Location = new Point(273, 12);
            dgVelika.Name = "dgVelika";
            dgVelika.ReadOnly = true;
            dgVelika.RowTemplate.Height = 25;
            dgVelika.Size = new Size(979, 657);
            dgVelika.TabIndex = 6;
            dgVelika.CellDoubleClick += dgVelika_CellDoubleClick;
            // 
            // lbConnection
            // 
            lbConnection.AutoSize = true;
            lbConnection.Location = new Point(12, 654);
            lbConnection.Name = "lbConnection";
            lbConnection.Size = new Size(106, 15);
            lbConnection.TabIndex = 7;
            lbConnection.Text = "Baza nije povezana";
            // 
            // ListaClanova
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(lbConnection);
            Controls.Add(dgVelika);
            Controls.Add(gbPretraga);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ListaClanova";
            Text = "ListaClanova";
            Load += ListaClanova_Load;
            gbPretraga.ResumeLayout(false);
            gbPretraga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgVelika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbIme;
        private TextBox tbPrezime;
        private GroupBox gbPretraga;
        private Button btnPretrazi;
        private DataGridView dgVelika;
        private Label lbConnection;
        private Button btnOcisti;
    }
}