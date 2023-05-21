namespace LostAndFoundApp.Program
{
    partial class FormAddFinding
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            textBoxName = new TextBox();
            labelAbout = new Label();
            RichTextBoxAbout = new RichTextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelMail = new Label();
            textBoxMail = new TextBox();
            labelTags = new Label();
            CheckedListBoxTags = new CheckedListBox();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(12, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(131, 28);
            labelName.TabIndex = 0;
            labelName.Text = "Finding name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 40);
            textBoxName.MaxLength = 60;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(359, 27);
            textBoxName.TabIndex = 1;
            // 
            // labelAbout
            // 
            labelAbout.AutoSize = true;
            labelAbout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAbout.Location = new Point(12, 81);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new Size(143, 28);
            labelAbout.TabIndex = 2;
            labelAbout.Text = "Additional info";
            // 
            // RichTextBoxAbout
            // 
            RichTextBoxAbout.Location = new Point(12, 112);
            RichTextBoxAbout.MaxLength = 250;
            RichTextBoxAbout.Name = "RichTextBoxAbout";
            RichTextBoxAbout.Size = new Size(359, 112);
            RichTextBoxAbout.TabIndex = 3;
            RichTextBoxAbout.Text = "";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhone.Location = new Point(12, 243);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(140, 28);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Phone number";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(12, 274);
            textBoxPhone.MaxLength = 13;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.PlaceholderText = "+38XXXXXXXXXX";
            textBoxPhone.Size = new Size(359, 27);
            textBoxPhone.TabIndex = 5;
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMail.Location = new Point(12, 316);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(50, 28);
            labelMail.TabIndex = 6;
            labelMail.Text = "Mail";
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(12, 347);
            textBoxMail.MaxLength = 100;
            textBoxMail.Name = "textBoxMail";
            textBoxMail.PlaceholderText = "example@gmail.com";
            textBoxMail.Size = new Size(359, 27);
            textBoxMail.TabIndex = 7;
            // 
            // labelTags
            // 
            labelTags.AutoSize = true;
            labelTags.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTags.Location = new Point(381, 9);
            labelTags.Name = "labelTags";
            labelTags.Size = new Size(50, 28);
            labelTags.TabIndex = 8;
            labelTags.Text = "Tags";
            // 
            // CheckedListBoxTags
            // 
            CheckedListBoxTags.CheckOnClick = true;
            CheckedListBoxTags.FormattingEnabled = true;
            CheckedListBoxTags.Location = new Point(381, 40);
            CheckedListBoxTags.Name = "CheckedListBoxTags";
            CheckedListBoxTags.Size = new Size(246, 334);
            CheckedListBoxTags.TabIndex = 9;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(250, 397);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(121, 41);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Add finding";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormAddFinding
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 450);
            Controls.Add(buttonAdd);
            Controls.Add(CheckedListBoxTags);
            Controls.Add(labelTags);
            Controls.Add(textBoxMail);
            Controls.Add(labelMail);
            Controls.Add(textBoxPhone);
            Controls.Add(labelPhone);
            Controls.Add(RichTextBoxAbout);
            Controls.Add(labelAbout);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            MaximizeBox = false;
            MaximumSize = new Size(655, 497);
            MinimumSize = new Size(655, 497);
            Name = "FormAddFinding";
            Text = "Add finding";
            Load += FormAddFinding_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private Label labelAbout;
        private RichTextBox RichTextBoxAbout;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelMail;
        private TextBox textBoxMail;
        private Label labelTags;
        private CheckedListBox CheckedListBoxTags;
        private Button buttonAdd;
    }
}