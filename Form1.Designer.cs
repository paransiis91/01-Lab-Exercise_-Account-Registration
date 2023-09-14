namespace Account_Registration
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
            components = new System.ComponentModel.Container();
            studentNo = new TextBox();
            firstName = new TextBox();
            lastName = new TextBox();
            middleName = new TextBox();
            age = new TextBox();
            contactNo = new TextBox();
            address = new RichTextBox();
            program = new ComboBox();
            delegateTextBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)delegateTextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // studentNo
            // 
            studentNo.Location = new Point(12, 56);
            studentNo.Name = "studentNo";
            studentNo.Size = new Size(184, 23);
            studentNo.TabIndex = 0;
            // 
            // firstName
            // 
            firstName.Location = new Point(12, 121);
            firstName.Name = "firstName";
            firstName.Size = new Size(184, 23);
            firstName.TabIndex = 1;
            // 
            // lastName
            // 
            lastName.Location = new Point(212, 121);
            lastName.Name = "lastName";
            lastName.Size = new Size(184, 23);
            lastName.TabIndex = 2;
            // 
            // middleName
            // 
            middleName.Location = new Point(411, 121);
            middleName.Name = "middleName";
            middleName.Size = new Size(184, 23);
            middleName.TabIndex = 3;
            // 
            // age
            // 
            age.Location = new Point(12, 188);
            age.Name = "age";
            age.Size = new Size(184, 23);
            age.TabIndex = 4;
            // 
            // contactNo
            // 
            contactNo.Location = new Point(212, 188);
            contactNo.Name = "contactNo";
            contactNo.Size = new Size(184, 23);
            contactNo.TabIndex = 5;
            // 
            // address
            // 
            address.Location = new Point(12, 259);
            address.Name = "address";
            address.Size = new Size(583, 135);
            address.TabIndex = 6;
            address.Text = "";
            // 
            // program
            // 
            program.AllowDrop = true;
            program.FormattingEnabled = true;
            program.Location = new Point(212, 56);
            program.Name = "program";
            program.Size = new Size(285, 23);
            program.TabIndex = 7;
            // 
            // delegateTextBindingSource
            // 
            delegateTextBindingSource.DataSource = typeof(DelegateText);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 34);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 8;
            label1.Text = "Student No.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 34);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 9;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 10;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 103);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 11;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(411, 103);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 12;
            label5.Text = "Middle Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 170);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 13;
            label6.Text = "Age:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 170);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 14;
            label7.Text = "Contact No.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 241);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 15;
            label8.Text = "Address";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(242, 411);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(107, 27);
            btnNext.TabIndex = 16;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 450);
            Controls.Add(btnNext);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(program);
            Controls.Add(address);
            Controls.Add(contactNo);
            Controls.Add(age);
            Controls.Add(middleName);
            Controls.Add(lastName);
            Controls.Add(firstName);
            Controls.Add(studentNo);
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "FrmRegistration";
            ((System.ComponentModel.ISupportInitialize)delegateTextBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox studentNo;
        private TextBox firstName;
        private TextBox lastName;
        private TextBox middleName;
        private TextBox age;
        private TextBox contactNo;
        private RichTextBox address;
        private ComboBox program;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnNext;
        private BindingSource delegateTextBindingSource;
    }
}