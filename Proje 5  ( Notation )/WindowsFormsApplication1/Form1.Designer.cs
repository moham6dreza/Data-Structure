namespace WindowsFormsApplication1
{
    partial class Polish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Polish));
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.PostFixTB = new System.Windows.Forms.TextBox();
            this.PreFixTB = new System.Windows.Forms.TextBox();
            this.InFixTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddPrefix = new System.Windows.Forms.Button();
            this.AddPostfix = new System.Windows.Forms.Button();
            this.AddInfix = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.convertPos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.List = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(312, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "W    E    L    L    C    O    M    E";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Location = new System.Drawing.Point(22, 198);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Clear Expressions";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 405);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 23);
            this.comboBox1.TabIndex = 30;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button8.Location = new System.Drawing.Point(63, 376);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(178, 23);
            this.button8.TabIndex = 31;
            this.button8.Text = "Clear List";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.PostFixTB);
            this.groupBox1.Controls.Add(this.PreFixTB);
            this.groupBox1.Controls.Add(this.InFixTB);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(26, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 237);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Expressions";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.radioButton3.Location = new System.Drawing.Point(22, 136);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 19);
            this.radioButton3.TabIndex = 33;
            this.radioButton3.Text = "PreFix";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.radioButton2.Location = new System.Drawing.Point(22, 83);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 19);
            this.radioButton2.TabIndex = 32;
            this.radioButton2.Text = "PostFix";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.radioButton1.Location = new System.Drawing.Point(22, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 19);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "InFix";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // PostFixTB
            // 
            this.PostFixTB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PostFixTB.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.PostFixTB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PostFixTB.Location = new System.Drawing.Point(22, 108);
            this.PostFixTB.Margin = new System.Windows.Forms.Padding(4);
            this.PostFixTB.Name = "PostFixTB";
            this.PostFixTB.Size = new System.Drawing.Size(150, 21);
            this.PostFixTB.TabIndex = 30;
            this.PostFixTB.UseWaitCursor = true;
            this.PostFixTB.TextChanged += new System.EventHandler(this.PostFixTB_TextChanged);
            this.PostFixTB.Enter += new System.EventHandler(this.PostFixTB_Enter);
            // 
            // PreFixTB
            // 
            this.PreFixTB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PreFixTB.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.PreFixTB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PreFixTB.Location = new System.Drawing.Point(22, 160);
            this.PreFixTB.Margin = new System.Windows.Forms.Padding(4);
            this.PreFixTB.Name = "PreFixTB";
            this.PreFixTB.Size = new System.Drawing.Size(150, 21);
            this.PreFixTB.TabIndex = 29;
            this.PreFixTB.UseWaitCursor = true;
            // 
            // InFixTB
            // 
            this.InFixTB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.InFixTB.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.InFixTB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.InFixTB.Location = new System.Drawing.Point(22, 54);
            this.InFixTB.Margin = new System.Windows.Forms.Padding(4);
            this.InFixTB.Name = "InFixTB";
            this.InFixTB.Size = new System.Drawing.Size(150, 21);
            this.InFixTB.TabIndex = 28;
            this.InFixTB.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.AddPrefix);
            this.groupBox2.Controls.Add(this.AddPostfix);
            this.groupBox2.Controls.Add(this.AddInfix);
            this.groupBox2.Location = new System.Drawing.Point(235, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 147);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add To List";
            // 
            // AddPrefix
            // 
            this.AddPrefix.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AddPrefix.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.AddPrefix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPrefix.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddPrefix.Location = new System.Drawing.Point(22, 99);
            this.AddPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.AddPrefix.Name = "AddPrefix";
            this.AddPrefix.Size = new System.Drawing.Size(242, 26);
            this.AddPrefix.TabIndex = 21;
            this.AddPrefix.Text = "Add PreFix Expression To List";
            this.AddPrefix.UseVisualStyleBackColor = false;
            this.AddPrefix.UseWaitCursor = true;
            this.AddPrefix.Click += new System.EventHandler(this.AddPrefix_Click);
            // 
            // AddPostfix
            // 
            this.AddPostfix.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AddPostfix.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.AddPostfix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPostfix.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddPostfix.Location = new System.Drawing.Point(22, 65);
            this.AddPostfix.Margin = new System.Windows.Forms.Padding(4);
            this.AddPostfix.Name = "AddPostfix";
            this.AddPostfix.Size = new System.Drawing.Size(242, 26);
            this.AddPostfix.TabIndex = 20;
            this.AddPostfix.Text = "Add PostFix Expression To List";
            this.AddPostfix.UseVisualStyleBackColor = false;
            this.AddPostfix.UseWaitCursor = true;
            this.AddPostfix.Click += new System.EventHandler(this.AddPostfix_Click);
            // 
            // AddInfix
            // 
            this.AddInfix.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AddInfix.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.AddInfix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddInfix.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddInfix.Location = new System.Drawing.Point(22, 31);
            this.AddInfix.Margin = new System.Windows.Forms.Padding(4);
            this.AddInfix.Name = "AddInfix";
            this.AddInfix.Size = new System.Drawing.Size(242, 26);
            this.AddInfix.TabIndex = 19;
            this.AddInfix.Text = "Add InFix Expression To List";
            this.AddInfix.UseVisualStyleBackColor = false;
            this.AddInfix.UseWaitCursor = true;
            this.AddInfix.Click += new System.EventHandler(this.AddInfix_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.convertPos);
            this.groupBox3.Location = new System.Drawing.Point(283, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 183);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Convert And Evaluation";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(22, 129);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(242, 26);
            this.button4.TabIndex = 12;
            this.button4.Text = "Evaluate This Expression";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(22, 61);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 26);
            this.button3.TabIndex = 11;
            this.button3.Text = "Evaluate This Expression";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(22, 95);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 26);
            this.button2.TabIndex = 10;
            this.button2.Text = "Convert To PreFix Expression";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // convertPos
            // 
            this.convertPos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.convertPos.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.convertPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertPos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.convertPos.Location = new System.Drawing.Point(22, 29);
            this.convertPos.Margin = new System.Windows.Forms.Padding(4);
            this.convertPos.Name = "convertPos";
            this.convertPos.Size = new System.Drawing.Size(242, 24);
            this.convertPos.TabIndex = 9;
            this.convertPos.Text = "Convert To PostFix Expression";
            this.convertPos.UseVisualStyleBackColor = false;
            this.convertPos.UseWaitCursor = true;
            this.convertPos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Location = new System.Drawing.Point(87, 399);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 109);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Evalutions";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button7.Location = new System.Drawing.Point(22, 65);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(242, 26);
            this.button7.TabIndex = 17;
            this.button7.Text = "Evaluate PreFix Expression";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.UseWaitCursor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button6.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.Location = new System.Drawing.Point(22, 31);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(242, 26);
            this.button6.TabIndex = 16;
            this.button6.Text = "Evaluate PostFix Expression";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.UseWaitCursor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Controls.Add(this.List);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Location = new System.Drawing.Point(571, 39);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(303, 451);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Implemetation";
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.SystemColors.HighlightText;
            this.List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.List.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 16;
            this.List.Location = new System.Drawing.Point(7, 31);
            this.List.Margin = new System.Windows.Forms.Padding(4);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(289, 338);
            this.List.TabIndex = 6;
            this.List.UseWaitCursor = true;
            // 
            // Polish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 520);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Polish";
            this.Text = "Polish Notation Expression";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox PostFixTB;
        private System.Windows.Forms.TextBox PreFixTB;
        private System.Windows.Forms.TextBox InFixTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddPrefix;
        private System.Windows.Forms.Button AddPostfix;
        private System.Windows.Forms.Button AddInfix;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Button convertPos;
    }
}

