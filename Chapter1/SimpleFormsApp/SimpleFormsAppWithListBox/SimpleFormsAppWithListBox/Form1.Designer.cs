namespace SimpleFormsAppWithListBox
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
            listBox = new ListBox();
            textBox = new TextBox();
            addBtn = new Button();
            rmvBtn = new Button();
            clrBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 32);
            label1.Name = "label1";
            label1.Size = new Size(331, 45);
            label1.TabIndex = 0;
            label1.Text = "Simple Name Viewer";
            // 
            // listBox
            // 
            listBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 32;
            listBox.Location = new Point(27, 119);
            listBox.Name = "listBox";
            listBox.Size = new Size(249, 388);
            listBox.TabIndex = 1;
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox.Location = new Point(341, 119);
            textBox.Name = "textBox";
            textBox.Size = new Size(192, 39);
            textBox.TabIndex = 2;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(374, 202);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(126, 50);
            addBtn.TabIndex = 3;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // rmvBtn
            // 
            rmvBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rmvBtn.Location = new Point(374, 300);
            rmvBtn.Name = "rmvBtn";
            rmvBtn.Size = new Size(126, 48);
            rmvBtn.TabIndex = 4;
            rmvBtn.Text = "Remove";
            rmvBtn.UseVisualStyleBackColor = true;
            rmvBtn.Click += rmvBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clrBtn.Location = new Point(374, 389);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(126, 57);
            clrBtn.TabIndex = 5;
            clrBtn.Text = "Clear";
            clrBtn.UseVisualStyleBackColor = true;
            clrBtn.Click += clrBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 652);
            Controls.Add(clrBtn);
            Controls.Add(rmvBtn);
            Controls.Add(addBtn);
            Controls.Add(textBox);
            Controls.Add(listBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox;
        private TextBox textBox;
        private Button addBtn;
        private Button rmvBtn;
        private Button clrBtn;
    }
}
