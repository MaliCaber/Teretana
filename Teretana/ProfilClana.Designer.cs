namespace Teretana
{
    partial class ProfilClana
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
            pbSlika = new PictureBox();
            tbBrIndex = new TextBox();
            tbAdresa = new TextBox();
            tbEmail = new TextBox();
            tbBrTel = new TextBox();
            tbPrezime = new TextBox();
            tbIme = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbIDclana = new TextBox();
            label7 = new Label();
            lbConnection = new Label();
            rbZ = new RadioButton();
            rbM = new RadioButton();
            label8 = new Label();
            dgUplate = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            dgPosete = new DataGridView();
            btnIzmeni = new Button();
            label11 = new Label();
            btnSlika = new Button();
            btnObrisi = new Button();
            btnQR = new Button();
            pbQR = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgUplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPosete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQR).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Image = Properties.Resources.image_processing20210620_28232_baqx1v;
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(197, 197);
            pbSlika.SizeMode = PictureBoxSizeMode.Zoom;
            pbSlika.TabIndex = 27;
            pbSlika.TabStop = false;
            // 
            // tbBrIndex
            // 
            tbBrIndex.Location = new Point(297, 186);
            tbBrIndex.Name = "tbBrIndex";
            tbBrIndex.Size = new Size(210, 23);
            tbBrIndex.TabIndex = 26;
            // 
            // tbAdresa
            // 
            tbAdresa.Location = new Point(297, 157);
            tbAdresa.Name = "tbAdresa";
            tbAdresa.Size = new Size(210, 23);
            tbAdresa.TabIndex = 25;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(297, 128);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(210, 23);
            tbEmail.TabIndex = 24;
            // 
            // tbBrTel
            // 
            tbBrTel.Location = new Point(297, 99);
            tbBrTel.Name = "tbBrTel";
            tbBrTel.Size = new Size(210, 23);
            tbBrTel.TabIndex = 23;
            // 
            // tbPrezime
            // 
            tbPrezime.Location = new Point(297, 70);
            tbPrezime.Name = "tbPrezime";
            tbPrezime.Size = new Size(210, 23);
            tbPrezime.TabIndex = 22;
            // 
            // tbIme
            // 
            tbIme.Location = new Point(297, 41);
            tbIme.Name = "tbIme";
            tbIme.Size = new Size(210, 23);
            tbIme.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(231, 189);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 20;
            label6.Text = "Br. Index:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 160);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 19;
            label5.Text = "Adresa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 131);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 18;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 102);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 17;
            label3.Text = "Broj Tel:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 73);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 16;
            label2.Text = "Prezime:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 44);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 15;
            label1.Text = "Ime:";
            // 
            // tbIDclana
            // 
            tbIDclana.Location = new Point(297, 12);
            tbIDclana.Name = "tbIDclana";
            tbIDclana.ReadOnly = true;
            tbIDclana.Size = new Size(210, 23);
            tbIDclana.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(231, 15);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 29;
            label7.Text = "ID:";
            // 
            // lbConnection
            // 
            lbConnection.AutoSize = true;
            lbConnection.Location = new Point(12, 657);
            lbConnection.Name = "lbConnection";
            lbConnection.Size = new Size(106, 15);
            lbConnection.TabIndex = 30;
            lbConnection.Text = "Baza nije povezana";
            // 
            // rbZ
            // 
            rbZ.AutoSize = true;
            rbZ.Location = new Point(359, 215);
            rbZ.Name = "rbZ";
            rbZ.Size = new Size(32, 19);
            rbZ.TabIndex = 33;
            rbZ.Text = "Z";
            rbZ.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            rbM.AutoSize = true;
            rbM.Checked = true;
            rbM.Location = new Point(297, 215);
            rbM.Name = "rbM";
            rbM.Size = new Size(36, 19);
            rbM.TabIndex = 32;
            rbM.TabStop = true;
            rbM.Text = "M";
            rbM.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(231, 217);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 31;
            label8.Text = "Pol:";
            // 
            // dgUplate
            // 
            dgUplate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgUplate.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgUplate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUplate.Location = new Point(694, 12);
            dgUplate.Name = "dgUplate";
            dgUplate.ReadOnly = true;
            dgUplate.RowTemplate.Height = 25;
            dgUplate.Size = new Size(457, 220);
            dgUplate.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(633, 15);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 35;
            label9.Text = "Uplate:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(633, 246);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 36;
            label10.Text = "Posete:";
            // 
            // dgPosete
            // 
            dgPosete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgPosete.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgPosete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPosete.Location = new Point(694, 246);
            dgPosete.Name = "dgPosete";
            dgPosete.ReadOnly = true;
            dgPosete.RowTemplate.Height = 25;
            dgPosete.Size = new Size(300, 118);
            dgPosete.TabIndex = 37;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(230, 289);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(92, 41);
            btnIzmeni.TabIndex = 38;
            btnIzmeni.Text = "Sacuvaj";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(231, 246);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 39;
            label11.Text = "Slika:";
            // 
            // btnSlika
            // 
            btnSlika.Location = new Point(297, 242);
            btnSlika.Name = "btnSlika";
            btnSlika.Size = new Size(75, 23);
            btnSlika.TabIndex = 40;
            btnSlika.Text = "Dodaj sliku";
            btnSlika.UseVisualStyleBackColor = true;
            btnSlika.Click += btnSlika_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(328, 289);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(92, 41);
            btnObrisi.TabIndex = 41;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnQR
            // 
            btnQR.Location = new Point(426, 289);
            btnQR.Name = "btnQR";
            btnQR.Size = new Size(92, 41);
            btnQR.TabIndex = 42;
            btnQR.Text = "QR Kod";
            btnQR.UseVisualStyleBackColor = true;
            btnQR.Click += btnQR_Click;
            // 
            // pbQR
            // 
            pbQR.Location = new Point(445, 217);
            pbQR.Name = "pbQR";
            pbQR.Size = new Size(62, 50);
            pbQR.TabIndex = 43;
            pbQR.TabStop = false;
            pbQR.Visible = false;
            // 
            // ProfilClana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(pbQR);
            Controls.Add(btnQR);
            Controls.Add(btnObrisi);
            Controls.Add(btnSlika);
            Controls.Add(label11);
            Controls.Add(btnIzmeni);
            Controls.Add(dgPosete);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dgUplate);
            Controls.Add(rbZ);
            Controls.Add(rbM);
            Controls.Add(label8);
            Controls.Add(lbConnection);
            Controls.Add(label7);
            Controls.Add(tbIDclana);
            Controls.Add(pbSlika);
            Controls.Add(tbBrIndex);
            Controls.Add(tbAdresa);
            Controls.Add(tbEmail);
            Controls.Add(tbBrTel);
            Controls.Add(tbPrezime);
            Controls.Add(tbIme);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProfilClana";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfilClana";
            FormClosing += ProfilClana_FormClosing;
            Load += ProfilClana_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgUplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPosete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private TextBox tbBrIndex;
        private TextBox tbAdresa;
        private TextBox tbEmail;
        private TextBox tbBrTel;
        private TextBox tbPrezime;
        private TextBox tbIme;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbIDclana;
        private Label label7;
        private Label lbConnection;
        private RadioButton rbZ;
        private RadioButton rbM;
        private Label label8;
        private DataGridView dgUplate;
        private Label label9;
        private Label label10;
        private DataGridView dgPosete;
        private Button btnIzmeni;
        private Label label11;
        private Button btnSlika;
        private Button btnObrisi;
        private Button btnQR;
        private PictureBox pbQR;
    }
}