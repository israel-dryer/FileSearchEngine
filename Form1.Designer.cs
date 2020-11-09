namespace FileSearchEngine
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
            this.TermLabel = new System.Windows.Forms.Label();
            this.TermTextBox = new System.Windows.Forms.TextBox();
            this.ContainsRadioButton = new System.Windows.Forms.RadioButton();
            this.StartsWithRadioButton = new System.Windows.Forms.RadioButton();
            this.EndsWithRadioButton = new System.Windows.Forms.RadioButton();
            this.PathLabel = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResultsRichText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TermLabel
            // 
            this.TermLabel.AutoSize = true;
            this.TermLabel.Location = new System.Drawing.Point(28, 26);
            this.TermLabel.Name = "TermLabel";
            this.TermLabel.Size = new System.Drawing.Size(111, 25);
            this.TermLabel.TabIndex = 0;
            this.TermLabel.Text = "Search Term:";
            // 
            // TermTextBox
            // 
            this.TermTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TermTextBox.Location = new System.Drawing.Point(158, 26);
            this.TermTextBox.Name = "TermTextBox";
            this.TermTextBox.Size = new System.Drawing.Size(376, 31);
            this.TermTextBox.TabIndex = 1;
            this.TermTextBox.WordWrap = false;
            // 
            // ContainsRadioButton
            // 
            this.ContainsRadioButton.AutoSize = true;
            this.ContainsRadioButton.Checked = true;
            this.ContainsRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ContainsRadioButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContainsRadioButton.Location = new System.Drawing.Point(554, 29);
            this.ContainsRadioButton.Name = "ContainsRadioButton";
            this.ContainsRadioButton.Size = new System.Drawing.Size(107, 26);
            this.ContainsRadioButton.TabIndex = 2;
            this.ContainsRadioButton.TabStop = true;
            this.ContainsRadioButton.Text = "Contains";
            this.ContainsRadioButton.UseVisualStyleBackColor = true;
            // 
            // StartsWithRadioButton
            // 
            this.StartsWithRadioButton.AutoSize = true;
            this.StartsWithRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartsWithRadioButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartsWithRadioButton.Location = new System.Drawing.Point(656, 29);
            this.StartsWithRadioButton.Name = "StartsWithRadioButton";
            this.StartsWithRadioButton.Size = new System.Drawing.Size(118, 26);
            this.StartsWithRadioButton.TabIndex = 3;
            this.StartsWithRadioButton.Text = "StartsWith";
            this.StartsWithRadioButton.UseVisualStyleBackColor = true;
            // 
            // EndsWithRadioButton
            // 
            this.EndsWithRadioButton.AutoSize = true;
            this.EndsWithRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EndsWithRadioButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EndsWithRadioButton.Location = new System.Drawing.Point(770, 29);
            this.EndsWithRadioButton.Name = "EndsWithRadioButton";
            this.EndsWithRadioButton.Size = new System.Drawing.Size(112, 26);
            this.EndsWithRadioButton.TabIndex = 4;
            this.EndsWithRadioButton.Text = "EndsWith";
            this.EndsWithRadioButton.UseVisualStyleBackColor = true;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(28, 72);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(93, 25);
            this.PathLabel.TabIndex = 5;
            this.PathLabel.Text = "Root Path:";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathTextBox.Location = new System.Drawing.Point(158, 72);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(376, 31);
            this.PathTextBox.TabIndex = 6;
            this.PathTextBox.WordWrap = false;
            // 
            // BrowseButton
            // 
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BrowseButton.Location = new System.Drawing.Point(544, 72);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(155, 34);
            this.BrowseButton.TabIndex = 7;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchButton.Location = new System.Drawing.Point(705, 72);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(160, 34);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ResultsRichText
            // 
            this.ResultsRichText.Location = new System.Drawing.Point(28, 122);
            this.ResultsRichText.Name = "ResultsRichText";
            this.ResultsRichText.ReadOnly = true;
            this.ResultsRichText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ResultsRichText.Size = new System.Drawing.Size(841, 336);
            this.ResultsRichText.TabIndex = 10;
            this.ResultsRichText.Text = "";
            this.ResultsRichText.WordWrap = false;
            this.ResultsRichText.TextChanged += new System.EventHandler(this.ResultsRichText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 478);
            this.Controls.Add(this.EndsWithRadioButton);
            this.Controls.Add(this.StartsWithRadioButton);
            this.Controls.Add(this.ContainsRadioButton);
            this.Controls.Add(this.ResultsRichText);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.TermTextBox);
            this.Controls.Add(this.TermLabel);
            this.Name = "Form1";
            this.Text = "File Search Engine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TermLabel;
        private System.Windows.Forms.TextBox TermTextBox;
        private System.Windows.Forms.RadioButton ContainsRadioButton;
        private System.Windows.Forms.RadioButton StartsWithRadioButton;
        private System.Windows.Forms.RadioButton EndsWithRadioButton;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RichTextBox ResultsRichText;
    }
}

