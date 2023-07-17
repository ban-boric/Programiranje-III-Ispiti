namespace DLWMS.WinForms.IB123456
{
    partial class frmNovaPorukaIB123456
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
            label1 = new Label();
            cmbPredmet = new ComboBox();
            label2 = new Label();
            dtpValidnost = new DateTimePicker();
            rtbSadrzaj = new RichTextBox();
            label3 = new Label();
            pbSlika = new PictureBox();
            lbl4 = new Label();
            btnOdustani = new Button();
            btnSacuvaj = new Button();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 0;
            label1.Text = "Odaberite predmet:";
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(12, 33);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(269, 29);
            cmbPredmet.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(153, 21);
            label2.TabIndex = 2;
            label2.Text = "Poruka je validna do:";
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(12, 89);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(269, 29);
            dtpValidnost.TabIndex = 3;
            // 
            // rtbSadrzaj
            // 
            rtbSadrzaj.Location = new Point(12, 145);
            rtbSadrzaj.Name = "rtbSadrzaj";
            rtbSadrzaj.Size = new Size(269, 239);
            rtbSadrzaj.TabIndex = 4;
            rtbSadrzaj.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 5;
            label3.Text = "Sadrzaj poruke:";
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(312, 36);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(364, 348);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 6;
            pbSlika.TabStop = false;
            pbSlika.MouseDoubleClick += pbSlika_MouseDoubleClick;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(312, 9);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(46, 21);
            lbl4.TabIndex = 7;
            lbl4.Text = "Slika:";
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(464, 404);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(100, 34);
            btnOdustani.TabIndex = 8;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(582, 404);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 34);
            btnSacuvaj.TabIndex = 9;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovaPorukaIB123456
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 450);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnOdustani);
            Controls.Add(lbl4);
            Controls.Add(pbSlika);
            Controls.Add(label3);
            Controls.Add(rtbSadrzaj);
            Controls.Add(dtpValidnost);
            Controls.Add(label2);
            Controls.Add(cmbPredmet);
            Controls.Add(label1);
            MaximumSize = new Size(710, 490);
            MinimumSize = new Size(710, 490);
            Name = "frmNovaPorukaIB123456";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Poruka";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbPredmet;
        private Label label2;
        private DateTimePicker dtpValidnost;
        private RichTextBox rtbSadrzaj;
        private Label label3;
        private PictureBox pbSlika;
        private Label lbl4;
        private Button btnOdustani;
        private Button btnSacuvaj;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}