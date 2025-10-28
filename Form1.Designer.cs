namespace Income_Tax_Calculator
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
            label1 = new Label();
            label2 = new Label();
            txtTaxableIncome = new TextBox();
            txtTaxOwed = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 98);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Taxable income:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 156);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "Income tax owed:";
            // 
            // txtTaxableIncome
            // 
            txtTaxableIncome.Location = new Point(263, 95);
            txtTaxableIncome.Name = "txtTaxableIncome";
            txtTaxableIncome.Size = new Size(188, 23);
            txtTaxableIncome.TabIndex = 2;
            // 
            // txtTaxOwed
            // 
            txtTaxOwed.Location = new Point(263, 153);
            txtTaxOwed.Name = "txtTaxOwed";
            txtTaxOwed.ReadOnly = true;
            txtTaxOwed.Size = new Size(188, 23);
            txtTaxOwed.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(93, 231);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(153, 23);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(287, 231);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(164, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(573, 331);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtTaxOwed);
            Controls.Add(txtTaxableIncome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTaxableIncome;
        private TextBox txtTaxOwed;
        private Button btnCalculate;
        private Button btnExit;
    }
}
