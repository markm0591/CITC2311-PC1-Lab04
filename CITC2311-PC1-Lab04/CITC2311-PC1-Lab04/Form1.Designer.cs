namespace CITC2311_PC1_Lab04
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
            Operand1TxtBx = new TextBox();
            Operand2TxtBx = new TextBox();
            ResultTxtBx = new TextBox();
            OperatorTxtBx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CalculateBtn = new Button();
            Exit = new Button();
            SuspendLayout();
            //
            // Operand1TxtBx
            //
            Operand1TxtBx.Location = new Point(119, 22);
            Operand1TxtBx.Name = "Operand1TxtBx";
            Operand1TxtBx.Size = new Size(100, 23);
            Operand1TxtBx.TabIndex = 0;
            Operand1TxtBx.TextChanged += Operand_TextChanged;
            //
            // Operand2TxtBx
            //
            Operand2TxtBx.Location = new Point(119, 80);
            Operand2TxtBx.Name = "Operand2TxtBx";
            Operand2TxtBx.Size = new Size(100, 23);
            Operand2TxtBx.TabIndex = 1;
            Operand2TxtBx.TextChanged += Operand_TextChanged;
            //
            // ResultTxtBx
            //
            ResultTxtBx.Location = new Point(119, 109);
            ResultTxtBx.Name = "ResultTxtBx";
            ResultTxtBx.ReadOnly = true;
            ResultTxtBx.Size = new Size(100, 23);
            ResultTxtBx.TabIndex = 2;
            //
            // OperatorTxtBx
            //
            OperatorTxtBx.Location = new Point(119, 51);
            OperatorTxtBx.Name = "OperatorTxtBx";
            OperatorTxtBx.Size = new Size(31, 23);
            OperatorTxtBx.TabIndex = 3;
            OperatorTxtBx.TextChanged += Operand_TextChanged;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(26, 25);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 4;
            label1.Text = "Operand 1:";
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(26, 83);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 5;
            label2.Text = "Operand 2:";
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(26, 54);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Operator:";
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Location = new Point(26, 112);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "Result:";
            //
            // CalculateBtn
            //
            CalculateBtn.BackColor = SystemColors.ButtonFace;
            CalculateBtn.Location = new Point(28, 149);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(79, 23);
            CalculateBtn.TabIndex = 8;
            CalculateBtn.Text = "&Calculate";
            CalculateBtn.UseVisualStyleBackColor = false;
            CalculateBtn.Click += Calculate_Click;
            //
            // Exit
            //
            Exit.BackColor = SystemColors.ButtonFace;
            Exit.Location = new Point(128, 149);
            Exit.Name = "Exit";
            Exit.Size = new Size(79, 23);
            Exit.TabIndex = 9;
            Exit.Text = "E&xit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(249, 192);
            AcceptButton = CalculateBtn;
            CancelButton = Exit;
            Controls.Add(Exit);
            Controls.Add(CalculateBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OperatorTxtBx);
            Controls.Add(ResultTxtBx);
            Controls.Add(Operand2TxtBx);
            Controls.Add(Operand1TxtBx);
            Name = "Form1";
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Operand1TxtBx;
        private TextBox Operand2TxtBx;
        private TextBox ResultTxtBx;
        private TextBox OperatorTxtBx;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button CalculateBtn;
        private Button Exit;
    }
}
