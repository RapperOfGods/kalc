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
            this.button1 = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.sec = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.sqr = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.cosec = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplication.Location = new System.Drawing.Point(44, 124);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(46, 23);
            this.multiplication.TabIndex = 0;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.MathOperationForTwoArguments);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.Location = new System.Drawing.Point(109, 123);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(46, 23);
            this.division.TabIndex = 1;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.MathOperationForTwoArguments);
            // 
            // subraction
            // 
            this.subraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subraction.Location = new System.Drawing.Point(44, 166);
            this.subraction.Name = "subraction";
            this.subraction.Size = new System.Drawing.Size(46, 23);
            this.subraction.TabIndex = 2;
            this.subraction.Text = "-";
            this.subraction.UseVisualStyleBackColor = true;
            this.subraction.Click += new System.EventHandler(this.MathOperationForTwoArguments);
            // 
            // addition
            // 
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addition.Location = new System.Drawing.Point(109, 165);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(46, 23);
            this.addition.TabIndex = 3;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.MathOperationForTwoArguments);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(178, 124);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(46, 23);
            this.cos.TabIndex = 8;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.MathOperationForOneArguments);
            // 
            // sec
            // 
            this.sec.Location = new System.Drawing.Point(178, 165);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(46, 23);
            this.sec.TabIndex = 9;
            this.sec.Text = "sec";
            this.sec.UseVisualStyleBackColor = true;
            this.sec.Click += new System.EventHandler(this.MathOperationForOneArguments);
            // 
            // pow
            // 
            this.pow.Location = new System.Drawing.Point(43, 246);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(46, 23);
            this.pow.TabIndex = 11;
            this.pow.Text = "pow";
            this.pow.UseVisualStyleBackColor = true;
            this.pow.Click += new System.EventHandler(this.MathOperationForTwoArguments);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(43, 205);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(46, 23);
            this.max.TabIndex = 10;
            this.max.Text = "max";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.MathOperationForTwoArguments);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(109, 245);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(46, 23);
            this.sqrt.TabIndex = 13;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.MathOperationForOneArguments);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(109, 204);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(46, 23);
            this.min.TabIndex = 12;
            this.min.Text = "min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.MathOperationForTwoArguments);
            // 
            // sqr
            // 
            this.sqr.Location = new System.Drawing.Point(178, 245);
            this.sqr.Name = "sqr";
            this.sqr.Size = new System.Drawing.Size(46, 23);
            this.sqr.TabIndex = 15;
            this.sqr.Text = "sqr";
            this.sqr.UseVisualStyleBackColor = true;
            this.sqr.Click += new System.EventHandler(this.MathOperationForOneArguments);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(178, 204);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(46, 23);
            this.log.TabIndex = 14;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.MathOperationForTwoArguments);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(243, 246);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(46, 23);
            this.exp.TabIndex = 19;
            this.exp.Text = "exp";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.MathOperationForOneArguments);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(243, 205);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(46, 23);
            this.ln.TabIndex = 18;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.MathOperationForOneArguments);
            // 
            // cosec
            // 
            this.cosec.Location = new System.Drawing.Point(243, 166);
            this.cosec.Name = "cosec";
            this.cosec.Size = new System.Drawing.Size(46, 23);
            this.cosec.TabIndex = 17;
            this.cosec.Text = "cosec";
            this.cosec.UseVisualStyleBackColor = true;
            this.cosec.Click += new System.EventHandler(this.MathOperationForOneArguments);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(243, 125);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(46, 23);
            this.sin.TabIndex = 16;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.MathOperationForOneArguments);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 291);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.cosec);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.sqr);
            this.Controls.Add(this.log);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.min);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.max);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button sec;
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button sqr;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button cosec;
        private System.Windows.Forms.Button sin;
    }
}

