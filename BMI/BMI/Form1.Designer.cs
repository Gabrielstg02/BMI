namespace BMI
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
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.radKg = new System.Windows.Forms.RadioButton();
            this.radLb = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(129, 85);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(116, 23);
            this.txtWeight.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(129, 121);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(116, 23);
            this.txtHeight.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtResult.Location = new System.Drawing.Point(33, 229);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(212, 73);
            this.txtResult.TabIndex = 5;
            // 
            // radKg
            // 
            this.radKg.AutoSize = true;
            this.radKg.Location = new System.Drawing.Point(35, 166);
            this.radKg.Name = "radKg";
            this.radKg.Size = new System.Drawing.Size(73, 19);
            this.radKg.TabIndex = 8;
            this.radKg.TabStop = true;
            this.radKg.Text = "Kilogram";
            this.radKg.UseVisualStyleBackColor = true;
            // 
            // radLb
            // 
            this.radLb.AutoSize = true;
            this.radLb.Location = new System.Drawing.Point(185, 166);
            this.radLb.Name = "radLb";
            this.radLb.Size = new System.Drawing.Size(60, 19);
            this.radLb.TabIndex = 9;
            this.radLb.TabStop = true;
            this.radLb.Text = "Pound";
            this.radLb.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(33, 315);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(212, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(33, 344);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(139, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 69);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(115, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "BMI Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.radLb);
            this.Controls.Add(this.radKg);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private TextBox txtResult;
        private RadioButton radKg;
        private RadioButton radLb;
        private Button btnCalculate;
        private Button btnReset;
        private Button btnExit;
        private Panel panel1;
        private Label label4;
    }
}