namespace DLWMS.WinForms.IB123456
{
    partial class frmNovoUvjerenjeIB123456
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
            cmbVrsta = new ComboBox();
            label2 = new Label();
            rtbSvrha = new RichTextBox();
            label3 = new Label();
            pbUplatnica = new PictureBox();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // cmbVrsta
            // 
            cmbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Items.AddRange(new object[] { "Regulisanje statusnih pitanja", "O statusu studenta" });
            cmbVrsta.Location = new Point(12, 33);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(249, 29);
            cmbVrsta.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 2;
            label2.Text = "Svrha uvjerenja:";
            // 
            // rtbSvrha
            // 
            rtbSvrha.Location = new Point(12, 89);
            rtbSvrha.Name = "rtbSvrha";
            rtbSvrha.Size = new Size(249, 265);
            rtbSvrha.TabIndex = 3;
            rtbSvrha.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 9);
            label3.Name = "label3";
            label3.Size = new Size(149, 21);
            label3.TabIndex = 4;
            label3.Text = "Skenirana uplatnica:";
            // 
            // pbUplatnica
            // 
            pbUplatnica.Location = new Point(280, 33);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(443, 284);
            pbUplatnica.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUplatnica.TabIndex = 5;
            pbUplatnica.TabStop = false;
            pbUplatnica.DoubleClick += pbUplatnica_DoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(641, 328);
            button1.Name = "button1";
            button1.Size = new Size(82, 31);
            button1.TabIndex = 6;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovoUvjerenjeIB123456
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 371);
            Controls.Add(button1);
            Controls.Add(pbUplatnica);
            Controls.Add(label3);
            Controls.Add(rtbSvrha);
            Controls.Add(label2);
            Controls.Add(cmbVrsta);
            Controls.Add(label1);
            MaximumSize = new Size(754, 411);
            MinimumSize = new Size(754, 411);
            Name = "frmNovoUvjerenjeIB123456";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novi zahtjev za izdavanjem uvjerenja";
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbVrsta;
        private Label label2;
        private RichTextBox rtbSvrha;
        private Label label3;
        private PictureBox pbUplatnica;
        private Button button1;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}