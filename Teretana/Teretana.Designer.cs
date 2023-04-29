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
            timer1 = new System.Windows.Forms.Timer(components);
            pbCamera = new PictureBox();
            label1 = new Label();
            tbBrojPoseta = new TextBox();
            btnPostavke = new Button();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 92);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 7;
            label1.Text = "Broj poseta danas:";
            // 
            // tbBrojPoseta
            // 
            tbBrojPoseta.Location = new Point(420, 89);
            tbBrojPoseta.Name = "tbBrojPoseta";
            tbBrojPoseta.ReadOnly = true;
            tbBrojPoseta.Size = new Size(100, 23);
            tbBrojPoseta.TabIndex = 8;
            tbBrojPoseta.Text = "0";
            // 
            // btnPostavke
            // 
            btnPostavke.Location = new Point(485, 297);
            btnPostavke.Name = "btnPostavke";
            btnPostavke.Size = new Size(65, 23);
            btnPostavke.TabIndex = 9;
            btnPostavke.Text = "Postavke";
            btnPostavke.UseVisualStyleBackColor = true;
            btnPostavke.Click += btnPostavke_Click;
            // 
            // Teretana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 333);
            Controls.Add(btnPostavke);
            Controls.Add(tbBrojPoseta);
            Controls.Add(label1);
            Controls.Add(pbCamera);
            Controls.Add(btnPosete);
            Controls.Add(btnListaClanova);
            Controls.Add(btnClanarina);
            Controls.Add(btnDodaj);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Teretana";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teretana";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbCamera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDodaj;
        private Button btnClanarina;
        private Button btnListaClanova;
        private Button btnPosete;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pbCamera;
        private Label label1;
        private TextBox tbBrojPoseta;
        private Button btnPostavke;
    }
}