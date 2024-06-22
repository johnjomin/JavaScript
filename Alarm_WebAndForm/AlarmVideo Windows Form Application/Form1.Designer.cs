namespace AlarmVideo_Windows_Form_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userInputText = new System.Windows.Forms.TextBox();
            this.alarmIdResultBox = new System.Windows.Forms.TextBox();
            this.videoServerResultBox = new System.Windows.Forms.TextBox();
            this.enterMessage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.resultException = new System.Windows.Forms.TextBox();
            this.resultBar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExtractData = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(191, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter String:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(191, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alarm ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(191, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Video Server no:";
            // 
            // userInputText
            // 
            this.userInputText.Location = new System.Drawing.Point(310, 137);
            this.userInputText.Name = "userInputText";
            this.userInputText.Size = new System.Drawing.Size(613, 23);
            this.userInputText.TabIndex = 1;
            // 
            // alarmIdResultBox
            // 
            this.alarmIdResultBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alarmIdResultBox.Location = new System.Drawing.Point(310, 205);
            this.alarmIdResultBox.Name = "alarmIdResultBox";
            this.alarmIdResultBox.ReadOnly = true;
            this.alarmIdResultBox.Size = new System.Drawing.Size(162, 23);
            this.alarmIdResultBox.TabIndex = 1;
            // 
            // videoServerResultBox
            // 
            this.videoServerResultBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.videoServerResultBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.videoServerResultBox.Location = new System.Drawing.Point(310, 271);
            this.videoServerResultBox.Name = "videoServerResultBox";
            this.videoServerResultBox.ReadOnly = true;
            this.videoServerResultBox.Size = new System.Drawing.Size(162, 23);
            this.videoServerResultBox.TabIndex = 1;
            // 
            // enterMessage
            // 
            this.enterMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.enterMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterMessage.Location = new System.Drawing.Point(498, 456);
            this.enterMessage.Name = "enterMessage";
            this.enterMessage.Size = new System.Drawing.Size(149, 53);
            this.enterMessage.TabIndex = 2;
            this.enterMessage.Text = "Submit";
            this.enterMessage.UseVisualStyleBackColor = false;
            this.enterMessage.Click += new System.EventHandler(this.enterMessage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(274, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(448, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alarm Video Message Retrieval";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(192, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Result Message:";
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exceptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.exceptionLabel.Location = new System.Drawing.Point(192, 406);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(78, 19);
            this.exceptionLabel.TabIndex = 0;
            this.exceptionLabel.Text = "Exception:";
            this.exceptionLabel.Visible = false;
            // 
            // resultException
            // 
            this.resultException.Location = new System.Drawing.Point(310, 406);
            this.resultException.Name = "resultException";
            this.resultException.ReadOnly = true;
            this.resultException.Size = new System.Drawing.Size(613, 23);
            this.resultException.TabIndex = 5;
            this.resultException.Visible = false;
            // 
            // resultBar
            // 
            this.resultBar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultBar.Location = new System.Drawing.Point(310, 336);
            this.resultBar.Name = "resultBar";
            this.resultBar.ReadOnly = true;
            this.resultBar.Size = new System.Drawing.Size(162, 27);
            this.resultBar.TabIndex = 5;
            this.resultBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnExtractData);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 533);
            this.panel1.TabIndex = 6;
            // 
            // btnExtractData
            // 
            this.btnExtractData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExtractData.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnExtractData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExtractData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExtractData.Location = new System.Drawing.Point(0, 144);
            this.btnExtractData.Name = "btnExtractData";
            this.btnExtractData.Size = new System.Drawing.Size(186, 42);
            this.btnExtractData.TabIndex = 1;
            this.btnExtractData.Text = "Extract Data";
            this.btnExtractData.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExtractData.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(40, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Jomin John";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.enterMessage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(941, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resultBar);
            this.Controls.Add(this.resultException);
            this.Controls.Add(this.exceptionLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enterMessage);
            this.Controls.Add(this.videoServerResultBox);
            this.Controls.Add(this.alarmIdResultBox);
            this.Controls.Add(this.userInputText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userInputText;
        private System.Windows.Forms.TextBox alarmIdResultBox;
        private System.Windows.Forms.TextBox videoServerResultBox;
        private System.Windows.Forms.Button enterMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label exceptionLabel;
        private System.Windows.Forms.TextBox resultException;
        private System.Windows.Forms.TextBox resultBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExtractData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

