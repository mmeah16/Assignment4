namespace Prob7._10
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxImage1 = new System.Windows.Forms.PictureBox();
            this.pbxImage2 = new System.Windows.Forms.PictureBox();
            this.pbxImage3 = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.txtAmountInserted = new System.Windows.Forms.TextBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.imgPictures = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImage1
            // 
            this.pbxImage1.Image = ((System.Drawing.Image)(resources.GetObject("pbxImage1.Image")));
            this.pbxImage1.InitialImage = null;
            this.pbxImage1.Location = new System.Drawing.Point(27, 23);
            this.pbxImage1.Name = "pbxImage1";
            this.pbxImage1.Size = new System.Drawing.Size(129, 125);
            this.pbxImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage1.TabIndex = 0;
            this.pbxImage1.TabStop = false;
            // 
            // pbxImage2
            // 
            this.pbxImage2.Image = global::Prob7._10.Properties.Resources.Orange;
            this.pbxImage2.Location = new System.Drawing.Point(178, 23);
            this.pbxImage2.Name = "pbxImage2";
            this.pbxImage2.Size = new System.Drawing.Size(128, 125);
            this.pbxImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage2.TabIndex = 1;
            this.pbxImage2.TabStop = false;
            // 
            // pbxImage3
            // 
            this.pbxImage3.Image = global::Prob7._10.Properties.Resources.Orange;
            this.pbxImage3.Location = new System.Drawing.Point(325, 23);
            this.pbxImage3.Name = "pbxImage3";
            this.pbxImage3.Size = new System.Drawing.Size(128, 125);
            this.pbxImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage3.TabIndex = 2;
            this.pbxImage3.TabStop = false;
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(88, 182);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(120, 29);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "Amount Inserted: $";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAmountInserted
            // 
            this.txtAmountInserted.Location = new System.Drawing.Point(214, 185);
            this.txtAmountInserted.Name = "txtAmountInserted";
            this.txtAmountInserted.Size = new System.Drawing.Size(158, 22);
            this.txtAmountInserted.TabIndex = 4;
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(136, 232);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(94, 29);
            this.btnSpin.TabIndex = 5;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(253, 232);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imgPictures
            // 
            this.imgPictures.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgPictures.ImageStream")));
            this.imgPictures.TransparentColor = System.Drawing.Color.Transparent;
            this.imgPictures.Images.SetKeyName(0, "Apple.jpg");
            this.imgPictures.Images.SetKeyName(1, "Banana.jpg");
            this.imgPictures.Images.SetKeyName(2, "Cherries.jpg");
            this.imgPictures.Images.SetKeyName(3, "Grapes.jpg");
            this.imgPictures.Images.SetKeyName(4, "Lemon.jpg");
            this.imgPictures.Images.SetKeyName(5, "Lime.jpg");
            this.imgPictures.Images.SetKeyName(6, "Orange.jpg");
            this.imgPictures.Images.SetKeyName(7, "Pear.jpg");
            this.imgPictures.Images.SetKeyName(8, "Strawberry.jpg");
            this.imgPictures.Images.SetKeyName(9, "Watermelon.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(490, 283);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.txtAmountInserted);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.pbxImage3);
            this.Controls.Add(this.pbxImage2);
            this.Controls.Add(this.pbxImage1);
            this.Name = "Form1";
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImage1;
        private System.Windows.Forms.PictureBox pbxImage2;
        private System.Windows.Forms.PictureBox pbxImage3;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtAmountInserted;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ImageList imgPictures;
    }
}

