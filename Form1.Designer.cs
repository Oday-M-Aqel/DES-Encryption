namespace DES_Encryption
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
            button1 = new Button();
            button2 = new Button();
            newPlainText = new TextBox();
            Password = new TextBox();
            AfterIP = new TextBox();
            BeforIP = new TextBox();
            LeftXorRightText = new TextBox();
            SBoxResultText = new TextBox();
            XorTextBox = new TextBox();
            newExpansion = new TextBox();
            EncryptedText = new TextBox();
            DESResult = new TextBox();
            LeftText = new TextBox();
            RightText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 336);
            button1.Name = "button1";
            button1.Size = new Size(368, 31);
            button1.TabIndex = 0;
            button1.Text = "Encrypt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(386, 336);
            button2.Name = "button2";
            button2.Size = new Size(368, 31);
            button2.TabIndex = 1;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // newPlainText
            // 
            newPlainText.Location = new Point(12, 12);
            newPlainText.Name = "newPlainText";
            newPlainText.Size = new Size(590, 21);
            newPlainText.TabIndex = 2;
            // 
            // Password
            // 
            Password.Location = new Point(12, 39);
            Password.MaxLength = 6;
            Password.Name = "Password";
            Password.Size = new Size(590, 21);
            Password.TabIndex = 3;
            // 
            // AfterIP
            // 
            AfterIP.Location = new Point(12, 93);
            AfterIP.Name = "AfterIP";
            AfterIP.ReadOnly = true;
            AfterIP.Size = new Size(590, 21);
            AfterIP.TabIndex = 5;
            // 
            // BeforIP
            // 
            BeforIP.Location = new Point(12, 66);
            BeforIP.Name = "BeforIP";
            BeforIP.ReadOnly = true;
            BeforIP.Size = new Size(590, 21);
            BeforIP.TabIndex = 4;
            // 
            // LeftXorRightText
            // 
            LeftXorRightText.Location = new Point(12, 201);
            LeftXorRightText.Name = "LeftXorRightText";
            LeftXorRightText.ReadOnly = true;
            LeftXorRightText.Size = new Size(590, 21);
            LeftXorRightText.TabIndex = 9;
            // 
            // SBoxResultText
            // 
            SBoxResultText.Location = new Point(12, 174);
            SBoxResultText.Name = "SBoxResultText";
            SBoxResultText.ReadOnly = true;
            SBoxResultText.Size = new Size(590, 21);
            SBoxResultText.TabIndex = 8;
            // 
            // XorTextBox
            // 
            XorTextBox.Location = new Point(12, 147);
            XorTextBox.Name = "XorTextBox";
            XorTextBox.ReadOnly = true;
            XorTextBox.Size = new Size(590, 21);
            XorTextBox.TabIndex = 7;
            // 
            // newExpansion
            // 
            newExpansion.Location = new Point(12, 120);
            newExpansion.Name = "newExpansion";
            newExpansion.ReadOnly = true;
            newExpansion.Size = new Size(590, 21);
            newExpansion.TabIndex = 6;
            // 
            // EncryptedText
            // 
            EncryptedText.Location = new Point(12, 309);
            EncryptedText.Name = "EncryptedText";
            EncryptedText.ReadOnly = true;
            EncryptedText.Size = new Size(590, 21);
            EncryptedText.TabIndex = 13;
            // 
            // DESResult
            // 
            DESResult.Location = new Point(12, 282);
            DESResult.Name = "DESResult";
            DESResult.ReadOnly = true;
            DESResult.Size = new Size(590, 21);
            DESResult.TabIndex = 12;
            // 
            // LeftText
            // 
            LeftText.Location = new Point(12, 255);
            LeftText.Name = "LeftText";
            LeftText.ReadOnly = true;
            LeftText.Size = new Size(590, 21);
            LeftText.TabIndex = 11;
            // 
            // RightText
            // 
            RightText.Location = new Point(12, 228);
            RightText.Name = "RightText";
            RightText.ReadOnly = true;
            RightText.Size = new Size(590, 21);
            RightText.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(615, 13);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 14;
            label1.Text = "Plain Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(615, 42);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 15;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(615, 69);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 16;
            label3.Text = "Before Initial Permutaion";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(615, 96);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 17;
            label4.Text = "After Initail Permutaion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(616, 123);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 18;
            label5.Text = "Expansion Result";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(615, 150);
            label6.Name = "label6";
            label6.Size = new Size(136, 15);
            label6.TabIndex = 19;
            label6.Text = "Key XOR 48bit Plain Text";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(616, 177);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 20;
            label7.Text = "S-Boxs Result";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(616, 204);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 21;
            label8.Text = "Left XOR Right";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(615, 231);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 22;
            label9.Text = "Right Text";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(616, 258);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 23;
            label10.Text = "Left Text";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(615, 285);
            label11.Name = "label11";
            label11.Size = new Size(112, 15);
            label11.TabIndex = 24;
            label11.Text = "DES Result In Binary";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(615, 312);
            label12.Name = "label12";
            label12.Size = new Size(100, 15);
            label12.TabIndex = 25;
            label12.Text = "DES Result In Text";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 377);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EncryptedText);
            Controls.Add(DESResult);
            Controls.Add(LeftText);
            Controls.Add(RightText);
            Controls.Add(LeftXorRightText);
            Controls.Add(SBoxResultText);
            Controls.Add(XorTextBox);
            Controls.Add(newExpansion);
            Controls.Add(AfterIP);
            Controls.Add(BeforIP);
            Controls.Add(Password);
            Controls.Add(newPlainText);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Encryptio Staandard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox newPlainText;
        private TextBox Password;
        private TextBox AfterIP;
        private TextBox BeforIP;
        private TextBox LeftXorRightText;
        private TextBox SBoxResultText;
        private TextBox XorTextBox;
        private TextBox newExpansion;
        private TextBox EncryptedText;
        private TextBox DESResult;
        private TextBox LeftText;
        private TextBox RightText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
