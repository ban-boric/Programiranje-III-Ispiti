namespace DLWMS.WinForms.IB123456
{
    partial class frmStudentInfoIB123456
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
            pbSlika = new PictureBox();
            lblImePrezime = new Label();
            lblProsjek = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(271, 30);
            label1.TabIndex = 0;
            label1.Text = "frmStudentInfoIB123456";
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 51);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(271, 303);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 1;
            pbSlika.TabStop = false;
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblImePrezime.Location = new Point(73, 372);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(134, 30);
            lblImePrezime.TabIndex = 2;
            lblImePrezime.Text = "ime prezime";
            // 
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblProsjek.Location = new Point(90, 421);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(83, 30);
            lblProsjek.TabIndex = 3;
            lblProsjek.Text = "Prosjek";
            // 
            // frmStudentInfoIB123456
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 481);
            Controls.Add(lblProsjek);
            Controls.Add(lblImePrezime);
            Controls.Add(pbSlika);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(312, 521);
            MinimumSize = new Size(312, 521);
            Name = "frmStudentInfoIB123456";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BROJ INDEXA";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbSlika;
        private Label lblImePrezime;
        private Label lblProsjek;
    }
}