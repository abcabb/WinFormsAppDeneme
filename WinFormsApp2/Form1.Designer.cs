namespace WinFormsApp2
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
            result = new Label();
            numberOne = new TextBox();
            numberTwo = new TextBox();
            sumButton = new Button();
            substractButton = new Button();
            multiButton = new Button();
            divideButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 73);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "1. SAYI :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 110);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "2. SAYI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 157);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "SONUÇ : ";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(203, 157);
            result.Name = "result";
            result.Size = new Size(0, 15);
            result.TabIndex = 3;
            // 
            // numberOne
            // 
            numberOne.Location = new Point(203, 65);
            numberOne.Name = "numberOne";
            numberOne.Size = new Size(100, 23);
            numberOne.TabIndex = 4;
            numberOne.TextChanged += textBox1_TextChanged;
            // 
            // numberTwo
            // 
            numberTwo.Location = new Point(203, 102);
            numberTwo.Name = "numberTwo";
            numberTwo.Size = new Size(100, 23);
            numberTwo.TabIndex = 5;
            // 
            // sumButton
            // 
            sumButton.Location = new Point(120, 195);
            sumButton.Name = "sumButton";
            sumButton.Size = new Size(75, 23);
            sumButton.TabIndex = 6;
            sumButton.Text = "TOPLA";
            sumButton.UseVisualStyleBackColor = true;
            sumButton.Click += sumButton_Click;
            // 
            // substractButton
            // 
            substractButton.Location = new Point(213, 195);
            substractButton.Name = "substractButton";
            substractButton.Size = new Size(75, 23);
            substractButton.TabIndex = 7;
            substractButton.Text = "ÇIKAR";
            substractButton.UseVisualStyleBackColor = true;
            substractButton.Click += substractButton_Click;
            // 
            // multiButton
            // 
            multiButton.Location = new Point(305, 195);
            multiButton.Name = "multiButton";
            multiButton.Size = new Size(75, 23);
            multiButton.TabIndex = 8;
            multiButton.Text = "ÇARP";
            multiButton.UseVisualStyleBackColor = true;
            multiButton.Click += multiButton_Click;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(404, 195);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(75, 23);
            divideButton.TabIndex = 9;
            divideButton.Text = "BÖL";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(divideButton);
            Controls.Add(multiButton);
            Controls.Add(substractButton);
            Controls.Add(sumButton);
            Controls.Add(numberTwo);
            Controls.Add(numberOne);
            Controls.Add(result);
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
        private Label result;
        private TextBox numberOne;
        private TextBox numberTwo;
        private Button sumButton;
        private Button substractButton;
        private Button multiButton;
        private Button divideButton;
    }
}
