namespace BMICalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radKg = new System.Windows.Forms.RadioButton();
            this.radLb = new System.Windows.Forms.RadioButton();
            this.txtBerat = new System.Windows.Forms.TextBox();
            this.txtTinggi = new System.Windows.Forms.TextBox();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Berat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tinggi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasil";
            // 
            // radKg
            // 
            this.radKg.AutoSize = true;
            this.radKg.Location = new System.Drawing.Point(85, 166);
            this.radKg.Name = "radKg";
            this.radKg.Size = new System.Drawing.Size(73, 19);
            this.radKg.TabIndex = 3;
            this.radKg.TabStop = true;
            this.radKg.Text = "Kilogram";
            this.radKg.UseVisualStyleBackColor = true;
            // 
            // radLb
            // 
            this.radLb.AutoSize = true;
            this.radLb.Location = new System.Drawing.Point(192, 166);
            this.radLb.Name = "radLb";
            this.radLb.Size = new System.Drawing.Size(60, 19);
            this.radLb.TabIndex = 4;
            this.radLb.TabStop = true;
            this.radLb.Text = "Pound";
            this.radLb.UseVisualStyleBackColor = true;
            // 
            // txtBerat
            // 
            this.txtBerat.Location = new System.Drawing.Point(139, 57);
            this.txtBerat.Name = "txtBerat";
            this.txtBerat.Size = new System.Drawing.Size(141, 23);
            this.txtBerat.TabIndex = 5;
            // 
            // txtTinggi
            // 
            this.txtTinggi.Location = new System.Drawing.Point(139, 109);
            this.txtTinggi.Name = "txtTinggi";
            this.txtTinggi.Size = new System.Drawing.Size(141, 23);
            this.txtTinggi.TabIndex = 6;
            // 
            // txtHasil
            // 
            this.txtHasil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtHasil.Location = new System.Drawing.Point(67, 246);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.ReadOnly = true;
            this.txtHasil.Size = new System.Drawing.Size(213, 23);
            this.txtHasil.TabIndex = 7;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(67, 290);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(213, 23);
            this.btnHitung.TabIndex = 8;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(67, 332);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(91, 23);
            this.btnHapus.TabIndex = 9;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(192, 332);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(88, 23);
            this.btnKeluar.TabIndex = 10;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.txtTinggi);
            this.Controls.Add(this.txtBerat);
            this.Controls.Add(this.radLb);
            this.Controls.Add(this.radKg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton radKg;
        private RadioButton radLb;
        private TextBox txtBerat;
        private TextBox txtTinggi;
        private TextBox txtHasil;
        private Button btnHitung;
        private Button btnHapus;
        private Button btnKeluar;
    }
}