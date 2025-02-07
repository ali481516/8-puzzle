namespace T4_8._0_
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            resultLabel = new Label();
            playAgainButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timeLabel = new Label();
            bfsButton = new Button();
            resultListBox = new ListBox();
            timeCountsLabel = new Label();
            bidirectionalButton = new Button();
            actionsLabel = new Label();
            CompareButton = new Button();
            AStarButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(309, 107);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(52, 51);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(368, 107);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(52, 51);
            button2.TabIndex = 1;
            button2.TabStop = false;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(425, 107);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(52, 51);
            button3.TabIndex = 2;
            button3.TabStop = false;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(309, 164);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(52, 51);
            button4.TabIndex = 3;
            button4.TabStop = false;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Highlight;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(368, 164);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(52, 51);
            button5.TabIndex = 4;
            button5.TabStop = false;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += Button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Highlight;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(425, 164);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(52, 51);
            button6.TabIndex = 5;
            button6.TabStop = false;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += Button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Highlight;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(309, 222);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(52, 51);
            button7.TabIndex = 6;
            button7.TabStop = false;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += Button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Highlight;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = SystemColors.Control;
            button8.Location = new Point(368, 222);
            button8.Margin = new Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Size = new Size(52, 51);
            button8.TabIndex = 7;
            button8.TabStop = false;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += Button8_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.Highlight;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = SystemColors.Control;
            button9.Location = new Point(425, 222);
            button9.Margin = new Padding(4, 3, 4, 3);
            button9.Name = "button9";
            button9.Size = new Size(52, 51);
            button9.TabIndex = 8;
            button9.TabStop = false;
            button9.UseVisualStyleBackColor = false;
            button9.Click += Button9_Click;
            // 
            // resultLabel
            // 
            resultLabel.Font = new Font("Segoe UI", 20F);
            resultLabel.ForeColor = Color.LimeGreen;
            resultLabel.Location = new Point(270, 288);
            resultLabel.Margin = new Padding(4, 0, 4, 0);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(243, 53);
            resultLabel.TabIndex = 9;
            resultLabel.Text = "Congratulations!";
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            resultLabel.Visible = false;
            // 
            // playAgainButton
            // 
            playAgainButton.BackColor = Color.OrangeRed;
            playAgainButton.FlatStyle = FlatStyle.Flat;
            playAgainButton.ForeColor = SystemColors.Control;
            playAgainButton.Location = new Point(348, 345);
            playAgainButton.Margin = new Padding(4, 3, 4, 3);
            playAgainButton.Name = "playAgainButton";
            playAgainButton.Size = new Size(92, 51);
            playAgainButton.TabIndex = 10;
            playAgainButton.TabStop = false;
            playAgainButton.Text = "Play Again!";
            playAgainButton.UseVisualStyleBackColor = false;
            playAgainButton.Visible = false;
            playAgainButton.Click += PlayAgainButton_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(385, 89);
            timeLabel.Margin = new Padding(4, 0, 4, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(19, 15);
            timeLabel.TabIndex = 11;
            timeLabel.Text = "10";
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bfsButton
            // 
            bfsButton.BackColor = Color.ForestGreen;
            bfsButton.FlatStyle = FlatStyle.Flat;
            bfsButton.ForeColor = SystemColors.Control;
            bfsButton.Location = new Point(592, 107);
            bfsButton.Margin = new Padding(4, 3, 4, 3);
            bfsButton.Name = "bfsButton";
            bfsButton.Size = new Size(92, 51);
            bfsButton.TabIndex = 12;
            bfsButton.TabStop = false;
            bfsButton.Text = "BFS";
            bfsButton.UseVisualStyleBackColor = false;
            bfsButton.Click += BFSButton_Click;
            // 
            // resultListBox
            // 
            resultListBox.FormattingEnabled = true;
            resultListBox.ItemHeight = 15;
            resultListBox.Location = new Point(83, 89);
            resultListBox.Margin = new Padding(4, 3, 4, 3);
            resultListBox.Name = "resultListBox";
            resultListBox.Size = new Size(119, 94);
            resultListBox.TabIndex = 13;
            // 
            // timeCountsLabel
            // 
            timeCountsLabel.AutoSize = true;
            timeCountsLabel.Location = new Point(592, 57);
            timeCountsLabel.Margin = new Padding(4, 0, 4, 0);
            timeCountsLabel.Name = "timeCountsLabel";
            timeCountsLabel.Size = new Size(79, 15);
            timeCountsLabel.TabIndex = 14;
            timeCountsLabel.Text = "Time taken = ";
            timeCountsLabel.Visible = false;
            // 
            // bidirectionalButton
            // 
            bidirectionalButton.BackColor = Color.ForestGreen;
            bidirectionalButton.FlatStyle = FlatStyle.Flat;
            bidirectionalButton.ForeColor = SystemColors.Control;
            bidirectionalButton.Location = new Point(592, 165);
            bidirectionalButton.Margin = new Padding(4, 3, 4, 3);
            bidirectionalButton.Name = "bidirectionalButton";
            bidirectionalButton.Size = new Size(92, 51);
            bidirectionalButton.TabIndex = 15;
            bidirectionalButton.TabStop = false;
            bidirectionalButton.Text = "Bidirectional";
            bidirectionalButton.UseVisualStyleBackColor = false;
            bidirectionalButton.Click += BidirectionalButton_Click;
            // 
            // actionsLabel
            // 
            actionsLabel.AutoSize = true;
            actionsLabel.Location = new Point(79, 222);
            actionsLabel.Margin = new Padding(4, 0, 4, 0);
            actionsLabel.Name = "actionsLabel";
            actionsLabel.Size = new Size(87, 15);
            actionsLabel.TabIndex = 16;
            actionsLabel.Text = "Actions count: ";
            actionsLabel.Visible = false;
            // 
            // CompareButton
            // 
            CompareButton.BackColor = Color.DarkSlateGray;
            CompareButton.FlatStyle = FlatStyle.Flat;
            CompareButton.ForeColor = SystemColors.Control;
            CompareButton.Location = new Point(592, 345);
            CompareButton.Margin = new Padding(5, 3, 5, 3);
            CompareButton.Name = "CompareButton";
            CompareButton.Size = new Size(92, 51);
            CompareButton.TabIndex = 17;
            CompareButton.TabStop = false;
            CompareButton.Text = "Compare";
            CompareButton.UseVisualStyleBackColor = false;
            CompareButton.Click += CompareButton_Click;
            // 
            // AStarButton
            // 
            AStarButton.BackColor = Color.ForestGreen;
            AStarButton.FlatStyle = FlatStyle.Flat;
            AStarButton.ForeColor = SystemColors.Control;
            AStarButton.Location = new Point(592, 222);
            AStarButton.Margin = new Padding(4, 3, 4, 3);
            AStarButton.Name = "AStarButton";
            AStarButton.Size = new Size(92, 51);
            AStarButton.TabIndex = 17;
            AStarButton.TabStop = false;
            AStarButton.Text = "A*";
            AStarButton.UseVisualStyleBackColor = false;
            AStarButton.Click += AStarButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CompareButton);
            Controls.Add(AStarButton);
            Controls.Add(actionsLabel);
            Controls.Add(bidirectionalButton);
            Controls.Add(timeCountsLabel);
            Controls.Add(resultListBox);
            Controls.Add(bfsButton);
            Controls.Add(timeLabel);
            Controls.Add(playAgainButton);
            Controls.Add(resultLabel);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button bfsButton;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Label timeCountsLabel;
        private System.Windows.Forms.Button bidirectionalButton;
        private System.Windows.Forms.Label actionsLabel;
        private System.Windows.Forms.Button AStarButton;
        private Button CompareButton;
    }
}
