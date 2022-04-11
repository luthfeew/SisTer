namespace LatihanStream_1198
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(136, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 3;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(136, 75);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(213, 22);
            this.txtNama.TabIndex = 4;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(136, 122);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(375, 22);
            this.txtAlamat.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonLast);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonPrev);
            this.panel1.Controls.Add(this.buttonFirst);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtAlamat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNama);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 243);
            this.panel1.TabIndex = 6;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(436, 176);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 33);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(355, 176);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 33);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(274, 176);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 33);
            this.buttonLast.TabIndex = 10;
            this.buttonLast.Text = "Last";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(193, 176);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 33);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(112, 176);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 33);
            this.buttonPrev.TabIndex = 8;
            this.buttonPrev.Text = "Prev";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(31, 176);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 33);
            this.buttonFirst.TabIndex = 7;
            this.buttonFirst.Text = "First";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(286, 281);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 33);
            this.buttonOpen.TabIndex = 13;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(367, 281);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 33);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(448, 281);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 33);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(312, 31);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 16);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total Record";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 348);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Data Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Label lblTotal;
    }
}

