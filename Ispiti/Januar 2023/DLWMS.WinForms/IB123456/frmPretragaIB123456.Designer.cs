namespace DLWMS.WinForms.IB123456
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
            dtpOd = new DateTimePicker();
            cmbSpol = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dtpDo = new DateTimePicker();
            dgvPodaci = new DataGridView();
            brojIndeksaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            datumRodjenjaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktivanDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            Uvjerenja = new DataGridViewButtonColumn();
            studentBindingSource1 = new BindingSource(components);
            studentBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(41, 21);
            label1.TabIndex = 0;
            label1.Text = "Spol";
            // 
            // dtpOd
            // 
            dtpOd.Location = new Point(340, 9);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(259, 29);
            dtpOd.TabIndex = 1;
            dtpOd.Value = new DateTime(2020, 7, 3, 22, 3, 0, 0);
            dtpOd.ValueChanged += dtpOd_ValueChanged;
            // 
            // cmbSpol
            // 
            cmbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Location = new Point(59, 9);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(121, 29);
            cmbSpol.TabIndex = 2;
            cmbSpol.SelectedIndexChanged += cmbSpol_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 12);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 3;
            label2.Text = "rodjen u periodu od";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(605, 15);
            label3.Name = "label3";
            label3.Size = new Size(28, 21);
            label3.TabIndex = 4;
            label3.Text = "do";
            // 
            // dtpDo
            // 
            dtpDo.Location = new Point(639, 9);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(259, 29);
            dtpDo.TabIndex = 5;
            dtpDo.ValueChanged += dtpDo_ValueChanged;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.AutoGenerateColumns = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { brojIndeksaDataGridViewTextBoxColumn, ImePrezime, Prosjek, datumRodjenjaDataGridViewTextBoxColumn, aktivanDataGridViewCheckBoxColumn, Uvjerenja });
            dgvPodaci.DataSource = studentBindingSource1;
            dgvPodaci.Location = new Point(12, 44);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowTemplate.Height = 31;
            dgvPodaci.Size = new Size(886, 254);
            dgvPodaci.TabIndex = 6;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // brojIndeksaDataGridViewTextBoxColumn
            // 
            brojIndeksaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            brojIndeksaDataGridViewTextBoxColumn.DataPropertyName = "BrojIndeksa";
            brojIndeksaDataGridViewTextBoxColumn.HeaderText = "BrojIndeksa";
            brojIndeksaDataGridViewTextBoxColumn.Name = "brojIndeksaDataGridViewTextBoxColumn";
            brojIndeksaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "ImePrezime";
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // datumRodjenjaDataGridViewTextBoxColumn
            // 
            datumRodjenjaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            datumRodjenjaDataGridViewTextBoxColumn.DataPropertyName = "DatumRodjenja";
            datumRodjenjaDataGridViewTextBoxColumn.HeaderText = "DatumRodjenja";
            datumRodjenjaDataGridViewTextBoxColumn.Name = "datumRodjenjaDataGridViewTextBoxColumn";
            datumRodjenjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktivanDataGridViewCheckBoxColumn
            // 
            aktivanDataGridViewCheckBoxColumn.DataPropertyName = "Aktivan";
            aktivanDataGridViewCheckBoxColumn.HeaderText = "Aktivan";
            aktivanDataGridViewCheckBoxColumn.Name = "aktivanDataGridViewCheckBoxColumn";
            aktivanDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Uvjerenja
            // 
            Uvjerenja.HeaderText = "";
            Uvjerenja.Name = "Uvjerenja";
            Uvjerenja.ReadOnly = true;
            Uvjerenja.Text = "Uvjerenja";
            Uvjerenja.UseColumnTextForButtonValue = true;
            // 
            // studentBindingSource1
            // 
            studentBindingSource1.DataSource = typeof(Data.Student);
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Data.Student);
            // 
            // frmPretragaIB123456
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 313);
            Controls.Add(dgvPodaci);
            Controls.Add(dtpDo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbSpol);
            Controls.Add(dtpOd);
            Controls.Add(label1);
            MaximumSize = new Size(928, 353);
            MinimumSize = new Size(928, 353);
            Name = "frmPretragaIB123456";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga studenata";
            Load += frmPretragaIB123456_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label1;
        private DateTimePicker dtpOd;
        private ComboBox cmbSpol;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDo;
        private DataGridView dgvPodaci;
        private BindingSource studentBindingSource;
        private BindingSource studentBindingSource1;
        private DataGridViewTextBoxColumn brojIndeksaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn datumRodjenjaDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktivanDataGridViewCheckBoxColumn;
        private DataGridViewButtonColumn Uvjerenja;
    }
}