namespace Teretana
{
    partial class Clanarina
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clanarina));
            lbConnection = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbID = new TextBox();
            tbPrezime = new TextBox();
            tbIme = new TextBox();
            pbCamera = new PictureBox();
            cbDevices = new ComboBox();
            btnStartCamera = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            tbIznos = new TextBox();
            label5 = new Label();
            btnUplati = new Button();
            label6 = new Label();
            tbBrojMeseci = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbCamera).BeginInit();
            SuspendLayout();
            // 
            // lbConnection
            // 
            lbConnection.AutoSize = true;
            lbConnection.Location = new Point(477, 282);
            lbConnection.Name = "lbConnection";
            lbConnection.Size = new Size(106, 15);
            lbConnection.TabIndex = 0;
            lbConnection.Text = "Baza nije povezana";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 55);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 2;
            label2.Text = "Ime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 84);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 3;
            label3.Text = "Prezime:";
            // 
            // tbID
            // 
            tbID.Location = new Point(82, 23);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(150, 23);
            tbID.TabIndex = 4;
            tbID.Text = "Ceka se sken";
            // 
            // tbPrezime
            // 
            tbPrezime.Location = new Point(82, 81);
            tbPrezime.Name = "tbPrezime";
            tbPrezime.ReadOnly = true;
            tbPrezime.Size = new Size(150, 23);
            tbPrezime.TabIndex = 5;
            tbPrezime.Text = "Ceka se sken";
            // 
            // tbIme
            // 
            tbIme.Location = new Point(82, 52);
            tbIme.Name = "tbIme";
            tbIme.ReadOnly = true;
            tbIme.Size = new Size(150, 23);
            tbIme.TabIndex = 6;
            tbIme.Text = "Ceka se sken";
            // 
            // pbCamera
            // 
            pbCamera.Image = (Image)resources.GetObject("pbCamera.Image");
            pbCamera.Location = new Point(384, 12);
            pbCamera.Name = "pbCamera";
            pbCamera.Size = new Size(200, 150);
            pbCamera.SizeMode = PictureBoxSizeMode.Zoom;
            pbCamera.TabIndex = 7;
            pbCamera.TabStop = false;
            // 
            // cbDevices
            // 
            cbDevices.FormattingEnabled = true;
            cbDevices.Location = new Point(384, 168);
            cbDevices.Name = "cbDevices";
            cbDevices.Size = new Size(199, 23);
            cbDevices.TabIndex = 8;
            // 
            // btnStartCamera
            // 
            btnStartCamera.Location = new Point(435, 197);
            btnStartCamera.Name = "btnStartCamera";
            btnStartCamera.Size = new Size(100, 23);
            btnStartCamera.TabIndex = 9;
            btnStartCamera.Text = "Start Camera";
            btnStartCamera.UseVisualStyleBackColor = true;
            btnStartCamera.Click += btnStartCamera_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 171);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 10;
            label4.Text = "Datum:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(101, 167);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(204, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // tbIznos
            // 
            tbIznos.Location = new Point(101, 229);
            tbIznos.Name = "tbIznos";
            tbIznos.Size = new Size(150, 23);
            tbIznos.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 232);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 13;
            label5.Text = "Iznos:";
            // 
            // btnUplati
            // 
            btnUplati.Location = new Point(82, 259);
            btnUplati.Name = "btnUplati";
            btnUplati.Size = new Size(150, 23);
            btnUplati.TabIndex = 14;
            btnUplati.Text = "Uplati clanarinu";
            btnUplati.UseVisualStyleBackColor = true;
            btnUplati.Click += btnUplati_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 201);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 15;
            label6.Text = "Broj meseci:";
            // 
            // tbBrojMeseci
            // 
            tbBrojMeseci.Location = new Point(101, 198);
            tbBrojMeseci.Name = "tbBrojMeseci";
            tbBrojMeseci.Size = new Size(150, 23);
            tbBrojMeseci.TabIndex = 16;
            tbBrojMeseci.Text = "1";
            // 
            // Clanarina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 305);
            Controls.Add(tbBrojMeseci);
            Controls.Add(label6);
            Controls.Add(btnUplati);
            Controls.Add(label5);
            Controls.Add(tbIznos);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(btnStartCamera);
            Controls.Add(cbDevices);
            Controls.Add(pbCamera);
            Controls.Add(tbIme);
            Controls.Add(tbPrezime);
            Controls.Add(tbID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbConnection);
            Name = "Clanarina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clanarina";
            FormClosing += Clanarina_FormClosing;
            Load += Clanarina_Load;
            ((System.ComponentModel.ISupportInitialize)pbCamera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbConnection;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbID;
        private TextBox tbPrezime;
        private TextBox tbIme;
        private PictureBox pbCamera;
        private ComboBox cbDevices;
        private Button btnStartCamera;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox tbIznos;
        private Label label5;
        private Button btnUplati;
        private Label label6;
        private TextBox tbBrojMeseci;
    }
}