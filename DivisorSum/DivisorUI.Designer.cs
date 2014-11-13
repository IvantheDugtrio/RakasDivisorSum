namespace DivisorSum
{
    partial class DivisorUI
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
            this.label5 = new System.Windows.Forms.Label();
            this.foundNumBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numStartBox = new System.Windows.Forms.TextBox();
            this.numEndBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numIterateBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numTestIterateBox = new System.Windows.Forms.TextBox();
            this.threadBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentNumberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Found Numbers";
            // 
            // foundNumBox
            // 
            this.foundNumBox.Location = new System.Drawing.Point(382, 68);
            this.foundNumBox.Multiline = true;
            this.foundNumBox.Name = "foundNumBox";
            this.foundNumBox.ReadOnly = true;
            this.foundNumBox.Size = new System.Drawing.Size(335, 354);
            this.foundNumBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Number Range";
            // 
            // numStartBox
            // 
            this.numStartBox.Location = new System.Drawing.Point(15, 25);
            this.numStartBox.Name = "numStartBox";
            this.numStartBox.Size = new System.Drawing.Size(149, 20);
            this.numStartBox.TabIndex = 12;
            this.numStartBox.Text = "0";
            // 
            // numEndBox
            // 
            this.numEndBox.Location = new System.Drawing.Point(201, 25);
            this.numEndBox.Name = "numEndBox";
            this.numEndBox.Size = new System.Drawing.Size(149, 20);
            this.numEndBox.TabIndex = 13;
            this.numEndBox.Text = "10000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Number Iterator (Number to test)";
            // 
            // numIterateBox
            // 
            this.numIterateBox.Location = new System.Drawing.Point(15, 68);
            this.numIterateBox.Name = "numIterateBox";
            this.numIterateBox.Size = new System.Drawing.Size(149, 20);
            this.numIterateBox.TabIndex = 16;
            this.numIterateBox.Text = "1";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(14, 178);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 17;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Test Number Iterator (Number to test against)";
            // 
            // numTestIterateBox
            // 
            this.numTestIterateBox.Location = new System.Drawing.Point(15, 110);
            this.numTestIterateBox.Name = "numTestIterateBox";
            this.numTestIterateBox.Size = new System.Drawing.Size(149, 20);
            this.numTestIterateBox.TabIndex = 19;
            this.numTestIterateBox.Text = "1";
            // 
            // threadBox
            // 
            this.threadBox.Location = new System.Drawing.Point(15, 152);
            this.threadBox.Name = "threadBox";
            this.threadBox.Size = new System.Drawing.Size(149, 20);
            this.threadBox.TabIndex = 21;
            this.threadBox.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Thread Count";
            // 
            // currentNumberBox
            // 
            this.currentNumberBox.Location = new System.Drawing.Point(382, 25);
            this.currentNumberBox.Name = "currentNumberBox";
            this.currentNumberBox.ReadOnly = true;
            this.currentNumberBox.Size = new System.Drawing.Size(335, 20);
            this.currentNumberBox.TabIndex = 22;
            this.currentNumberBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Current Number";
            // 
            // DivisorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 437);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentNumberBox);
            this.Controls.Add(this.threadBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTestIterateBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.numIterateBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numEndBox);
            this.Controls.Add(this.numStartBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.foundNumBox);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(746, 476);
            this.MinimumSize = new System.Drawing.Size(746, 476);
            this.Name = "DivisorUI";
            this.ShowIcon = false;
            this.Text = "Divisor Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox foundNumBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numStartBox;
        private System.Windows.Forms.TextBox numEndBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numIterateBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox numTestIterateBox;
        private System.Windows.Forms.TextBox threadBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currentNumberBox;
        private System.Windows.Forms.Label label2;
    }
}

