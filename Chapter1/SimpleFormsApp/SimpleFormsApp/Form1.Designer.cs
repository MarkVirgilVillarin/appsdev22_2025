namespace SimpleFormsApp
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
            firstName = new TextBox();
            label2 = new Label();
            lastName = new TextBox();
            button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 88);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 0;
            label1.Text = "FirstName:";
            label1.Click += label1_Click;
            // 
            // firstName
            // 
            firstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstName.Location = new Point(293, 123);
            firstName.Name = "firstName";
            firstName.Size = new Size(186, 29);
            firstName.TabIndex = 1;
            firstName.TextChanged += firstName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(344, 195);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 2;
            label2.Text = "LastName:";
            // 
            // lastName
            // 
            lastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastName.Location = new Point(293, 229);
            lastName.Name = "lastName";
            lastName.Size = new Size(186, 29);
            lastName.TabIndex = 3;
            lastName.TextChanged += lastName_TextChanged;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button.Location = new Point(344, 285);
            button.Name = "button";
            button.Size = new Size(87, 36);
            button.TabIndex = 4;
            button.Text = "Submit";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button);
            Controls.Add(lastName);
            Controls.Add(label2);
            Controls.Add(firstName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox firstName;
        private Label label2;
        private TextBox lastName;
        private Button button;
    }
}
