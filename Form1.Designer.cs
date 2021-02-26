
namespace HomeworkOne
{
    partial class calu
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.count = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.number_one = new System.Windows.Forms.TextBox();
            this.zero = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multplicate = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.op = new System.Windows.Forms.TextBox();
            this.number_two = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // count
            // 
            this.count.BackColor = System.Drawing.SystemColors.HotTrack;
            this.count.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.count.Location = new System.Drawing.Point(669, 407);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(75, 44);
            this.count.TabIndex = 0;
            this.count.Text = "计算";
            this.count.UseVisualStyleBackColor = false;
            this.count.Click += new System.EventHandler(this.button1_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(139, 107);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(59, 65);
            this.eight.TabIndex = 1;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(253, 107);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(58, 65);
            this.nine.TabIndex = 2;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(35, 107);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(63, 65);
            this.seven.TabIndex = 3;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button4_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(35, 213);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(63, 65);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(139, 213);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(59, 65);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(254, 213);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(57, 65);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(35, 314);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(63, 65);
            this.one.TabIndex = 7;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(139, 314);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(59, 65);
            this.two.TabIndex = 8;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(254, 314);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(57, 65);
            this.three.TabIndex = 9;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // number_one
            // 
            this.number_one.Location = new System.Drawing.Point(35, 44);
            this.number_one.Name = "number_one";
            this.number_one.Size = new System.Drawing.Size(78, 25);
            this.number_one.TabIndex = 10;
            this.number_one.Text = "0";
            this.number_one.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(35, 407);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(63, 65);
            this.zero.TabIndex = 11;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(347, 107);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(58, 65);
            this.add.TabIndex = 14;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(347, 213);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(58, 65);
            this.minus.TabIndex = 15;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multplicate
            // 
            this.multplicate.Location = new System.Drawing.Point(347, 314);
            this.multplicate.Name = "multplicate";
            this.multplicate.Size = new System.Drawing.Size(58, 65);
            this.multplicate.TabIndex = 16;
            this.multplicate.Text = "*";
            this.multplicate.UseVisualStyleBackColor = true;
            this.multplicate.Click += new System.EventHandler(this.multplicate_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(347, 407);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(58, 61);
            this.divide.TabIndex = 17;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(527, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "清零";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // op
            // 
            this.op.Location = new System.Drawing.Point(158, 44);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(30, 25);
            this.op.TabIndex = 19;
            // 
            // number_two
            // 
            this.number_two.Location = new System.Drawing.Point(253, 43);
            this.number_two.Name = "number_two";
            this.number_two.Size = new System.Drawing.Size(82, 25);
            this.number_two.TabIndex = 20;
            this.number_two.Text = "0";
            this.number_two.TextChanged += new System.EventHandler(this.number_two_TextChanged);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(433, 43);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 25);
            this.result.TabIndex = 21;
            this.result.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "第一个数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "运算符";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "第二数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "结果";
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(139, 411);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(59, 61);
            this.point.TabIndex = 26;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // calu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.point);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.number_two);
            this.Controls.Add(this.op);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multplicate);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.add);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.number_one);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.count);
            this.Name = "calu";
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button count;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.TextBox number_one;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multplicate;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox op;
        private System.Windows.Forms.TextBox number_two;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button point;
    }
}

