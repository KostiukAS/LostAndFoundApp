namespace LostAndFoundApp.Program
{
    partial class FormFindingInfo
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
            label1 = new Label();
            labelName = new Label();
            label2 = new Label();
            label3 = new Label();
            labelAbout = new Label();
            label4 = new Label();
            labelPhone = new Label();
            label5 = new Label();
            labelMail = new Label();
            buttonClose = new Button();
            listBoxTags = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(12, 37);
            labelName.MaximumSize = new Size(378, 60);
            labelName.Name = "labelName";
            labelName.Size = new Size(64, 28);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(400, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 2;
            label2.Text = "Tags:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(50, 28);
            label3.TabIndex = 4;
            label3.Text = "Info:";
            // 
            // labelAbout
            // 
            labelAbout.AutoSize = true;
            labelAbout.Location = new Point(12, 137);
            labelAbout.MaximumSize = new Size(378, 120);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new Size(35, 20);
            labelAbout.TabIndex = 5;
            labelAbout.Text = "Info";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 265);
            label4.Name = "label4";
            label4.Size = new Size(205, 28);
            label4.TabIndex = 6;
            label4.Text = "Finder phone number:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhone.Location = new Point(12, 293);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(67, 28);
            labelPhone.TabIndex = 7;
            labelPhone.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 331);
            label5.Name = "label5";
            label5.Size = new Size(131, 28);
            label5.TabIndex = 8;
            label5.Text = "Finders email:";
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMail.Location = new Point(12, 359);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(50, 28);
            labelMail.TabIndex = 9;
            labelMail.Text = "Mail";
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.Location = new Point(288, 425);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(102, 37);
            buttonClose.TabIndex = 10;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // listBoxTags
            // 
            listBoxTags.FormattingEnabled = true;
            listBoxTags.ItemHeight = 20;
            listBoxTags.Location = new Point(400, 40);
            listBoxTags.Name = "listBoxTags";
            listBoxTags.Size = new Size(282, 304);
            listBoxTags.TabIndex = 11;
            // 
            // FormFindingInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 474);
            Controls.Add(listBoxTags);
            Controls.Add(buttonClose);
            Controls.Add(labelMail);
            Controls.Add(label5);
            Controls.Add(labelPhone);
            Controls.Add(label4);
            Controls.Add(labelAbout);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelName);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(714, 521);
            MinimumSize = new Size(714, 521);
            Name = "FormFindingInfo";
            Text = "FormFindingInfo";
            Load += FormFindingInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelName;
        private Label label2;
        private Label label3;
        private Label labelAbout;
        private Label label4;
        private Label labelPhone;
        private Label label5;
        private Label labelMail;
        private Button buttonClose;
        private ListBox listBoxTags;
    }
}