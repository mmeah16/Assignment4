namespace Prob8._4
{
    partial class Form1
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
            this.userText = new System.Windows.Forms.TextBox();
            this.vowelConsonantGroupBox = new System.Windows.Forms.GroupBox();
            this.vowelLabel = new System.Windows.Forms.Label();
            this.consonantLabel = new System.Windows.Forms.Label();
            this.consonantCountLabel = new System.Windows.Forms.Label();
            this.vowelCountLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.vowelConsonantGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(85, 74);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(227, 20);
            this.userText.TabIndex = 0;
            this.userText.Text = "Input a string";
            this.userText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userText.TextChanged += new System.EventHandler(this.calculateButton_Click);
            // 
            // vowelConsonantGroupBox
            // 
            this.vowelConsonantGroupBox.Controls.Add(this.consonantCountLabel);
            this.vowelConsonantGroupBox.Controls.Add(this.vowelCountLabel);
            this.vowelConsonantGroupBox.Controls.Add(this.consonantLabel);
            this.vowelConsonantGroupBox.Controls.Add(this.vowelLabel);
            this.vowelConsonantGroupBox.Location = new System.Drawing.Point(85, 257);
            this.vowelConsonantGroupBox.Name = "vowelConsonantGroupBox";
            this.vowelConsonantGroupBox.Size = new System.Drawing.Size(227, 100);
            this.vowelConsonantGroupBox.TabIndex = 2;
            this.vowelConsonantGroupBox.TabStop = false;
            this.vowelConsonantGroupBox.Text = "Vowel and Consonants";
            // 
            // vowelLabel
            // 
            this.vowelLabel.AutoSize = true;
            this.vowelLabel.Location = new System.Drawing.Point(34, 29);
            this.vowelLabel.Name = "vowelLabel";
            this.vowelLabel.Size = new System.Drawing.Size(44, 13);
            this.vowelLabel.TabIndex = 0;
            this.vowelLabel.Text = "Vowels:";
            this.vowelLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // consonantLabel
            // 
            this.consonantLabel.AutoSize = true;
            this.consonantLabel.Location = new System.Drawing.Point(12, 61);
            this.consonantLabel.Name = "consonantLabel";
            this.consonantLabel.Size = new System.Drawing.Size(66, 13);
            this.consonantLabel.TabIndex = 1;
            this.consonantLabel.Text = "Consonants:";
            this.consonantLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // consonantCountLabel
            // 
            this.consonantCountLabel.AutoSize = true;
            this.consonantCountLabel.Location = new System.Drawing.Point(84, 61);
            this.consonantCountLabel.Name = "consonantCountLabel";
            this.consonantCountLabel.Size = new System.Drawing.Size(0, 13);
            this.consonantCountLabel.TabIndex = 3;
            // 
            // vowelCountLabel
            // 
            this.vowelCountLabel.AutoSize = true;
            this.vowelCountLabel.Location = new System.Drawing.Point(84, 29);
            this.vowelCountLabel.Name = "vowelCountLabel";
            this.vowelCountLabel.Size = new System.Drawing.Size(0, 13);
            this.vowelCountLabel.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(156, 172);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Visible = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(156, 393);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 449);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.vowelConsonantGroupBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.userText);
            this.Name = "Form1";
            this.Text = "Vowels and Consonants";
            this.vowelConsonantGroupBox.ResumeLayout(false);
            this.vowelConsonantGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.GroupBox vowelConsonantGroupBox;
        private System.Windows.Forms.Label consonantLabel;
        private System.Windows.Forms.Label vowelLabel;
        private System.Windows.Forms.Label consonantCountLabel;
        private System.Windows.Forms.Label vowelCountLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button closeButton;
    }
}

