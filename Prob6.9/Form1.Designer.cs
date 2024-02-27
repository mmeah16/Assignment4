namespace Prob6._9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rockPictureBox = new System.Windows.Forms.PictureBox();
            this.paperPictureBox = new System.Windows.Forms.PictureBox();
            this.scissorsPictureBox = new System.Windows.Forms.PictureBox();
            this.computerChoiceLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rockPictureBox
            // 
            this.rockPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rockPictureBox.BackgroundImage")));
            this.rockPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("rockPictureBox.Image")));
            this.rockPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("rockPictureBox.InitialImage")));
            this.rockPictureBox.Location = new System.Drawing.Point(80, 62);
            this.rockPictureBox.Name = "rockPictureBox";
            this.rockPictureBox.Size = new System.Drawing.Size(185, 164);
            this.rockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rockPictureBox.TabIndex = 0;
            this.rockPictureBox.TabStop = false;
            this.rockPictureBox.Click += new System.EventHandler(this.rockPictureBox_Click);
            // 
            // paperPictureBox
            // 
            this.paperPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("paperPictureBox.Image")));
            this.paperPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("paperPictureBox.InitialImage")));
            this.paperPictureBox.Location = new System.Drawing.Point(310, 62);
            this.paperPictureBox.Name = "paperPictureBox";
            this.paperPictureBox.Size = new System.Drawing.Size(180, 164);
            this.paperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paperPictureBox.TabIndex = 1;
            this.paperPictureBox.TabStop = false;
            this.paperPictureBox.Click += new System.EventHandler(this.paperPictureBox_Click);
            // 
            // scissorsPictureBox
            // 
            this.scissorsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("scissorsPictureBox.Image")));
            this.scissorsPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("scissorsPictureBox.InitialImage")));
            this.scissorsPictureBox.Location = new System.Drawing.Point(536, 62);
            this.scissorsPictureBox.Name = "scissorsPictureBox";
            this.scissorsPictureBox.Size = new System.Drawing.Size(180, 164);
            this.scissorsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scissorsPictureBox.TabIndex = 2;
            this.scissorsPictureBox.TabStop = false;
            this.scissorsPictureBox.Click += new System.EventHandler(this.scissorsPictureBox_Click);
            // 
            // computerChoiceLabel
            // 
            this.computerChoiceLabel.AutoSize = true;
            this.computerChoiceLabel.Location = new System.Drawing.Point(80, 252);
            this.computerChoiceLabel.Name = "computerChoiceLabel";
            this.computerChoiceLabel.Size = new System.Drawing.Size(184, 25);
            this.computerChoiceLabel.TabIndex = 3;
            this.computerChoiceLabel.Text = "Computer Choice:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(87, 296);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 25);
            this.resultLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.computerChoiceLabel);
            this.Controls.Add(this.scissorsPictureBox);
            this.Controls.Add(this.paperPictureBox);
            this.Controls.Add(this.rockPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rockPictureBox;
        private System.Windows.Forms.PictureBox paperPictureBox;
        private System.Windows.Forms.PictureBox scissorsPictureBox;
        private System.Windows.Forms.Label computerChoiceLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

