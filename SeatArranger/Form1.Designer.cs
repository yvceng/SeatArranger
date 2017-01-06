namespace SeatArranger
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbVertical = new System.Windows.Forms.RadioButton();
            this.rbHorizontal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbHMiddle = new System.Windows.Forms.RadioButton();
            this.rbRightLeft = new System.Windows.Forms.RadioButton();
            this.rbLeftRight = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbVMiddle = new System.Windows.Forms.RadioButton();
            this.rbDownUp = new System.Windows.Forms.RadioButton();
            this.rbUpDown = new System.Windows.Forms.RadioButton();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbSpaceLine = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(51, 435);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "开始";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVertical);
            this.groupBox1.Controls.Add(this.rbHorizontal);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主要方向";
            // 
            // rbVertical
            // 
            this.rbVertical.AutoSize = true;
            this.rbVertical.Location = new System.Drawing.Point(39, 55);
            this.rbVertical.Name = "rbVertical";
            this.rbVertical.Size = new System.Drawing.Size(95, 16);
            this.rbVertical.TabIndex = 1;
            this.rbVertical.Text = "先上下后左右";
            this.rbVertical.UseVisualStyleBackColor = true;
            // 
            // rbHorizontal
            // 
            this.rbHorizontal.AutoSize = true;
            this.rbHorizontal.Checked = true;
            this.rbHorizontal.Location = new System.Drawing.Point(39, 33);
            this.rbHorizontal.Name = "rbHorizontal";
            this.rbHorizontal.Size = new System.Drawing.Size(95, 16);
            this.rbHorizontal.TabIndex = 0;
            this.rbHorizontal.TabStop = true;
            this.rbHorizontal.Text = "先左右后上下";
            this.rbHorizontal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbHMiddle);
            this.groupBox2.Controls.Add(this.rbRightLeft);
            this.groupBox2.Controls.Add(this.rbLeftRight);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 87);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "水平方向";
            // 
            // rbHMiddle
            // 
            this.rbHMiddle.AutoSize = true;
            this.rbHMiddle.Location = new System.Drawing.Point(39, 65);
            this.rbHMiddle.Name = "rbHMiddle";
            this.rbHMiddle.Size = new System.Drawing.Size(95, 16);
            this.rbHMiddle.TabIndex = 2;
            this.rbHMiddle.TabStop = true;
            this.rbHMiddle.Text = "先中间后两边";
            this.rbHMiddle.UseVisualStyleBackColor = true;
            // 
            // rbRightLeft
            // 
            this.rbRightLeft.AutoSize = true;
            this.rbRightLeft.Location = new System.Drawing.Point(39, 42);
            this.rbRightLeft.Name = "rbRightLeft";
            this.rbRightLeft.Size = new System.Drawing.Size(83, 16);
            this.rbRightLeft.TabIndex = 1;
            this.rbRightLeft.Text = "从右到左←";
            this.rbRightLeft.UseVisualStyleBackColor = true;
            // 
            // rbLeftRight
            // 
            this.rbLeftRight.AutoSize = true;
            this.rbLeftRight.Checked = true;
            this.rbLeftRight.Location = new System.Drawing.Point(39, 20);
            this.rbLeftRight.Name = "rbLeftRight";
            this.rbLeftRight.Size = new System.Drawing.Size(83, 16);
            this.rbLeftRight.TabIndex = 0;
            this.rbLeftRight.TabStop = true;
            this.rbLeftRight.Text = "从左到右→";
            this.rbLeftRight.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbVMiddle);
            this.groupBox3.Controls.Add(this.rbDownUp);
            this.groupBox3.Controls.Add(this.rbUpDown);
            this.groupBox3.Location = new System.Drawing.Point(12, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 87);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "垂直方向";
            // 
            // rbVMiddle
            // 
            this.rbVMiddle.AutoSize = true;
            this.rbVMiddle.Location = new System.Drawing.Point(39, 65);
            this.rbVMiddle.Name = "rbVMiddle";
            this.rbVMiddle.Size = new System.Drawing.Size(95, 16);
            this.rbVMiddle.TabIndex = 2;
            this.rbVMiddle.TabStop = true;
            this.rbVMiddle.Text = "先中间后两边";
            this.rbVMiddle.UseVisualStyleBackColor = true;
            // 
            // rbDownUp
            // 
            this.rbDownUp.AutoSize = true;
            this.rbDownUp.Location = new System.Drawing.Point(39, 41);
            this.rbDownUp.Name = "rbDownUp";
            this.rbDownUp.Size = new System.Drawing.Size(83, 16);
            this.rbDownUp.TabIndex = 1;
            this.rbDownUp.Text = "从下到上↑";
            this.rbDownUp.UseVisualStyleBackColor = true;
            // 
            // rbUpDown
            // 
            this.rbUpDown.AutoSize = true;
            this.rbUpDown.Checked = true;
            this.rbUpDown.Location = new System.Drawing.Point(39, 19);
            this.rbUpDown.Name = "rbUpDown";
            this.rbUpDown.Size = new System.Drawing.Size(83, 16);
            this.rbUpDown.TabIndex = 0;
            this.rbUpDown.TabStop = true;
            this.rbUpDown.Text = "从上到下↓";
            this.rbUpDown.UseVisualStyleBackColor = true;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(224, 25);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(127, 455);
            this.tbInput.TabIndex = 3;
            this.tbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbOutput_KeyDown);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(384, 25);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(470, 455);
            this.tbOutput.TabIndex = 4;
            this.tbOutput.WordWrap = false;
            this.tbOutput.TextChanged += new System.EventHandler(this.tbOutput_TextChanged);
            this.tbOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbOutput_KeyDown);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(80, 353);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(100, 21);
            this.tbWidth.TabIndex = 5;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(80, 380);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 21);
            this.tbHeight.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "宽";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "高";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(866, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // cbSpaceLine
            // 
            this.cbSpaceLine.AutoSize = true;
            this.cbSpaceLine.Location = new System.Drawing.Point(51, 306);
            this.cbSpaceLine.Name = "cbSpaceLine";
            this.cbSpaceLine.Size = new System.Drawing.Size(72, 16);
            this.cbSpaceLine.TabIndex = 10;
            this.cbSpaceLine.Text = "添加空行";
            this.cbSpaceLine.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 516);
            this.Controls.Add(this.cbSpaceLine);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "座位编排器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbVertical;
        private System.Windows.Forms.RadioButton rbHorizontal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbRightLeft;
        private System.Windows.Forms.RadioButton rbLeftRight;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbDownUp;
        private System.Windows.Forms.RadioButton rbUpDown;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RadioButton rbHMiddle;
        private System.Windows.Forms.RadioButton rbVMiddle;
        private System.Windows.Forms.CheckBox cbSpaceLine;
    }
}

