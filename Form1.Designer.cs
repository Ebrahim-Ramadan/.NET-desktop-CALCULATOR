namespace CALCULATOR
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.equal = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.over = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.pi = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.equal, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.dot, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.zero, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.times, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.over, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.backspace, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.minus, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.e, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ln, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.clear, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.seven, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.eight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nine, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.two, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.five, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.one, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.four, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.three, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.six, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 331);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // equal
            // 
            this.equal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(213, 267);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(66, 61);
            this.equal.TabIndex = 19;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // dot
            // 
            this.dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(143, 267);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(64, 61);
            this.dot.TabIndex = 18;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // zero
            // 
            this.zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(3, 267);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(64, 61);
            this.zero.TabIndex = 16;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // times
            // 
            this.times.Dock = System.Windows.Forms.DockStyle.Fill;
            this.times.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.times.Location = new System.Drawing.Point(213, 135);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(66, 60);
            this.times.TabIndex = 11;
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.times_Click);
            // 
            // over
            // 
            this.over.Dock = System.Windows.Forms.DockStyle.Fill;
            this.over.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.Location = new System.Drawing.Point(213, 69);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(66, 60);
            this.over.TabIndex = 7;
            this.over.Text = "/";
            this.over.UseVisualStyleBackColor = true;
            this.over.Click += new System.EventHandler(this.over_Click);
            // 
            // backspace
            // 
            this.backspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.Location = new System.Drawing.Point(213, 3);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(66, 60);
            this.backspace.TabIndex = 3;
            this.backspace.Text = "+";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // pi
            // 
            this.pi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pi.Location = new System.Drawing.Point(3, 3);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(64, 60);
            this.pi.TabIndex = 0;
            this.pi.Text = "π";
            this.pi.UseVisualStyleBackColor = true;
            this.pi.Click += new System.EventHandler(this.pi_Click);
            // 
            // minus
            // 
            this.minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(213, 201);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(66, 60);
            this.minus.TabIndex = 17;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // e
            // 
            this.e.Dock = System.Windows.Forms.DockStyle.Fill;
            this.e.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(73, 3);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(64, 60);
            this.e.TabIndex = 12;
            this.e.Text = "e";
            this.e.UseVisualStyleBackColor = true;
            this.e.Click += new System.EventHandler(this.e_Click);
            // 
            // ln
            // 
            this.ln.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln.Location = new System.Drawing.Point(73, 267);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(64, 61);
            this.ln.TabIndex = 13;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.ln_Click);
            // 
            // clear
            // 
            this.clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(143, 3);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(64, 60);
            this.clear.TabIndex = 14;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // seven
            // 
            this.seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(3, 69);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(64, 60);
            this.seven.TabIndex = 15;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button16_Click);
            // 
            // eight
            // 
            this.eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(73, 69);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(64, 60);
            this.eight.TabIndex = 1;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(143, 69);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(64, 60);
            this.nine.TabIndex = 2;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // two
            // 
            this.two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(73, 201);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(64, 60);
            this.two.TabIndex = 9;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // five
            // 
            this.five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(73, 135);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(64, 60);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // one
            // 
            this.one.Dock = System.Windows.Forms.DockStyle.Fill;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(3, 201);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(64, 60);
            this.one.TabIndex = 8;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // four
            // 
            this.four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(3, 135);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(64, 60);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // three
            // 
            this.three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(143, 201);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(64, 60);
            this.three.TabIndex = 10;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // six
            // 
            this.six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(143, 135);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(64, 60);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 353);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Form1";
            this.Text = "CALCULATOR";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button over;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button pi;
    }
}

