namespace Teretana
{
    partial class Teretana
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
            components = new System.ComponentModel.Container();
            btnDodaj = new Button();
            btnClanarina = new Button();
            btnListaClanova = new Button();
            btnPosete = new Button();
            cbDevices = new ComboBox();
            btnStartCamera = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pbCamera = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbCamera).BeginInit();
            SuspendLayout();
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(12, 12);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.RightToLeft = RightToLeft.No;
            btnDodaj.Size = new Size(130, 40);
            btnDodaj.TabIndex = 0;
            btnDodaj.Text = "Dodaj clana";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnClanarina
            // 
            btnClanarina.Location = new Point(148, 12);
            btnClanarina.Name = "btnClanarina";
            btnClanarina.RightToLeft = RightToLeft.No;
            btnClanarina.Size = new Size(130, 40);
            btnClanarina.TabIndex = 1;
            btnClanarina.Text = "Clanarina";
            btnClanarina.UseVisualStyleBackColor = true;
            btnClanarina.Click += btnClanarina_Click;
            // 
            // btnListaClanova
            // 
            btnListaClanova.Location = new Point(284, 12);
            btnListaClanova.Name = "btnListaClanova";
            btnListaClanova.RightToLeft = RightToLeft.No;
            btnListaClanova.Size = new Size(130, 40);
            btnListaClanova.TabIndex = 2;
            btnListaClanova.Text = "Lista Clanova";
            btnListaClanova.UseVisualStyleBackColor = true;
            btnListaClanova.Click += btnListaClanova_Click;
            // 
            // btnPosete
            // 
            btnPosete.Location = new Point(420, 12);
            btnPosete.Name = "btnPosete";
            btnPosete.RightToLeft = RightToLeft.No;
            btnPosete.Size = new Size(130, 40);
            btnPosete.TabIndex = 3;
            btnPosete.Text = "Posete";
            btnPosete.UseVisualStyleBackColor = true;
            btnPosete.Click += btnPosete_Click;
            // 
            // cbDevices
            // 
            cbDevices.FormattingEnabled = true;
            cbDevices.Location = new Point(12, 298);
            cbDevices.Name = "cbDevices";
            cbDevices.Size = new Size(130, 23);
            cbDevices.TabIndex = 4;
            // 
            // btnStartCamera
            // 
            btnStartCamera.Location = new Point(148, 298);
            btnStartCamera.Name = "btnStartCamera";
            btnStartCamera.Size = new Size(88, 23);
            btnStartCamera.TabIndex = 5;
            btnStartCamera.Text = "Start kamera";
            btnStartCamera.UseVisualStyleBackColor = true;
            btnStartCamera.Click += btnStartCamera_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pbCamera
            // 
            pbCamera.Image = Properties.Resources.image_processing20210620_28232_baqx1v;
            pbCamera.Location = new Point(12, 70);
            pbCamera.Name = "pbCamera";
            pbCamera.Size = new Size(291, 222);
            pbCamera.SizeMode = PictureBoxSizeMode.Zoom;
            pbCamera.TabIndex = 6;
            pbCamera.TabStop = false;
            // 
            // Teretana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 333);
            Controls.Add(pbCamera);
            Controls.Add(btnStartCamera);
            Controls.Add(cbDevices);
            Controls.Add(btnPosete);
            Controls.Add(btnListaClanova);
            Controls.Add(btnClanarina);
            Controls.Add(btnDodaj);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Teretana";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbCamera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDodaj;
        private Button btnClanarina;
        private Button btnListaClanova;
        private Button btnPosete;
        private ComboBox cbDevices;
        private Button btnStartCamera;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pbCamera;
    }
}