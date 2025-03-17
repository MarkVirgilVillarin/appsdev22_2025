namespace SimpleFormsAppWithComboBox
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
            comboBox = new ComboBox();
            label3 = new Label();
            checkedListBox = new CheckedListBox();
            label4 = new Label();
            listBox = new ListBox();
            addBtn = new Button();
            removeBtn = new Button();
            clearBtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            selcBtn = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 64);
            label1.Location = new Point(285, 9);
            label1.Name = "label1";
            label1.Size = new Size(442, 48);
            label1.TabIndex = 0;
            label1.Text = "Favorite Food Picker App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(3, 140);
            label2.Name = "label2";
            label2.Size = new Size(95, 31);
            label2.TabIndex = 1;
            label2.Text = "Cuisine";
            // 
            // comboBox
            // 
            comboBox.BackColor = Color.White;
            comboBox.FlatStyle = FlatStyle.Popup;
            comboBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox.ForeColor = Color.Black;
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(13, 46);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(121, 33);
            comboBox.TabIndex = 2;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 64, 64);
            label3.Location = new Point(341, 140);
            label3.Name = "label3";
            label3.Size = new Size(115, 31);
            label3.TabIndex = 4;
            label3.Text = "Food List";
            // 
            // checkedListBox
            // 
            checkedListBox.BackColor = Color.White;
            checkedListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkedListBox.ForeColor = Color.FromArgb(128, 64, 0);
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(285, 16);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(279, 184);
            checkedListBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(128, 64, 64);
            label4.Location = new Point(639, 140);
            label4.Name = "label4";
            label4.Size = new Size(255, 31);
            label4.TabIndex = 6;
            label4.Text = "My Favorite Food List";
            // 
            // listBox
            // 
            listBox.BackColor = Color.White;
            listBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox.ForeColor = Color.FromArgb(128, 64, 0);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 30;
            listBox.Location = new Point(639, 16);
            listBox.Name = "listBox";
            listBox.Size = new Size(287, 184);
            listBox.TabIndex = 7;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(255, 224, 192);
            addBtn.FlatStyle = FlatStyle.Popup;
            addBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.Maroon;
            addBtn.Location = new Point(338, 19);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(102, 36);
            addBtn.TabIndex = 8;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.BackColor = Color.FromArgb(255, 224, 192);
            removeBtn.FlatStyle = FlatStyle.Popup;
            removeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeBtn.ForeColor = Color.Maroon;
            removeBtn.Location = new Point(636, 19);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(100, 43);
            removeBtn.TabIndex = 9;
            removeBtn.Text = "REMOVE";
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(255, 224, 192);
            clearBtn.FlatStyle = FlatStyle.Popup;
            clearBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.ForeColor = Color.Maroon;
            clearBtn.Location = new Point(823, 19);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(100, 43);
            clearBtn.TabIndex = 10;
            clearBtn.Text = "CLEAR ALL";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(153, 188, 133);
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(removeBtn);
            panel1.Controls.Add(clearBtn);
            panel1.Location = new Point(-1, 381);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 168);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(253, 250, 246);
            panel2.Controls.Add(selcBtn);
            panel2.Controls.Add(checkedListBox);
            panel2.Controls.Add(listBox);
            panel2.Controls.Add(comboBox);
            panel2.Location = new Point(-1, 175);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 216);
            panel2.TabIndex = 12;
            // 
            // selcBtn
            // 
            selcBtn.BackColor = Color.FromArgb(255, 224, 192);
            selcBtn.FlatStyle = FlatStyle.Popup;
            selcBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selcBtn.ForeColor = Color.Maroon;
            selcBtn.Location = new Point(13, 101);
            selcBtn.Name = "selcBtn";
            selcBtn.Size = new Size(93, 35);
            selcBtn.TabIndex = 8;
            selcBtn.Text = "SELECT";
            selcBtn.UseVisualStyleBackColor = false;
            selcBtn.Click += selcBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(250, 241, 230);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(-1, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1008, 175);
            panel3.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1006, 549);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Favorite Food Picker App";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox;
        private Label label3;
        private CheckedListBox checkedListBox;
        private Label label4;
        private ListBox listBox;
        private Button addBtn;
        private Button removeBtn;
        private Button clearBtn;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button selcBtn;
    }
}
