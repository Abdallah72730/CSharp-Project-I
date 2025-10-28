namespace Simple_Calculator
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
            label3 = new Label();
            label4 = new Label();
            txtOperand1 = new TextBox();
            txtOperator = new TextBox();
            txtOperand2 = new TextBox();
            txtResult = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 68);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Operand 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 125);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Operator:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 179);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Operand 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 230);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Result:";
            // 
            // txtOperand1
            // 
            txtOperand1.Location = new Point(186, 65);
            txtOperand1.Name = "txtOperand1";
            txtOperand1.Size = new Size(160, 23);
            txtOperand1.TabIndex = 4;
            // 
            // txtOperator
            // 
            txtOperator.Location = new Point(186, 122);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(46, 23);
            txtOperator.TabIndex = 5;
            // 
            // txtOperand2
            // 
            txtOperand2.Location = new Point(186, 176);
            txtOperand2.Name = "txtOperand2";
            txtOperand2.Size = new Size(160, 23);
            txtOperand2.TabIndex = 6;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(186, 227);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(160, 23);
            txtResult.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(68, 303);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(121, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(208, 303);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(127, 23);
            btnExit.TabIndex = 9;
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
            ClientSize = new Size(439, 378);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtResult);
            Controls.Add(txtOperand2);
            Controls.Add(txtOperator);
            Controls.Add(txtOperand1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtOperand1;
        private TextBox txtOperator;
        private TextBox txtOperand2;
        private TextBox txtResult;
        private Button btnCalculate;
        private Button btnExit;
    }
}
