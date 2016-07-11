namespace kalc
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
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.subraction = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.arg1 = new System.Windows.Forms.TextBox();
            this.arg2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplication.Location = new System.Drawing.Point(72, 136);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(75, 23);
            this.multiplication.TabIndex = 0;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.Location = new System.Drawing.Point(169, 136);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 1;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // subraction
            // 
            this.subraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subraction.Location = new System.Drawing.Point(72, 178);
            this.subraction.Name = "subraction";
            this.subraction.Size = new System.Drawing.Size(75, 23);
            this.subraction.TabIndex = 2;
            this.subraction.Text = "-";
            this.subraction.UseVisualStyleBackColor = true;
            this.subraction.Click += new System.EventHandler(this.subraction_Click);
            // 
            // addition
            // 
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addition.Location = new System.Drawing.Point(169, 178);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 23);
            this.addition.TabIndex = 3;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // arg1
            // 
            this.arg1.Location = new System.Drawing.Point(28, 31);
            this.arg1.Name = "arg1";
            this.arg1.Size = new System.Drawing.Size(274, 20);
            this.arg1.TabIndex = 4;
            // 
            // arg2
            // 
            this.arg2.Location = new System.Drawing.Point(28, 57);
            this.arg2.Name = "arg2";
            this.arg2.Size = new System.Drawing.Size(274, 20);
            this.arg2.TabIndex = 5;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(28, 99);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(274, 20);
            this.result.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 213);
            this.Controls.Add(this.result);
            this.Controls.Add(this.arg2);
            this.Controls.Add(this.arg1);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.subraction);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Name = "MainForm";
            this.Text = "kalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button subraction;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.TextBox arg1;
        private System.Windows.Forms.TextBox arg2;
        private System.Windows.Forms.TextBox result;
    }
}

