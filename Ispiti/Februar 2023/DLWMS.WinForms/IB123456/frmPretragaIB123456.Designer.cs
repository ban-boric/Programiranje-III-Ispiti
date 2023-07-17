namespace DLWMS.WinForms.IB200155
{
    partial class frmPretragaIB123456
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
            cmbOd = new ComboBox();
            label2 = new Label();
            cmbDo = new ComboBox();
            label3 = new Label();
            dtpOd = new DateTimePicker();
            dtpDo = new DateTimePicker();
            label4 = new Label();
            dgvTabela = new DataGridView();
            Indeks = new DataGridViewTextBoxColumn();
            studentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            predmetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ocjenaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Poruke = new DataGridViewButtonColumn();
            studentiPredmetiBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvTabela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentiPredmetiBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 0;
            label1.Text = "Ocjena od";
            // 
            // cmbOd
            // 
            cmbOd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOd.Enabled = false;
            cmbOd.FormattingEnabled = true;
            cmbOd.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOd.Location = new Point(98, 39);
            cmbOd.Name = "cmbOd";
            cmbOd.Size = new Size(66, 29);
            cmbOd.TabIndex = 1;
            cmbOd.SelectedIndexChanged += cmbOd_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 42);
            label2.Name = "label2";
            label2.Size = new Size(28, 21);
            label2.TabIndex = 2;
            label2.Text = "do";
            // 
            // cmbDo
            // 
            cmbDo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDo.Enabled = false;
            cmbDo.FormattingEnabled = true;
            cmbDo.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbDo.Location = new Point(200, 37);
            cmbDo.Name = "cmbDo";
            cmbDo.Size = new Size(66, 29);
            cmbDo.TabIndex = 3;
            cmbDo.SelectedIndexChanged += cmbDo_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 40);
            label3.Name = "label3";
            label3.Size = new Size(166, 21);
            label3.TabIndex = 4;
            label3.Text = "polozena u periodu od";
            // 
            // dtpOd
            // 
            dtpOd.Enabled = false;
            dtpOd.Location = new Point(444, 37);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(265, 29);
            dtpOd.TabIndex = 5;
            dtpOd.Value = new DateTime(2022, 12, 21, 0, 0, 0, 0);
            dtpOd.ValueChanged += dtpOd_ValueChanged;
            // 
            // dtpDo
            // 
            dtpDo.Enabled = false;
            dtpDo.Location = new Point(749, 37);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(265, 29);
            dtpDo.TabIndex = 6;
            dtpDo.ValueChanged += dtpDo_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(715, 42);
            label4.Name = "label4";
            label4.Size = new Size(28, 21);
            label4.TabIndex = 7;
            label4.Text = "do";
            // 
            // dgvTabela
            // 
            dgvTabela.AllowUserToAddRows = false;
            dgvTabela.AllowUserToDeleteRows = false;
            dgvTabela.AutoGenerateColumns = false;
            dgvTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabela.Columns.AddRange(new DataGridViewColumn[] { Indeks, studentDataGridViewTextBoxColumn, predmetDataGridViewTextBoxColumn, ocjenaDataGridViewTextBoxColumn, datumDataGridViewTextBoxColumn, Poruke });
            dgvTabela.DataSource = studentiPredmetiBindingSource;
            dgvTabela.Location = new Point(12, 74);
            dgvTabela.Name = "dgvTabela";
            dgvTabela.ReadOnly = true;
            dgvTabela.RowTemplate.Height = 31;
            dgvTabela.Size = new Size(1002, 260);
            dgvTabela.TabIndex = 8;
            dgvTabela.CellContentClick += dgvTabela_CellContentClick;
            // 
            // Indeks
            // 
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Indeks";
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            // 
            // studentDataGridViewTextBoxColumn
            // 
            studentDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            studentDataGridViewTextBoxColumn.HeaderText = "Ime i prezime";
            studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            studentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // predmetDataGridViewTextBoxColumn
            // 
            predmetDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            predmetDataGridViewTextBoxColumn.DataPropertyName = "Predmet";
            predmetDataGridViewTextBoxColumn.HeaderText = "Predmet";
            predmetDataGridViewTextBoxColumn.Name = "predmetDataGridViewTextBoxColumn";
            predmetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ocjenaDataGridViewTextBoxColumn
            // 
            ocjenaDataGridViewTextBoxColumn.DataPropertyName = "Ocjena";
            ocjenaDataGridViewTextBoxColumn.HeaderText = "Ocjena";
            ocjenaDataGridViewTextBoxColumn.Name = "ocjenaDataGridViewTextBoxColumn";
            ocjenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            datumDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            datumDataGridViewTextBoxColumn.HeaderText = "Datum polaganja";
            datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Poruke
            // 
            Poruke.HeaderText = "";
            Poruke.Name = "Poruke";
            Poruke.ReadOnly = true;
            Poruke.Text = "Poruke";
            Poruke.UseColumnTextForButtonValue = true;
            // 
            // studentiPredmetiBindingSource
            // 
            studentiPredmetiBindingSource.DataSource = typeof(Data.StudentiPredmeti);
            // 
            // frmPretragaIB123456
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 349);
            Controls.Add(dgvTabela);
            Controls.Add(label4);
            Controls.Add(dtpDo);
            Controls.Add(dtpOd);
            Controls.Add(label3);
            Controls.Add(cmbDo);
            Controls.Add(label2);
            Controls.Add(cmbOd);
            Controls.Add(label1);
            MaximumSize = new Size(1047, 389);
            MinimumSize = new Size(1047, 389);
            Name = "frmPretragaIB123456";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga studenata";
            Load += frmPretragaIB200155_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTabela).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentiPredmetiBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbOd;
        private Label label2;
        private ComboBox cmbDo;
        private Label label3;
        private DateTimePicker dtpOd;
        private DateTimePicker dtpDo;
        private Label label4;
        private DataGridView dgvTabela;
        private BindingSource studentiPredmetiBindingSource;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn predmetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ocjenaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Poruke;
    }
}