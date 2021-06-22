
namespace FinancialQuiz.View
{
    partial class PlayerDashboard
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
            this.HelloLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.CategoryHeaderLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.QuestionProgressLabel = new System.Windows.Forms.Label();
            this.QuestionNumberLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.RadioAnswerA = new System.Windows.Forms.RadioButton();
            this.RadioAnswerB = new System.Windows.Forms.RadioButton();
            this.RadioAnswerC = new System.Windows.Forms.RadioButton();
            this.RadioAnswerD = new System.Windows.Forms.RadioButton();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.reportLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(1360, 29);
            this.HelloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(45, 20);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "Hello";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(1416, 29);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(196, 20);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "XXXXXXXXXXXXXXXXX";
            // 
            // LogoutLink
            // 
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Location = new System.Drawing.Point(1545, 69);
            this.LogoutLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(59, 20);
            this.LogoutLink.TabIndex = 2;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Logout";
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // CategoryHeaderLabel
            // 
            this.CategoryHeaderLabel.AutoSize = true;
            this.CategoryHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryHeaderLabel.Location = new System.Drawing.Point(21, 65);
            this.CategoryHeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryHeaderLabel.Name = "CategoryHeaderLabel";
            this.CategoryHeaderLabel.Size = new System.Drawing.Size(113, 25);
            this.CategoryHeaderLabel.TabIndex = 3;
            this.CategoryHeaderLabel.Text = "Category: ";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(135, 65);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(254, 25);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "xxxxxxxxxxxxxxxxxxxxxx";
            // 
            // QuestionProgressLabel
            // 
            this.QuestionProgressLabel.AutoSize = true;
            this.QuestionProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionProgressLabel.Location = new System.Drawing.Point(402, 65);
            this.QuestionProgressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuestionProgressLabel.Name = "QuestionProgressLabel";
            this.QuestionProgressLabel.Size = new System.Drawing.Size(43, 25);
            this.QuestionProgressLabel.TabIndex = 5;
            this.QuestionProgressLabel.Text = "0/0";
            // 
            // QuestionNumberLabel
            // 
            this.QuestionNumberLabel.AutoSize = true;
            this.QuestionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionNumberLabel.Location = new System.Drawing.Point(144, 240);
            this.QuestionNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuestionNumberLabel.Name = "QuestionNumberLabel";
            this.QuestionNumberLabel.Size = new System.Drawing.Size(39, 33);
            this.QuestionNumberLabel.TabIndex = 6;
            this.QuestionNumberLabel.Text = "0.";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(190, 240);
            this.QuestionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuestionLabel.MaximumSize = new System.Drawing.Size(1200, 0);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(345, 58);
            this.QuestionLabel.TabIndex = 7;
            this.QuestionLabel.Text = "Using a credit card is most like:\r\n\r\n";
            // 
            // RadioAnswerA
            // 
            this.RadioAnswerA.AutoSize = true;
            this.RadioAnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAnswerA.Location = new System.Drawing.Point(150, 363);
            this.RadioAnswerA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioAnswerA.Name = "RadioAnswerA";
            this.RadioAnswerA.Size = new System.Drawing.Size(196, 37);
            this.RadioAnswerA.TabIndex = 8;
            this.RadioAnswerA.TabStop = true;
            this.RadioAnswerA.Text = "A. Answer 1";
            this.RadioAnswerA.UseVisualStyleBackColor = true;
            // 
            // RadioAnswerB
            // 
            this.RadioAnswerB.AutoSize = true;
            this.RadioAnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAnswerB.Location = new System.Drawing.Point(150, 468);
            this.RadioAnswerB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioAnswerB.Name = "RadioAnswerB";
            this.RadioAnswerB.Size = new System.Drawing.Size(196, 37);
            this.RadioAnswerB.TabIndex = 9;
            this.RadioAnswerB.TabStop = true;
            this.RadioAnswerB.Text = "B. Answer 2";
            this.RadioAnswerB.UseVisualStyleBackColor = true;
            // 
            // RadioAnswerC
            // 
            this.RadioAnswerC.AutoSize = true;
            this.RadioAnswerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAnswerC.Location = new System.Drawing.Point(150, 583);
            this.RadioAnswerC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioAnswerC.Name = "RadioAnswerC";
            this.RadioAnswerC.Size = new System.Drawing.Size(198, 37);
            this.RadioAnswerC.TabIndex = 10;
            this.RadioAnswerC.TabStop = true;
            this.RadioAnswerC.Text = "C. Answer 3";
            this.RadioAnswerC.UseVisualStyleBackColor = true;
            // 
            // RadioAnswerD
            // 
            this.RadioAnswerD.AutoSize = true;
            this.RadioAnswerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAnswerD.Location = new System.Drawing.Point(150, 698);
            this.RadioAnswerD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioAnswerD.Name = "RadioAnswerD";
            this.RadioAnswerD.Size = new System.Drawing.Size(198, 37);
            this.RadioAnswerD.TabIndex = 11;
            this.RadioAnswerD.TabStop = true;
            this.RadioAnswerD.Text = "D. Answer 4";
            this.RadioAnswerD.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(748, 806);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(207, 72);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Location = new System.Drawing.Point(1364, 69);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(58, 20);
            this.reportLabel.TabIndex = 14;
            this.reportLabel.TabStop = true;
            this.reportLabel.Text = "Report";
            this.reportLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reportLabel_LinkClicked);
            // 
            // PlayerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1670, 942);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.RadioAnswerD);
            this.Controls.Add(this.RadioAnswerC);
            this.Controls.Add(this.RadioAnswerB);
            this.Controls.Add(this.RadioAnswerA);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.QuestionNumberLabel);
            this.Controls.Add(this.QuestionProgressLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategoryHeaderLabel);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.HelloLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1692, 998);
            this.MinimumSize = new System.Drawing.Size(1692, 998);
            this.Name = "PlayerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiddie Cash Komprehension";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exit);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.Label CategoryHeaderLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label QuestionProgressLabel;
        private System.Windows.Forms.Label QuestionNumberLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.RadioButton RadioAnswerA;
        private System.Windows.Forms.RadioButton RadioAnswerB;
        private System.Windows.Forms.RadioButton RadioAnswerC;
        private System.Windows.Forms.RadioButton RadioAnswerD;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.LinkLabel reportLabel;
    }
}