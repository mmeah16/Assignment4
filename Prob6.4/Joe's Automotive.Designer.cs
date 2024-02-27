namespace Prob6._4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lubeJobCheckBox = new System.Windows.Forms.CheckBox();
            this.oilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.transmissionFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorCheckBox = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalFeesTextBox = new System.Windows.Forms.TextBox();
            this.taxCostTextBox = new System.Windows.Forms.TextBox();
            this.partsCostTextBox = new System.Windows.Forms.TextBox();
            this.serviceCostTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceMufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.tireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lubeJobCheckBox);
            this.panel1.Controls.Add(this.oilChangeCheckBox);
            this.panel1.Location = new System.Drawing.Point(41, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 164);
            this.panel1.TabIndex = 0;
            // 
            // lubeJobCheckBox
            // 
            this.lubeJobCheckBox.AutoSize = true;
            this.lubeJobCheckBox.Location = new System.Drawing.Point(17, 76);
            this.lubeJobCheckBox.Name = "lubeJobCheckBox";
            this.lubeJobCheckBox.Size = new System.Drawing.Size(189, 29);
            this.lubeJobCheckBox.TabIndex = 9;
            this.lubeJobCheckBox.Text = "Lube Job ($40)";
            this.lubeJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // oilChangeCheckBox
            // 
            this.oilChangeCheckBox.AutoSize = true;
            this.oilChangeCheckBox.Location = new System.Drawing.Point(17, 35);
            this.oilChangeCheckBox.Name = "oilChangeCheckBox";
            this.oilChangeCheckBox.Size = new System.Drawing.Size(207, 29);
            this.oilChangeCheckBox.TabIndex = 0;
            this.oilChangeCheckBox.Text = "Oil Change ($50)";
            this.oilChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.transmissionFlushCheckBox);
            this.panel2.Controls.Add(this.radiatorCheckBox);
            this.panel2.Location = new System.Drawing.Point(378, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 164);
            this.panel2.TabIndex = 1;
            // 
            // transmissionFlushCheckBox
            // 
            this.transmissionFlushCheckBox.AutoSize = true;
            this.transmissionFlushCheckBox.Location = new System.Drawing.Point(10, 76);
            this.transmissionFlushCheckBox.Name = "transmissionFlushCheckBox";
            this.transmissionFlushCheckBox.Size = new System.Drawing.Size(299, 29);
            this.transmissionFlushCheckBox.TabIndex = 11;
            this.transmissionFlushCheckBox.Text = "Transmission Flush ($120)";
            this.transmissionFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiatorCheckBox
            // 
            this.radiatorCheckBox.AutoSize = true;
            this.radiatorCheckBox.Location = new System.Drawing.Point(10, 35);
            this.radiatorCheckBox.Name = "radiatorCheckBox";
            this.radiatorCheckBox.Size = new System.Drawing.Size(252, 29);
            this.radiatorCheckBox.TabIndex = 10;
            this.radiatorCheckBox.Text = "Radiator Flush ($100)";
            this.radiatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.laborTextBox);
            this.panel4.Controls.Add(this.partsTextBox);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(378, 234);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(315, 155);
            this.panel4.TabIndex = 3;
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(163, 78);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(121, 31);
            this.laborTextBox.TabIndex = 11;
            this.laborTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(163, 34);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(121, 31);
            this.partsTextBox.TabIndex = 10;
            this.partsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Labor (Hours):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Parts:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Oil and Lube";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Flushes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Misc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parts and Labor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalFeesTextBox);
            this.groupBox1.Controls.Add(this.taxCostTextBox);
            this.groupBox1.Controls.Add(this.partsCostTextBox);
            this.groupBox1.Controls.Add(this.serviceCostTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(41, 441);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 293);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // totalFeesTextBox
            // 
            this.totalFeesTextBox.Location = new System.Drawing.Point(287, 212);
            this.totalFeesTextBox.Name = "totalFeesTextBox";
            this.totalFeesTextBox.Size = new System.Drawing.Size(207, 31);
            this.totalFeesTextBox.TabIndex = 16;
            // 
            // taxCostTextBox
            // 
            this.taxCostTextBox.Location = new System.Drawing.Point(287, 168);
            this.taxCostTextBox.Name = "taxCostTextBox";
            this.taxCostTextBox.Size = new System.Drawing.Size(207, 31);
            this.taxCostTextBox.TabIndex = 15;
            // 
            // partsCostTextBox
            // 
            this.partsCostTextBox.Location = new System.Drawing.Point(287, 122);
            this.partsCostTextBox.Name = "partsCostTextBox";
            this.partsCostTextBox.Size = new System.Drawing.Size(207, 31);
            this.partsCostTextBox.TabIndex = 14;
            // 
            // serviceCostTextBox
            // 
            this.serviceCostTextBox.Location = new System.Drawing.Point(287, 77);
            this.serviceCostTextBox.Name = "serviceCostTextBox";
            this.serviceCostTextBox.Size = new System.Drawing.Size(207, 31);
            this.serviceCostTextBox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Total Fees:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Parts:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Service and Labor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tax (on parts):";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(112, 753);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(157, 38);
            this.calculateBtn.TabIndex = 9;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(292, 753);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(157, 38);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(472, 753);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(157, 38);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(17, 19);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(198, 29);
            this.inspectionCheckBox.TabIndex = 9;
            this.inspectionCheckBox.Text = "Inspection ($35)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceMufflerCheckBox
            // 
            this.replaceMufflerCheckBox.AutoSize = true;
            this.replaceMufflerCheckBox.Location = new System.Drawing.Point(17, 64);
            this.replaceMufflerCheckBox.Name = "replaceMufflerCheckBox";
            this.replaceMufflerCheckBox.Size = new System.Drawing.Size(263, 29);
            this.replaceMufflerCheckBox.TabIndex = 10;
            this.replaceMufflerCheckBox.Text = "Replace Muffler ($150)";
            this.replaceMufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // tireRotationCheckBox
            // 
            this.tireRotationCheckBox.AutoSize = true;
            this.tireRotationCheckBox.Location = new System.Drawing.Point(17, 109);
            this.tireRotationCheckBox.Name = "tireRotationCheckBox";
            this.tireRotationCheckBox.Size = new System.Drawing.Size(223, 29);
            this.tireRotationCheckBox.TabIndex = 11;
            this.tireRotationCheckBox.Text = "Tire Rotation ($25)";
            this.tireRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tireRotationCheckBox);
            this.panel3.Controls.Add(this.replaceMufflerCheckBox);
            this.panel3.Controls.Add(this.inspectionCheckBox);
            this.panel3.Location = new System.Drawing.Point(41, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 155);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 844);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Joe\'s Automotive";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox lubeJobCheckBox;
        private System.Windows.Forms.CheckBox oilChangeCheckBox;
        private System.Windows.Forms.CheckBox transmissionFlushCheckBox;
        private System.Windows.Forms.CheckBox radiatorCheckBox;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox partsCostTextBox;
        private System.Windows.Forms.TextBox serviceCostTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox totalFeesTextBox;
        private System.Windows.Forms.TextBox taxCostTextBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.CheckBox replaceMufflerCheckBox;
        private System.Windows.Forms.CheckBox tireRotationCheckBox;
        private System.Windows.Forms.Panel panel3;
    }
}

