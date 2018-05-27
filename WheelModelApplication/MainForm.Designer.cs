namespace WheelModelApplication
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
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.processButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EndTTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.startTTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.omegaTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.kTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.Location = new System.Drawing.Point(269, 12);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(519, 426);
            this.outputTextBox.TabIndex = 0;
            this.outputTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Speed";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(83, 19);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(168, 20);
            this.speedTextBox.TabIndex = 2;
            this.speedTextBox.Text = "10";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.gTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.mTextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.kTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.omegaTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rTextBox);
            this.groupBox1.Controls.Add(this.processButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.EndTTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.startTTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.iTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.uTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.heightTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.speedTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(9, 388);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(242, 23);
            this.processButton.TabIndex = 15;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "dt";
            // 
            // dtTextBox
            // 
            this.dtTextBox.Location = new System.Drawing.Point(83, 363);
            this.dtTextBox.Name = "dtTextBox";
            this.dtTextBox.Size = new System.Drawing.Size(168, 20);
            this.dtTextBox.TabIndex = 14;
            this.dtTextBox.Text = "0.5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "End t";
            // 
            // EndTTextBox
            // 
            this.EndTTextBox.Location = new System.Drawing.Point(83, 337);
            this.EndTTextBox.Name = "EndTTextBox";
            this.EndTTextBox.Size = new System.Drawing.Size(168, 20);
            this.EndTTextBox.TabIndex = 12;
            this.EndTTextBox.Text = "10.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Start t";
            // 
            // startTTextBox
            // 
            this.startTTextBox.Location = new System.Drawing.Point(83, 311);
            this.startTTextBox.Name = "startTTextBox";
            this.startTTextBox.Size = new System.Drawing.Size(168, 20);
            this.startTTextBox.TabIndex = 10;
            this.startTTextBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "I";
            // 
            // iTextBox
            // 
            this.iTextBox.Location = new System.Drawing.Point(83, 97);
            this.iTextBox.Name = "iTextBox";
            this.iTextBox.Size = new System.Drawing.Size(168, 20);
            this.iTextBox.TabIndex = 8;
            this.iTextBox.Text = "1.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "U";
            // 
            // uTextBox
            // 
            this.uTextBox.Location = new System.Drawing.Point(83, 71);
            this.uTextBox.Name = "uTextBox";
            this.uTextBox.Size = new System.Drawing.Size(168, 20);
            this.uTextBox.TabIndex = 6;
            this.uTextBox.Text = "1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(83, 45);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(168, 20);
            this.heightTextBox.TabIndex = 4;
            this.heightTextBox.Text = "0.5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Omega";
            // 
            // omegaTextBox
            // 
            this.omegaTextBox.Location = new System.Drawing.Point(83, 149);
            this.omegaTextBox.Name = "omegaTextBox";
            this.omegaTextBox.Size = new System.Drawing.Size(168, 20);
            this.omegaTextBox.TabIndex = 19;
            this.omegaTextBox.Text = "0.1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "R";
            // 
            // rTextBox
            // 
            this.rTextBox.Location = new System.Drawing.Point(83, 123);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(168, 20);
            this.rTextBox.TabIndex = 17;
            this.rTextBox.Text = "0.5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "G";
            // 
            // gTextBox
            // 
            this.gTextBox.Location = new System.Drawing.Point(83, 229);
            this.gTextBox.Name = "gTextBox";
            this.gTextBox.Size = new System.Drawing.Size(168, 20);
            this.gTextBox.TabIndex = 25;
            this.gTextBox.Text = "9.8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "M";
            // 
            // mTextBox
            // 
            this.mTextBox.Location = new System.Drawing.Point(83, 203);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(168, 20);
            this.mTextBox.TabIndex = 23;
            this.mTextBox.Text = "1000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "K";
            // 
            // kTextBox
            // 
            this.kTextBox.Location = new System.Drawing.Point(83, 177);
            this.kTextBox.Name = "kTextBox";
            this.kTextBox.Size = new System.Drawing.Size(168, 20);
            this.kTextBox.TabIndex = 21;
            this.kTextBox.Text = "0.1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "F(x)";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(83, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "sin(x)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.outputTextBox);
            this.Name = "MainForm";
            this.Text = "Wheel Model";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox iTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dtTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EndTTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox startTTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox omegaTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox gTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox kTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
    }
}

