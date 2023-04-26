namespace Teretana
{
    partial class Form1
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
            btnDodaj = new Button();
            btnClanarina = new Button();
            btnListaClanova = new Button();
            btnPosete = new Button();
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 261);
            Controls.Add(btnPosete);
            Controls.Add(btnListaClanova);
            Controls.Add(btnClanarina);
            Controls.Add(btnDodaj);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDodaj;
        private Button btnClanarina;
        private Button btnListaClanova;
        private Button btnPosete;
    }
}