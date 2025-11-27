namespace MichelleMunguiaProject2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonSubmit = new Button();
            BoxInput = new TextBox();
            BoxDisplay = new ListBox();
            labelTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            labelTime = new Label();
            SuspendLayout();
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(1072, 689);
            buttonSubmit.Margin = new Padding(6);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(139, 49);
            buttonSubmit.TabIndex = 0;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // BoxInput
            // 
            BoxInput.Location = new Point(607, 691);
            BoxInput.Margin = new Padding(6);
            BoxInput.Name = "BoxInput";
            BoxInput.ReadOnly = true;
            BoxInput.Size = new Size(383, 39);
            BoxInput.TabIndex = 2;
            // 
            // BoxDisplay
            // 
            BoxDisplay.FormattingEnabled = true;
            BoxDisplay.Location = new Point(85, 188);
            BoxDisplay.Margin = new Padding(6);
            BoxDisplay.Name = "BoxDisplay";
            BoxDisplay.Size = new Size(375, 548);
            BoxDisplay.TabIndex = 3;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(607, 53);
            labelTitle.Margin = new Padding(6, 0, 6, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(637, 90);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "TWISTED WORDS";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(585, 544);
            label1.Margin = new Padding(19, 21, 19, 21);
            label1.Name = "label1";
            label1.Size = new Size(63, 87);
            label1.TabIndex = 5;
            label1.Text = "X";
            label1.UseMnemonic = false;
            label1.Click += Letter_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Highlight;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(682, 544);
            label2.Margin = new Padding(19, 21, 19, 21);
            label2.Name = "label2";
            label2.Size = new Size(63, 87);
            label2.TabIndex = 6;
            label2.Text = "X";
            label2.Click += Letter_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Highlight;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(778, 544);
            label3.Margin = new Padding(19, 21, 19, 21);
            label3.Name = "label3";
            label3.Size = new Size(63, 87);
            label3.TabIndex = 7;
            label3.Text = "X";
            label3.Click += Letter_Click;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Highlight;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(875, 544);
            label4.Margin = new Padding(19, 21, 19, 21);
            label4.Name = "label4";
            label4.Size = new Size(63, 87);
            label4.TabIndex = 8;
            label4.Text = "X";
            label4.Click += Letter_Click;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Highlight;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(971, 544);
            label5.Margin = new Padding(19, 21, 19, 21);
            label5.Name = "label5";
            label5.Size = new Size(63, 87);
            label5.TabIndex = 9;
            label5.Text = "X";
            label5.Click += Letter_Click;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.Highlight;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(1068, 544);
            label6.Margin = new Padding(19, 21, 19, 21);
            label6.Name = "label6";
            label6.Size = new Size(63, 87);
            label6.TabIndex = 10;
            label6.Text = "X";
            label6.Click += Letter_Click;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Highlight;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(1164, 544);
            label7.Margin = new Padding(19, 21, 19, 21);
            label7.Name = "label7";
            label7.Size = new Size(63, 87);
            label7.TabIndex = 11;
            label7.Text = "X";
            label7.Click += Letter_Click;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 1000;
            gameTimer.Tick += this.GameTimer;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.BackColor = SystemColors.ButtonHighlight;
            labelTime.BorderStyle = BorderStyle.Fixed3D;
            labelTime.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTime.ForeColor = Color.OrangeRed;
            labelTime.Location = new Point(186, 107);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(151, 52);
            labelTime.TabIndex = 15;
            labelTime.Text = "label11";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 896);
            Controls.Add(labelTime);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(BoxDisplay);
            Controls.Add(BoxInput);
            Controls.Add(buttonSubmit);
            Margin = new Padding(6);
            Name = "MainForm";
            Text = "FormText Twist by Munguia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSubmit;
        private TextBox BoxInput;
        private ListBox BoxDisplay;
        private Label labelTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private System.Windows.Forms.Timer gameTimer;
        private Label labelTime;
    }
}
