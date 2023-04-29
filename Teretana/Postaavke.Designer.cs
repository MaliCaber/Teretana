namespace Teretana
{
    partial class Postaavke
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
            cbKamera = new ComboBox();
            label2 = new Label();
            cbAudio = new ComboBox();
            btnSacuvaj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Kamera:";
            // 
            // cbKamera
            // 
            cbKamera.FormattingEnabled = true;
            cbKamera.Location = new Point(68, 26);
            cbKamera.Name = "cbKamera";
            cbKamera.Size = new Size(121, 23);
            cbKamera.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Audio:";
            // 
            // cbAudio
            // 
            cbAudio.FormattingEnabled = true;
            cbAudio.Location = new Point(68, 55);
            cbAudio.Name = "cbAudio";
            cbAudio.Size = new Size(121, 23);
            cbAudio.TabIndex = 3;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(68, 96);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // Postaavke
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(207, 133);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbAudio);
            Controls.Add(label2);
            Controls.Add(cbKamera);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Postaavke";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Postaavke";
            Load += Postaavke_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbKamera;
        private Label label2;
        private ComboBox cbAudio;
        private Button btnSacuvaj;
    }
}