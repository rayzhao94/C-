namespace x_y
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Newton = new System.Windows.Forms.RadioButton();
            this.radioButton_Simpson = new System.Windows.Forms.RadioButton();
            this.radioButton_Taylor = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(29, 107);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(109, 21);
            this.textBox_X.TabIndex = 2;
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(183, 104);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(109, 21);
            this.textBox_Y.TabIndex = 3;
            // 
            // textBox_answer
            // 
            this.textBox_answer.Location = new System.Drawing.Point(87, 189);
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.Size = new System.Drawing.Size(173, 21);
            this.textBox_answer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "answer";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(111, 225);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Newton);
            this.groupBox1.Controls.Add(this.radioButton_Simpson);
            this.groupBox1.Controls.Add(this.radioButton_Taylor);
            this.groupBox1.Location = new System.Drawing.Point(87, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 89);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "方法";
            // 
            // radioButton_Newton
            // 
            this.radioButton_Newton.AutoSize = true;
            this.radioButton_Newton.Location = new System.Drawing.Point(16, 64);
            this.radioButton_Newton.Name = "radioButton_Newton";
            this.radioButton_Newton.Size = new System.Drawing.Size(71, 16);
            this.radioButton_Newton.TabIndex = 11;
            this.radioButton_Newton.TabStop = true;
            this.radioButton_Newton.Text = "Newton法";
            this.radioButton_Newton.UseVisualStyleBackColor = true;
            // 
            // radioButton_Simpson
            // 
            this.radioButton_Simpson.AutoSize = true;
            this.radioButton_Simpson.Location = new System.Drawing.Point(16, 42);
            this.radioButton_Simpson.Name = "radioButton_Simpson";
            this.radioButton_Simpson.Size = new System.Drawing.Size(113, 16);
            this.radioButton_Simpson.TabIndex = 9;
            this.radioButton_Simpson.TabStop = true;
            this.radioButton_Simpson.Text = "复化Simpson公式";
            this.radioButton_Simpson.UseVisualStyleBackColor = true;
            // 
            // radioButton_Taylor
            // 
            this.radioButton_Taylor.AutoSize = true;
            this.radioButton_Taylor.Location = new System.Drawing.Point(16, 20);
            this.radioButton_Taylor.Name = "radioButton_Taylor";
            this.radioButton_Taylor.Size = new System.Drawing.Size(83, 16);
            this.radioButton_Taylor.TabIndex = 8;
            this.radioButton_Taylor.TabStop = true;
            this.radioButton_Taylor.Text = "Taylor展开";
            this.radioButton_Taylor.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.TextBox textBox_answer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Taylor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton_Simpson;
        private System.Windows.Forms.RadioButton radioButton_Newton;
    }
}

