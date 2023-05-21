namespace LostAndFoundApp
{
    partial class FormMain
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
            labelAppName = new Label();
            lbFindings = new ListBox();
            labelFindings = new Label();
            BtnAddFinding = new Button();
            BtnDeleteFinding = new Button();
            BtnShowInfo = new Button();
            CheckListBoxFilter = new CheckedListBox();
            BtnFilter = new Button();
            BtnFilterRemove = new Button();
            LabelFilters = new Label();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonClearSearch = new Button();
            SuspendLayout();
            // 
            // labelAppName
            // 
            labelAppName.AutoSize = true;
            labelAppName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelAppName.Location = new Point(12, 9);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(251, 46);
            labelAppName.TabIndex = 0;
            labelAppName.Text = "Lost and Found";
            // 
            // lbFindings
            // 
            lbFindings.FormattingEnabled = true;
            lbFindings.ItemHeight = 20;
            lbFindings.Location = new Point(12, 116);
            lbFindings.Name = "lbFindings";
            lbFindings.Size = new Size(661, 404);
            lbFindings.TabIndex = 1;
            // 
            // labelFindings
            // 
            labelFindings.AutoSize = true;
            labelFindings.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelFindings.Location = new Point(12, 73);
            labelFindings.Name = "labelFindings";
            labelFindings.Size = new Size(101, 31);
            labelFindings.TabIndex = 2;
            labelFindings.Text = "Findings";
            // 
            // BtnAddFinding
            // 
            BtnAddFinding.Location = new Point(12, 582);
            BtnAddFinding.Name = "BtnAddFinding";
            BtnAddFinding.Size = new Size(128, 37);
            BtnAddFinding.TabIndex = 3;
            BtnAddFinding.Text = "Add finding";
            BtnAddFinding.UseVisualStyleBackColor = true;
            BtnAddFinding.Click += BtnAddFinding_Click;
            // 
            // BtnDeleteFinding
            // 
            BtnDeleteFinding.Location = new Point(545, 582);
            BtnDeleteFinding.Name = "BtnDeleteFinding";
            BtnDeleteFinding.Size = new Size(128, 37);
            BtnDeleteFinding.TabIndex = 4;
            BtnDeleteFinding.Text = "Delete finding";
            BtnDeleteFinding.UseVisualStyleBackColor = true;
            BtnDeleteFinding.Click += BtnDeleteFinding_Click;
            // 
            // BtnShowInfo
            // 
            BtnShowInfo.Location = new Point(276, 582);
            BtnShowInfo.Name = "BtnShowInfo";
            BtnShowInfo.Size = new Size(128, 37);
            BtnShowInfo.TabIndex = 5;
            BtnShowInfo.Text = "Show info";
            BtnShowInfo.UseVisualStyleBackColor = true;
            BtnShowInfo.Click += BtnShowInfo_Click;
            // 
            // CheckListBoxFilter
            // 
            CheckListBoxFilter.CheckOnClick = true;
            CheckListBoxFilter.FormattingEnabled = true;
            CheckListBoxFilter.Location = new Point(688, 116);
            CheckListBoxFilter.Name = "CheckListBoxFilter";
            CheckListBoxFilter.Size = new Size(262, 444);
            CheckListBoxFilter.TabIndex = 6;
            // 
            // BtnFilter
            // 
            BtnFilter.Location = new Point(688, 582);
            BtnFilter.Name = "BtnFilter";
            BtnFilter.Size = new Size(128, 37);
            BtnFilter.TabIndex = 7;
            BtnFilter.Text = "Filter";
            BtnFilter.UseVisualStyleBackColor = true;
            BtnFilter.Click += BtnFilter_Click;
            // 
            // BtnFilterRemove
            // 
            BtnFilterRemove.Location = new Point(822, 582);
            BtnFilterRemove.Name = "BtnFilterRemove";
            BtnFilterRemove.Size = new Size(128, 37);
            BtnFilterRemove.TabIndex = 8;
            BtnFilterRemove.Text = "Remove";
            BtnFilterRemove.UseVisualStyleBackColor = true;
            BtnFilterRemove.Click += BtnFilterRemove_Click;
            // 
            // LabelFilters
            // 
            LabelFilters.AutoSize = true;
            LabelFilters.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelFilters.Location = new Point(688, 73);
            LabelFilters.Name = "LabelFilters";
            LabelFilters.Size = new Size(75, 31);
            LabelFilters.TabIndex = 9;
            LabelFilters.Text = "Filters";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(12, 533);
            textBoxSearch.MaxLength = 60;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search(case sensetive)";
            textBoxSearch.Size = new Size(461, 27);
            textBoxSearch.TabIndex = 10;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(479, 534);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 27);
            buttonSearch.TabIndex = 11;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonClearSearch
            // 
            buttonClearSearch.Location = new Point(579, 532);
            buttonClearSearch.Name = "buttonClearSearch";
            buttonClearSearch.Size = new Size(94, 29);
            buttonClearSearch.TabIndex = 12;
            buttonClearSearch.Text = "Clear";
            buttonClearSearch.UseVisualStyleBackColor = true;
            buttonClearSearch.Click += buttonClearSearch_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 647);
            Controls.Add(buttonClearSearch);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(LabelFilters);
            Controls.Add(BtnFilterRemove);
            Controls.Add(BtnFilter);
            Controls.Add(CheckListBoxFilter);
            Controls.Add(BtnShowInfo);
            Controls.Add(BtnDeleteFinding);
            Controls.Add(BtnAddFinding);
            Controls.Add(labelFindings);
            Controls.Add(lbFindings);
            Controls.Add(labelAppName);
            MaximizeBox = false;
            MaximumSize = new Size(983, 694);
            MinimumSize = new Size(983, 694);
            Name = "FormMain";
            Text = "Lost and Found";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAppName;
        private ListBox lbFindings;
        private Label labelFindings;
        private Button BtnAddFinding;
        private Button BtnDeleteFinding;
        private Button BtnShowInfo;
        private CheckedListBox CheckListBoxFilter;
        private Button BtnFilter;
        private Button BtnFilterRemove;
        private Label LabelFilters;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonClearSearch;
    }
}