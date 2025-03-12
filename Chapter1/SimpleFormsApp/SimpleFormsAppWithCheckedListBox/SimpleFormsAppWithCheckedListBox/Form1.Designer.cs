namespace SimpleFormsAppWithCheckedListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            mvSeriesList = new CheckedListBox();
            favoriteList = new ListBox();
            label2 = new Label();
            label3 = new Label();
            rmvButton = new Button();
            clrButton = new Button();
            addButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rubik", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(176, 21);
            label1.Name = "label1";
            label1.Size = new Size(610, 38);
            label1.TabIndex = 0;
            label1.Text = "SIMPLE FAVORITE MOVIE PICKER APP";
            // 
            // mvSeriesList
            // 
            mvSeriesList.BackColor = SystemColors.InactiveCaptionText;
            mvSeriesList.BorderStyle = BorderStyle.FixedSingle;
            mvSeriesList.Font = new Font("Liberation Serif", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            mvSeriesList.ForeColor = Color.Silver;
            mvSeriesList.FormattingEnabled = true;
            mvSeriesList.Location = new Point(12, 171);
            mvSeriesList.Name = "mvSeriesList";
            mvSeriesList.Size = new Size(306, 254);
            mvSeriesList.TabIndex = 1;
            // 
            // favoriteList
            // 
            favoriteList.BackColor = Color.Black;
            favoriteList.BorderStyle = BorderStyle.FixedSingle;
            favoriteList.Font = new Font("Liberation Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            favoriteList.ForeColor = Color.Silver;
            favoriteList.FormattingEnabled = true;
            favoriteList.ItemHeight = 32;
            favoriteList.Location = new Point(584, 171);
            favoriteList.Name = "favoriteList";
            favoriteList.Size = new Size(306, 258);
            favoriteList.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Subheading", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(289, 47);
            label2.TabIndex = 3;
            label2.Text = "Movies/Series List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Subheading", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(584, 110);
            label3.Name = "label3";
            label3.Size = new Size(306, 47);
            label3.TabIndex = 4;
            label3.Text = "My Favorite Movies";
            // 
            // rmvButton
            // 
            rmvButton.BackColor = Color.Black;
            rmvButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rmvButton.ForeColor = SystemColors.Control;
            rmvButton.Location = new Point(584, 472);
            rmvButton.Name = "rmvButton";
            rmvButton.Size = new Size(111, 50);
            rmvButton.TabIndex = 5;
            rmvButton.Text = "REMOVE";
            rmvButton.UseVisualStyleBackColor = false;
            rmvButton.Click += rmvButton_Click;
            // 
            // clrButton
            // 
            clrButton.BackColor = Color.Black;
            clrButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clrButton.ForeColor = SystemColors.Control;
            clrButton.Location = new Point(779, 473);
            clrButton.Name = "clrButton";
            clrButton.Size = new Size(111, 48);
            clrButton.TabIndex = 6;
            clrButton.Text = "CLEAR ALL";
            clrButton.UseVisualStyleBackColor = false;
            clrButton.Click += clrButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Black;
            addButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.ForeColor = SystemColors.Control;
            addButton.Location = new Point(12, 525);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 67);
            addButton.TabIndex = 7;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(918, 645);
            Controls.Add(addButton);
            Controls.Add(clrButton);
            Controls.Add(rmvButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(favoriteList);
            Controls.Add(mvSeriesList);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MOVIE FORM APP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox mvSeriesList;
        private ListBox favoriteList;
        private Label label2;
        private Label label3;
        private Button rmvButton;
        private Button clrButton;
        private Button addButton;
    }
}
