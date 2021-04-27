
namespace betamart
{
    partial class BetaMart
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTanggal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.appData = new betamart.AppData();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangTableAdapter = new betamart.AppDataTableAdapters.BarangTableAdapter();
            this.barangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barangBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appData1 = new betamart.AppData();
            this.barangBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(394, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Barang";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.jumlahBarangDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.barangBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 231);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(457, 150);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTanggal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtJumlah);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 160);
            this.panel1.TabIndex = 3;
            // 
            // txtTanggal
            // 
            this.txtTanggal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Tanggal", true));
            this.txtTanggal.Location = new System.Drawing.Point(129, 72);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Size = new System.Drawing.Size(225, 20);
            this.txtTanggal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tanggal Masuk \r\nBarang";
            // 
            // txtJumlah
            // 
            this.txtJumlah.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "JumlahBarang", true));
            this.txtJumlah.Location = new System.Drawing.Point(129, 46);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(225, 20);
            this.txtJumlah.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jumlah Barang";
            // 
            // txtNama
            // 
            this.txtNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "NamaBarang", true));
            this.txtNama.Location = new System.Drawing.Point(129, 20);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(225, 20);
            this.txtNama.TabIndex = 2;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(85, 191);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(384, 20);
            this.txtCari.TabIndex = 8;
            this.txtCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cari Barang";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(313, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(232, 387);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(151, 387);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.appData;
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // barangBindingSource1
            // 
            this.barangBindingSource1.DataMember = "Barang";
            this.barangBindingSource1.DataSource = this.appData;
            // 
            // barangBindingSource2
            // 
            this.barangBindingSource2.DataMember = "Barang";
            this.barangBindingSource2.DataSource = this.appData;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            // 
            // jumlahBarangDataGridViewTextBoxColumn
            // 
            this.jumlahBarangDataGridViewTextBoxColumn.DataPropertyName = "JumlahBarang";
            this.jumlahBarangDataGridViewTextBoxColumn.HeaderText = "JumlahBarang";
            this.jumlahBarangDataGridViewTextBoxColumn.Name = "jumlahBarangDataGridViewTextBoxColumn";
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            this.tanggalDataGridViewTextBoxColumn.Width = 112;
            // 
            // appData1
            // 
            this.appData1.DataSetName = "AppData";
            this.appData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangBindingSource3
            // 
            this.barangBindingSource3.DataMember = "Barang";
            this.barangBindingSource3.DataSource = this.appData1;
            // 
            // BetaMart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSave);
            this.Name = "BetaMart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetaMart";
            this.Load += new System.EventHandler(this.BetaMart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTanggal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private AppData appData;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private AppDataTableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.BindingSource barangBindingSource2;
        private System.Windows.Forms.BindingSource barangBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private AppData appData1;
        private System.Windows.Forms.BindingSource barangBindingSource3;
    }
}

