namespace test
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
            this.button1 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.rd_male = new System.Windows.Forms.RadioButton();
            this.rd_female = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(168, 132);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 20);
            this.Result.TabIndex = 3;
            // 
            // rd_male
            // 
            this.rd_male.AutoSize = true;
            this.rd_male.Location = new System.Drawing.Point(67, 28);
            this.rd_male.Name = "rd_male";
            this.rd_male.Size = new System.Drawing.Size(68, 24);
            this.rd_male.TabIndex = 4;
            this.rd_male.TabStop = true;
            this.rd_male.Text = "Male";
            this.rd_male.UseVisualStyleBackColor = true;
            // 
            // rd_female
            // 
            this.rd_female.AutoSize = true;
            this.rd_female.Location = new System.Drawing.Point(67, 68);
            this.rd_female.Name = "rd_female";
            this.rd_female.Size = new System.Drawing.Size(87, 24);
            this.rd_female.TabIndex = 5;
            this.rd_female.TabStop = true;
            this.rd_female.Text = "Female";
            this.rd_female.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 308);
            this.Controls.Add(this.rd_female);
            this.Controls.Add(this.rd_male);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.RadioButton rd_male;
        private System.Windows.Forms.RadioButton rd_female;
    }
}

