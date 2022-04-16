namespace AplikasiXML_1198
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtPenerbit = new System.Windows.Forms.TextBox();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnAmbil = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv1);
            this.groupBox1.Controls.Add(this.btnHapus);
            this.groupBox1.Controls.Add(this.btnUbah);
            this.groupBox1.Controls.Add(this.btnTambah);
            this.groupBox1.Controls.Add(this.txtPenerbit);
            this.groupBox1.Controls.Add(this.txtJudul);
            this.groupBox1.Controls.Add(this.txtKode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(41, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 404);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Buku";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv1.Location = new System.Drawing.Point(29, 221);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(521, 150);
            this.dgv1.TabIndex = 9;
            this.dgv1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv1_MouseClick);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(191, 166);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 31);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(110, 166);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 31);
            this.btnUbah.TabIndex = 7;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(29, 166);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 31);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtPenerbit
            // 
            this.txtPenerbit.Location = new System.Drawing.Point(110, 119);
            this.txtPenerbit.Name = "txtPenerbit";
            this.txtPenerbit.Size = new System.Drawing.Size(243, 22);
            this.txtPenerbit.TabIndex = 5;
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(110, 81);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(440, 22);
            this.txtJudul.TabIndex = 4;
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(110, 42);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(132, 22);
            this.txtKode.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Penerbit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Judul";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kode Buku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Pengarang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telepon";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(138, 48);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 5;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(138, 86);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(100, 22);
            this.txtNama.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(478, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtTelp
            // 
            this.txtTelp.Location = new System.Drawing.Point(478, 48);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(149, 22);
            this.txtTelp.TabIndex = 7;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(41, 562);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(156, 31);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "Simpan File ke XML";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnAmbil
            // 
            this.btnAmbil.Location = new System.Drawing.Point(478, 562);
            this.btnAmbil.Name = "btnAmbil";
            this.btnAmbil.Size = new System.Drawing.Size(149, 31);
            this.btnAmbil.TabIndex = 11;
            this.btnAmbil.Text = "Ambil File XML";
            this.btnAmbil.UseVisualStyleBackColor = true;
            this.btnAmbil.Click += new System.EventHandler(this.btnAmbil_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode Buku";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Judul Buku";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Penerbit";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 629);
            this.Controls.Add(this.btnAmbil);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelp);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Save to XML";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelp;
        private System.Windows.Forms.TextBox txtPenerbit;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnAmbil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

