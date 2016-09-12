namespace Lab1
{
    partial class is_prime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(is_prime));
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.k_value = new System.Windows.Forms.TextBox();
            this.solve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(22, 77);
            this.input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(120, 37);
            this.input.TabIndex = 0;
            this.input.Text = "very input";
            this.input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(117, 23);
            this.output.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(275, 26);
            this.output.TabIndex = 1;
            this.output.Text = "impress output";
            this.output.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // k_value
            // 
            this.k_value.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k_value.Location = new System.Drawing.Point(212, 280);
            this.k_value.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.k_value.Name = "k_value";
            this.k_value.Size = new System.Drawing.Size(126, 37);
            this.k_value.TabIndex = 2;
            this.k_value.Text = "k value";
            // 
            // solve
            // 
            this.solve.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solve.Location = new System.Drawing.Point(2, 169);
            this.solve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(140, 44);
            this.solve.TabIndex = 3;
            this.solve.Text = "solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // is_prime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(396, 396);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.k_value);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "is_prime";
            this.Text = "is prime?";
            this.Load += new System.EventHandler(this.is_prime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox k_value;
        private System.Windows.Forms.Button solve;
    }
}

