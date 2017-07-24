namespace TextBox2
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
            this.callerNameLabel = new System.Windows.Forms.Label();
            this.callerNameTextBox = new System.Windows.Forms.TextBox();
            this.callbackNumberTextBox = new System.Windows.Forms.TextBox();
            this.callbackNumLabel = new System.Windows.Forms.Label();
            this.callNoteLabel = new System.Windows.Forms.Label();
            this.callNoteRTBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.npiTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // callerNameLabel
            // 
            this.callerNameLabel.AutoSize = true;
            this.callerNameLabel.Location = new System.Drawing.Point(71, 50);
            this.callerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.callerNameLabel.Name = "callerNameLabel";
            this.callerNameLabel.Size = new System.Drawing.Size(93, 17);
            this.callerNameLabel.TabIndex = 0;
            this.callerNameLabel.Text = "Caller Name: ";
            // 
            // callerNameTextBox
            // 
            this.callerNameTextBox.Location = new System.Drawing.Point(213, 42);
            this.callerNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.callerNameTextBox.Name = "callerNameTextBox";
            this.callerNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.callerNameTextBox.TabIndex = 1;
            this.callerNameTextBox.TextChanged += new System.EventHandler(this.callerNameTextBox_TextChanged);
            // 
            // callbackNumberTextBox
            // 
            this.callbackNumberTextBox.Location = new System.Drawing.Point(213, 79);
            this.callbackNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.callbackNumberTextBox.Name = "callbackNumberTextBox";
            this.callbackNumberTextBox.Size = new System.Drawing.Size(132, 22);
            this.callbackNumberTextBox.TabIndex = 3;
            this.callbackNumberTextBox.TextChanged += new System.EventHandler(this.callbackNumberTextBox_TextChanged);
            // 
            // callbackNumLabel
            // 
            this.callbackNumLabel.AutoSize = true;
            this.callbackNumLabel.Location = new System.Drawing.Point(71, 82);
            this.callbackNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.callbackNumLabel.Name = "callbackNumLabel";
            this.callbackNumLabel.Size = new System.Drawing.Size(86, 17);
            this.callbackNumLabel.TabIndex = 2;
            this.callbackNumLabel.Text = "Call Back #: ";
            // 
            // callNoteLabel
            // 
            this.callNoteLabel.AutoSize = true;
            this.callNoteLabel.Location = new System.Drawing.Point(71, 223);
            this.callNoteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.callNoteLabel.Name = "callNoteLabel";
            this.callNoteLabel.Size = new System.Drawing.Size(65, 17);
            this.callNoteLabel.TabIndex = 4;
            this.callNoteLabel.Text = "Call Note";
            // 
            // callNoteRTBox
            // 
            this.callNoteRTBox.Location = new System.Drawing.Point(75, 244);
            this.callNoteRTBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.callNoteRTBox.Name = "callNoteRTBox";
            this.callNoteRTBox.Size = new System.Drawing.Size(267, 117);
            this.callNoteRTBox.TabIndex = 5;
            this.callNoteRTBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "NPI: ";
            // 
            // npiTextBox
            // 
            this.npiTextBox.Location = new System.Drawing.Point(213, 116);
            this.npiTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npiTextBox.Name = "npiTextBox";
            this.npiTextBox.Size = new System.Drawing.Size(132, 22);
            this.npiTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 400);
            this.Controls.Add(this.npiTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.callNoteRTBox);
            this.Controls.Add(this.callNoteLabel);
            this.Controls.Add(this.callbackNumberTextBox);
            this.Controls.Add(this.callbackNumLabel);
            this.Controls.Add(this.callerNameTextBox);
            this.Controls.Add(this.callerNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provider Services Call Tracking Aid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label callerNameLabel;
        private System.Windows.Forms.TextBox callerNameTextBox;
        private System.Windows.Forms.TextBox callbackNumberTextBox;
        private System.Windows.Forms.Label callbackNumLabel;
        private System.Windows.Forms.Label callNoteLabel;
        private System.Windows.Forms.RichTextBox callNoteRTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox npiTextBox;
    }
}

