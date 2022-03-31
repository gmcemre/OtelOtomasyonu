
namespace OtelOtomasyonu_WinFormUI
{
    partial class MusteriForm
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
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSirketAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTckn = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTelNo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMedeniDurum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(27, 66);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(117, 20);
            this.txtAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(152, 65);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(117, 20);
            this.txtSoyadi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Şirket Adı:";
            // 
            // txtSirketAdi
            // 
            this.txtSirketAdi.Location = new System.Drawing.Point(272, 66);
            this.txtSirketAdi.Name = "txtSirketAdi";
            this.txtSirketAdi.Size = new System.Drawing.Size(117, 20);
            this.txtSirketAdi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "TCKN:";
            // 
            // mskTckn
            // 
            this.mskTckn.Location = new System.Drawing.Point(395, 65);
            this.mskTckn.Mask = "00000000000";
            this.mskTckn.Name = "mskTckn";
            this.mskTckn.Size = new System.Drawing.Size(117, 20);
            this.mskTckn.TabIndex = 3;
            this.mskTckn.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tel No:";
            // 
            // mskTelNo
            // 
            this.mskTelNo.Location = new System.Drawing.Point(521, 65);
            this.mskTelNo.Mask = "(999) 000-0000";
            this.mskTelNo.Name = "mskTelNo";
            this.mskTelNo.Size = new System.Drawing.Size(117, 20);
            this.mskTelNo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Doğum Tarihi";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(30, 123);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(108, 20);
            this.dtpDogumTarihi.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Medeni Durum:";
            // 
            // cmbMedeniDurum
            // 
            this.cmbMedeniDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedeniDurum.FormattingEnabled = true;
            this.cmbMedeniDurum.Location = new System.Drawing.Point(144, 121);
            this.cmbMedeniDurum.Name = "cmbMedeniDurum";
            this.cmbMedeniDurum.Size = new System.Drawing.Size(121, 21);
            this.cmbMedeniDurum.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cinsiyet:";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(272, 121);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cmbCinsiyet.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(423, 119);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 241);
            this.dataGridView1.TabIndex = 9;
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 434);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.cmbMedeniDurum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskTelNo);
            this.Controls.Add(this.mskTckn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSirketAdi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MusteriForm";
            this.Text = "MusteriForm";
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSirketAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTckn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTelNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMedeniDurum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}