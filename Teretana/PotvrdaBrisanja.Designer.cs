namespace Teretana
{
    partial class PotvrdaBrisanja
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
            btnDa = new Button();
            btnNe = new Button();
            SuspendLayout();
            // 
            // btnDa
            // 
            btnDa.Location = new Point(12, 25);
            btnDa.Name = "btnDa";
            btnDa.Size = new Size(102, 42);
            btnDa.TabIndex = 0;
            btnDa.Text = "Da";
            btnDa.UseVisualStyleBackColor = true;
            btnDa.Click += btnDa_Click;
            // 
            // btnNe
            // 
            btnNe.Location = new Point(143, 25);
            btnNe.Name = "btnNe";
            btnNe.Size = new Size(102, 42);
            btnNe.TabIndex = 1;
            btnNe.Text = "Ne";
            btnNe.UseVisualStyleBackColor = true;
            btnNe.Click += btnNe_Click;
            // 
            // PotvrdaBrisanja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 93);
            Controls.Add(btnNe);
            Controls.Add(btnDa);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "PotvrdaBrisanja";
            Text = "PotvrdaBrisanja";
            Load += PotvrdaBrisanja_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDa;
        private Button btnNe;
    }
}