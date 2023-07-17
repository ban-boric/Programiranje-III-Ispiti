namespace DLWMS.WinForms.IB123456
{
    partial class frmUvjerenjaIB123456
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
            btnNoviZahtjev = new Button();
            dgvUvjerenja = new DataGridView();
            vrijemeKreiranjaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vrstaUvjerenjaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            svrhaUvjerenjaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uplatnicaDataGridViewImageColumn = new DataGridViewImageColumn();
            printanoDataGridViewTextBoxColumn = new DataGridViewCheckBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            Printaj = new DataGridViewButtonColumn();
            studentiUvjerenjaIB123456BindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            rtbInfo = new RichTextBox();
            label4 = new Label();
            btnDodaj = new Button();
            txtBrojZahtjeva = new TextBox();
            txtSvrha = new TextBox();
            cmbVrsta = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentiUvjerenjaIB123456BindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNoviZahtjev
            // 
            btnNoviZahtjev.Location = new Point(658, 12);
            btnNoviZahtjev.Name = "btnNoviZahtjev";
            btnNoviZahtjev.Size = new Size(121, 30);
            btnNoviZahtjev.TabIndex = 0;
            btnNoviZahtjev.Text = "Novi zahtjev";
            btnNoviZahtjev.UseVisualStyleBackColor = true;
            btnNoviZahtjev.Click += btnNoviZahtjev_Click;
            // 
            // dgvUvjerenja
            // 
            dgvUvjerenja.AllowUserToAddRows = false;
            dgvUvjerenja.AllowUserToDeleteRows = false;
            dgvUvjerenja.AutoGenerateColumns = false;
            dgvUvjerenja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUvjerenja.Columns.AddRange(new DataGridViewColumn[] { vrijemeKreiranjaDataGridViewTextBoxColumn, vrstaUvjerenjaDataGridViewTextBoxColumn, svrhaUvjerenjaDataGridViewTextBoxColumn, uplatnicaDataGridViewImageColumn, printanoDataGridViewTextBoxColumn, Brisi, Printaj });
            dgvUvjerenja.DataSource = studentiUvjerenjaIB123456BindingSource;
            dgvUvjerenja.Location = new Point(12, 48);
            dgvUvjerenja.Name = "dgvUvjerenja";
            dgvUvjerenja.ReadOnly = true;
            dgvUvjerenja.RowTemplate.Height = 31;
            dgvUvjerenja.Size = new Size(767, 150);
            dgvUvjerenja.TabIndex = 1;
            dgvUvjerenja.CellContentClick += dgvUvjerenja_CellContentClick;
            // 
            // vrijemeKreiranjaDataGridViewTextBoxColumn
            // 
            vrijemeKreiranjaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vrijemeKreiranjaDataGridViewTextBoxColumn.DataPropertyName = "VrijemeKreiranja";
            vrijemeKreiranjaDataGridViewTextBoxColumn.HeaderText = "Datum";
            vrijemeKreiranjaDataGridViewTextBoxColumn.Name = "vrijemeKreiranjaDataGridViewTextBoxColumn";
            vrijemeKreiranjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstaUvjerenjaDataGridViewTextBoxColumn
            // 
            vrstaUvjerenjaDataGridViewTextBoxColumn.DataPropertyName = "VrstaUvjerenja";
            vrstaUvjerenjaDataGridViewTextBoxColumn.HeaderText = "Vrsta";
            vrstaUvjerenjaDataGridViewTextBoxColumn.Name = "vrstaUvjerenjaDataGridViewTextBoxColumn";
            vrstaUvjerenjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // svrhaUvjerenjaDataGridViewTextBoxColumn
            // 
            svrhaUvjerenjaDataGridViewTextBoxColumn.DataPropertyName = "SvrhaUvjerenja";
            svrhaUvjerenjaDataGridViewTextBoxColumn.HeaderText = "Svrha";
            svrhaUvjerenjaDataGridViewTextBoxColumn.Name = "svrhaUvjerenjaDataGridViewTextBoxColumn";
            svrhaUvjerenjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uplatnicaDataGridViewImageColumn
            // 
            uplatnicaDataGridViewImageColumn.DataPropertyName = "Uplatnica";
            uplatnicaDataGridViewImageColumn.HeaderText = "Uplatnica";
            uplatnicaDataGridViewImageColumn.Name = "uplatnicaDataGridViewImageColumn";
            uplatnicaDataGridViewImageColumn.ReadOnly = true;
            // 
            // printanoDataGridViewTextBoxColumn
            // 
            printanoDataGridViewTextBoxColumn.DataPropertyName = "Printano";
            printanoDataGridViewTextBoxColumn.HeaderText = "Printano";
            printanoDataGridViewTextBoxColumn.Name = "printanoDataGridViewTextBoxColumn";
            printanoDataGridViewTextBoxColumn.ReadOnly = true;
            printanoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            printanoDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Brisi
            // 
            Brisi.DataPropertyName = "Id";
            Brisi.HeaderText = "";
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // Printaj
            // 
            Printaj.DataPropertyName = "Id";
            Printaj.HeaderText = "";
            Printaj.Name = "Printaj";
            Printaj.ReadOnly = true;
            Printaj.Text = "Printaj";
            Printaj.UseColumnTextForButtonValue = true;
            // 
            // studentiUvjerenjaIB123456BindingSource
            // 
            studentiUvjerenjaIB123456BindingSource.DataSource = typeof(Data.StudentiUvjerenjaIB123456);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtbInfo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(txtBrojZahtjeva);
            groupBox1.Controls.Add(txtSvrha);
            groupBox1.Controls.Add(cmbVrsta);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 204);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(767, 291);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje zahtjeva za izdavanje uvjerenja";
            // 
            // rtbInfo
            // 
            rtbInfo.Location = new Point(6, 114);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.Size = new Size(755, 171);
            rtbInfo.TabIndex = 8;
            rtbInfo.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 90);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 7;
            label4.Text = "Info:";
            // 
            // btnDodaj
            // 
            btnDodaj.Enabled = false;
            btnDodaj.Location = new Point(663, 58);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(98, 29);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // txtBrojZahtjeva
            // 
            txtBrojZahtjeva.Location = new Point(558, 58);
            txtBrojZahtjeva.Name = "txtBrojZahtjeva";
            txtBrojZahtjeva.Size = new Size(99, 29);
            txtBrojZahtjeva.TabIndex = 5;
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(261, 58);
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(291, 29);
            txtSvrha.TabIndex = 4;
            // 
            // cmbVrsta
            // 
            cmbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Items.AddRange(new object[] { "Uvjerenje o statusu studenta", "Uvjerenje o statusnih pitanja" });
            cmbVrsta.Location = new Point(6, 58);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(249, 29);
            cmbVrsta.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(558, 34);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 2;
            label3.Text = "Broj zahtjeva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 34);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 1;
            label2.Text = "Svrha uvjerenja";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja";
            // 
            // frmUvjerenjaIB123456
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(groupBox1);
            Controls.Add(dgvUvjerenja);
            Controls.Add(btnNoviZahtjev);
            MaximumSize = new Size(816, 542);
            MinimumSize = new Size(816, 542);
            Name = "frmUvjerenjaIB123456";
            Text = "Broj uvjerenja -> ?";
            Load += frmUvjerenjaIB123456_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentiUvjerenjaIB123456BindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNoviZahtjev;
        private DataGridView dgvUvjerenja;
        private GroupBox groupBox1;
        private ComboBox cmbVrsta;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox rtbInfo;
        private Label label4;
        private Button btnDodaj;
        private TextBox txtBrojZahtjeva;
        private TextBox txtSvrha;
        private BindingSource studentiUvjerenjaIB123456BindingSource;
        private DataGridViewTextBoxColumn vrijemeKreiranjaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vrstaUvjerenjaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn svrhaUvjerenjaDataGridViewTextBoxColumn;
        private DataGridViewImageColumn uplatnicaDataGridViewImageColumn;
        private DataGridViewCheckBoxColumn printanoDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
    }
}