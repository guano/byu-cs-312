namespace GeneticsLab
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bandCheckBox = new System.Windows.Forms.CheckBox();
            this.bandlengthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.file1Box = new System.Windows.Forms.TextBox();
            this.sequence1Box = new System.Windows.Forms.TextBox();
            this.sequence2Box = new System.Windows.Forms.TextBox();
            this.file2Box = new System.Windows.Forms.TextBox();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.processButton = new System.Windows.Forms.ToolStripButton();
            this.clearButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(12, 28);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.ReadOnly = true;
            this.dataGridViewResults.Size = new System.Drawing.Size(855, 463);
            this.dataGridViewResults.TabIndex = 0;
            this.dataGridViewResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_Click);

            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(879, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusMessage
            // 
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.processButton, this.clearButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(879, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            // 
            // processButton
            // 
            this.processButton.BackColor = System.Drawing.Color.Green;
            this.processButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.processButton.ImageTransparentColor = System.Drawing.Color.Green;
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(48, 22);
            this.processButton.Text = "Process";
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Orange;
            this.clearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clearButton.ImageTransparentColor = System.Drawing.Color.Orange;
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(48, 22);
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.Text = "File1 Name:";
            // 
            // file1Box
            // 
            this.file1Box.Enabled = false;
            this.file1Box.Location = new System.Drawing.Point(115, 310);
            this.file1Box.Name = "file1Box";
            this.file1Box.Size = new System.Drawing.Size(500, 15);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.Text = "Sequence1:";
            // 
            // sequence1Box
            // 
            this.sequence1Box.Enabled = false;
            this.sequence1Box.Location = new System.Drawing.Point(115, 340);
            this.sequence1Box.Name = "sequence1Box";
            this.sequence1Box.Font = new System.Drawing.Font("Courier New", 9);
            this.sequence1Box.Size = new System.Drawing.Size(730, 15);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.Text = "Sequence2:";
            //
            // sequence2Box
            //  
            this.sequence2Box.Enabled = false;
            this.sequence2Box.Location = new System.Drawing.Point(115, 370);
            this.sequence2Box.Name = "sequence2Box";
            this.sequence2Box.Font = new System.Drawing.Font("Courier New", 9);
            this.sequence2Box.Size = new System.Drawing.Size(730, 15);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.Text = "File2 Name:";
            //
            // file2Box
            // 
            this.file2Box.Enabled = false;
            this.file2Box.Location = new System.Drawing.Point(115, 400);
            this.file2Box.Name = "file1Box";
            this.file2Box.Size = new System.Drawing.Size(500, 15);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.Text = "Align Length:";
            // 
            // bandlengthBox
            // 
            this.bandlengthBox.Enabled = true;
            this.bandlengthBox.Location = new System.Drawing.Point(700, 175);
            this.bandlengthBox.Name = "bandlengthBox";
            this.bandlengthBox.Size = new System.Drawing.Size(75, 20);
            this.bandlengthBox.Text = "5000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.Text = "Banded:";
            // 
            // bandCheckBox
            // 
            this.bandCheckBox.Enabled = true;
            this.bandCheckBox.Location = new System.Drawing.Point(700, 150);
            this.bandCheckBox.Name = "bandCheckBox";
            this.bandCheckBox.Size = new System.Drawing.Size(15, 15);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 516);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bandlengthBox);
            this.Controls.Add(this.bandCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.file1Box);
            this.Controls.Add(this.sequence1Box);
            this.Controls.Add(this.sequence2Box);
            this.Controls.Add(this.file2Box);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridViewResults);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Gene Sequence Alignment";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //added four labels, four textboxes for displaying results for clicked cells, a checkbox and another textbox for doing banded processing, and a clear button
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusMessage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton processButton;
        private System.Windows.Forms.ToolStripButton clearButton;
        private System.Windows.Forms.TextBox file1Box;
        private System.Windows.Forms.TextBox sequence1Box;
        private System.Windows.Forms.TextBox sequence2Box;
        private System.Windows.Forms.TextBox file2Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox bandCheckBox;
        private System.Windows.Forms.TextBox bandlengthBox;
    }
}

