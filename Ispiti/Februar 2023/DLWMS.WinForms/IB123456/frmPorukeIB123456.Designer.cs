namespace DLWMS.WinForms.IB123456
{
    partial class frmPorukeIB123456
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
            dgvPoruke = new DataGridView();
            predmetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sadrzajDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            slikaDataGridViewImageColumn = new DataGridViewImageColumn();
            Validnost = new DataGridViewTextBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            studentiPorukeIB123456BindingSource = new BindingSource(components);
            lblStudent = new Label();
            btnPoruka = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            rtbInfo = new RichTextBox();
            dtpValidnost = new DateTimePicker();
            label4 = new Label();
            cmbPredmet = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtBrojPoruka = new TextBox();
            btnDodaj = new Button();
            btnPrintaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentiPorukeIB123456BindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPoruke
            // 
            dgvPoruke.AllowUserToAddRows = false;
            dgvPoruke.AllowUserToDeleteRows = false;
            dgvPoruke.AutoGenerateColumns = false;
            dgvPoruke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoruke.Columns.AddRange(new DataGridViewColumn[] { predmetDataGridViewTextBoxColumn, sadrzajDataGridViewTextBoxColumn, slikaDataGridViewImageColumn, Validnost, Brisi });
            dgvPoruke.DataSource = studentiPorukeIB123456BindingSource;
            dgvPoruke.Location = new Point(6, 42);
            dgvPoruke.Name = "dgvPoruke";
            dgvPoruke.ReadOnly = true;
            dgvPoruke.RowTemplate.Height = 31;
            dgvPoruke.Size = new Size(871, 236);
            dgvPoruke.TabIndex = 0;
            dgvPoruke.CellContentClick += dgvPoruke_CellContentClick;
            // 
            // predmetDataGridViewTextBoxColumn
            // 
            predmetDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            predmetDataGridViewTextBoxColumn.DataPropertyName = "Predmet";
            predmetDataGridViewTextBoxColumn.HeaderText = "Predmet";
            predmetDataGridViewTextBoxColumn.Name = "predmetDataGridViewTextBoxColumn";
            predmetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sadrzajDataGridViewTextBoxColumn
            // 
            sadrzajDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sadrzajDataGridViewTextBoxColumn.DataPropertyName = "Sadrzaj";
            sadrzajDataGridViewTextBoxColumn.HeaderText = "Sadrzaj";
            sadrzajDataGridViewTextBoxColumn.Name = "sadrzajDataGridViewTextBoxColumn";
            sadrzajDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slikaDataGridViewImageColumn
            // 
            slikaDataGridViewImageColumn.DataPropertyName = "Slika";
            slikaDataGridViewImageColumn.HeaderText = "Slika";
            slikaDataGridViewImageColumn.Name = "slikaDataGridViewImageColumn";
            slikaDataGridViewImageColumn.ReadOnly = true;
            // 
            // Validnost
            // 
            Validnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Validnost.DataPropertyName = "Validnost";
            Validnost.HeaderText = "Validnost";
            Validnost.Name = "Validnost";
            Validnost.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.DataPropertyName = "Id";
            Brisi.HeaderText = "";
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Obrisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // studentiPorukeIB123456BindingSource
            // 
            studentiPorukeIB123456BindingSource.DataSource = typeof(Data.StudentiPorukeIB123456);
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(12, 9);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(234, 21);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Poruke studenta _______________:";
            // 
            // btnPoruka
            // 
            btnPoruka.Location = new Point(758, 4);
            btnPoruka.Name = "btnPoruka";
            btnPoruka.Size = new Size(125, 32);
            btnPoruka.TabIndex = 2;
            btnPoruka.Text = "Nova poruka";
            btnPoruka.UseVisualStyleBackColor = true;
            btnPoruka.Click += btnPoruka_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(rtbInfo);
            groupBox1.Controls.Add(dtpValidnost);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbPredmet);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBrojPoruka);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Location = new Point(12, 349);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(871, 271);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje poruka:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 35);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 12;
            label5.Text = "Info:";
            // 
            // rtbInfo
            // 
            rtbInfo.Location = new Point(306, 59);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.Size = new Size(559, 190);
            rtbInfo.TabIndex = 11;
            rtbInfo.Text = "";
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(6, 171);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(258, 29);
            dtpValidnost.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 147);
            label4.Name = "label4";
            label4.Size = new Size(153, 21);
            label4.TabIndex = 9;
            label4.Text = "Poruka je validna do:";
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(6, 115);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(258, 29);
            cmbPredmet.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 7;
            label3.Text = "Predmet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 5;
            label2.Text = "Broj poruka:";
            // 
            // txtBrojPoruka
            // 
            txtBrojPoruka.Location = new Point(6, 59);
            txtBrojPoruka.Name = "txtBrojPoruka";
            txtBrojPoruka.Size = new Size(258, 29);
            txtBrojPoruka.TabIndex = 6;
            // 
            // btnDodaj
            // 
            btnDodaj.Enabled = false;
            btnDodaj.Location = new Point(6, 217);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(258, 32);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(788, 295);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(95, 32);
            btnPrintaj.TabIndex = 4;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // frmPorukeIB123456
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 632);
            Controls.Add(btnPrintaj);
            Controls.Add(groupBox1);
            Controls.Add(btnPoruka);
            Controls.Add(lblStudent);
            Controls.Add(dgvPoruke);
            MaximumSize = new Size(909, 672);
            MinimumSize = new Size(909, 672);
            Name = "frmPorukeIB123456";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Broj poruka [ ]";
            Load += frmPorukeIB123456_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentiPorukeIB123456BindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPoruke;
        private Label lblStudent;
        private Button btnPoruka;
        private GroupBox groupBox1;
        private Button btnDodaj;
        private Button btnPrintaj;
        private DateTimePicker dtpValidnost;
        private Label label4;
        private ComboBox cmbPredmet;
        private Label label3;
        private Label label2;
        private TextBox txtBrojPoruka;
        private Label label5;
        private RichTextBox rtbInfo;
        private BindingSource studentiPorukeIB123456BindingSource;
        private DataGridViewTextBoxColumn predmetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sadrzajDataGridViewTextBoxColumn;
        private DataGridViewImageColumn slikaDataGridViewImageColumn;
        private DataGridViewTextBoxColumn Validnost;
        private DataGridViewButtonColumn Brisi;
    }
}