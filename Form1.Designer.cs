namespace Kalkulator
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(12, 12);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(135, 20);
            this.input1.TabIndex = 0;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(12, 38);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(135, 20);
            this.input2.TabIndex = 1;
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(12, 110);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(75, 23);
            this.Sum.TabIndex = 2;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(93, 110);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(75, 23);
            this.Min.TabIndex = 3;
            this.Min.Text = "-";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // Mul
            // 
            this.Mul.Location = new System.Drawing.Point(12, 139);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(75, 23);
            this.Mul.TabIndex = 4;
            this.Mul.Text = "*";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(93, 139);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(75, 23);
            this.Div.TabIndex = 5;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(12, 75);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 13);
            this.Answer.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 199);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Label Answer;
    }
}

