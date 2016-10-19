namespace NetworkRouting
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
            this.randomSeedBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.seedUsedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.solveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceNodeBox = new System.Windows.Forms.TextBox();
            this.targetNodeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pathCostBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.arrayTimeBox = new System.Windows.Forms.TextBox();
            this.heapTimeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.differenceBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.arrayCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // randomSeedBox
            // 
            this.randomSeedBox.Location = new System.Drawing.Point(94, 318);
            this.randomSeedBox.Name = "randomSeedBox";
            this.randomSeedBox.Size = new System.Drawing.Size(100, 20);
            this.randomSeedBox.TabIndex = 1;
            this.randomSeedBox.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.Text = "Random Seed";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(338, 315);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(16, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(600, 300);
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // seedUsedLabel
            // 
            this.seedUsedLabel.AutoSize = true;
            this.seedUsedLabel.Location = new System.Drawing.Point(483, 352);
            this.seedUsedLabel.Name = "seedUsedLabel";
            this.seedUsedLabel.Size = new System.Drawing.Size(133, 13);
            this.seedUsedLabel.Text = "Random Seed Used: none";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.Text = "Size";
            // 
            // sizeBox
            // 
            this.sizeBox.Location = new System.Drawing.Point(232, 318);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(100, 20);
            this.sizeBox.TabIndex = 2;
            this.sizeBox.Text = "20";
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(419, 315);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 7;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.Text = "Source Node";
            // 
            // sourceNodeBox
            // 
            this.sourceNodeBox.Location = new System.Drawing.Point(89, 344);
            this.sourceNodeBox.Name = "sourceNodeBox";
            this.sourceNodeBox.Size = new System.Drawing.Size(70, 20);
            this.sourceNodeBox.TabIndex = 4;
            this.sourceNodeBox.TextChanged += new System.EventHandler(this.sourceNodeBox_Changed);
            // 
            // targetNodeBox
            // 
            this.targetNodeBox.Location = new System.Drawing.Point(240, 343);
            this.targetNodeBox.Name = "targetNodeBox";
            this.targetNodeBox.Size = new System.Drawing.Size(70, 20);
            this.targetNodeBox.TabIndex = 5;
            this.targetNodeBox.TextChanged += new System.EventHandler(this.targetNodeBox_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.Text = "Target Node";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.Text = "Total Path Cost";
            // 
            // pathCostBox
            // 
            this.pathCostBox.Enabled = false;
            this.pathCostBox.Location = new System.Drawing.Point(410, 344);
            this.pathCostBox.Name = "pathCostBox";
            this.pathCostBox.Size = new System.Drawing.Size(67, 20);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(13, 373);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(74, 13);
            this.timeLabel.Text = "Array Time";
            // 
            // arrayTimeBox
            // 
            this.arrayTimeBox.Enabled = false;
            this.arrayTimeBox.Location = new System.Drawing.Point(89, 370);
            this.arrayTimeBox.Name = "arrayBox";
            this.arrayTimeBox.Size = new System.Drawing.Size(58, 20);
            // 
            // heapTimeBox
            // 
            this.heapTimeBox.Enabled = false;
            this.heapTimeBox.Location = new System.Drawing.Point(237, 370);
            this.heapTimeBox.Name = "heapBox";
            this.heapTimeBox.Size = new System.Drawing.Size(58, 20);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.Text = "Heap Time";
            // 
            // differenceBox
            // 
            this.differenceBox.Enabled = false;
            this.differenceBox.Location = new System.Drawing.Point(385, 370);
            this.differenceBox.Name = "differenceBox";
            this.differenceBox.Size = new System.Drawing.Size(58, 20);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.Text = "X Speedup";
            // 
            // arrayCheckBox
            // 
            this.arrayCheckBox.Enabled = true;
            this.arrayCheckBox.Location = new System.Drawing.Point(600, 315);
            this.arrayCheckBox.Name = "arrayCheckBox";
            this.arrayCheckBox.Size = new System.Drawing.Size(15, 15);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(520, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.Text = "Compare Array";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 392);
            this.Controls.Add(this.arrayCheckBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.differenceBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.heapTimeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.arrayTimeBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.pathCostBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.targetNodeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sourceNodeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.seedUsedLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomSeedBox);
            this.Name = "Network Routing";
            this.Text = "Network Routing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox randomSeedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label seedUsedLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sizeBox;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sourceNodeBox;
        private System.Windows.Forms.TextBox targetNodeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pathCostBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox arrayTimeBox;
        private System.Windows.Forms.TextBox heapTimeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox differenceBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox arrayCheckBox;
        private System.Windows.Forms.Label label8;
    }
}

