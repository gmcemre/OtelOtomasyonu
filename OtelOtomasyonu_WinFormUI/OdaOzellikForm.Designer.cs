
namespace OtelOtomasyonu_WinFormUI
{
    partial class OdaOzellikForm
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
            this.cmbOdalar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listOzellikler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oda:";
            // 
            // cmbOdalar
            // 
            this.cmbOdalar.FormattingEnabled = true;
            this.cmbOdalar.Location = new System.Drawing.Point(34, 73);
            this.cmbOdalar.Name = "cmbOdalar";
            this.cmbOdalar.Size = new System.Drawing.Size(148, 21);
            this.cmbOdalar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Özellikler:";
            // 
            // listOzellikler
            // 
            this.listOzellikler.FormattingEnabled = true;
            this.listOzellikler.Location = new System.Drawing.Point(205, 73);
            this.listOzellikler.Name = "listOzellikler";
            this.listOzellikler.Size = new System.Drawing.Size(185, 212);
            this.listOzellikler.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(424, 117);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(421, 74);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(112, 20);
            this.txtDeger.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Değer:";
            // 
            // OdaOzellikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 312);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDeger);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.listOzellikler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOdalar);
            this.Controls.Add(this.label1);
            this.Name = "OdaOzellikForm";
            this.Text = "OdaOzellikForm";
            this.Load += new System.EventHandler(this.OdaOzellikForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOdalar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listOzellikler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.Label label3;
    }
}