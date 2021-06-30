
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
            this.CorrectLabel = new System.Windows.Forms.Label();
            this.WrongLabel = new System.Windows.Forms.Label();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.SaveQuestionButton = new System.Windows.Forms.Button();
            this.StudyGroupLink = new System.Windows.Forms.LinkLabel();
            this.NextButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(907, 19);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(31, 13);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "Hello";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(944, 19);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(126, 13);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "XXXXXXXXXXXXXXXXX";
            // 
            // LogoutLink
            // 
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Location = new System.Drawing.Point(1030, 45);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(40, 13);
            this.LogoutLink.TabIndex = 2;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Logout";
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // CategoryHeaderLabel
            // 
            this.CategoryHeaderLabel.AutoSize = true;
            this.CategoryHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryHeaderLabel.Location = new System.Drawing.Point(14, 42);
            this.CategoryHeaderLabel.Name = "CategoryHeaderLabel";
            this.CategoryHeaderLabel.Size = new System.Drawing.Size(79, 16);
            this.CategoryHeaderLabel.TabIndex = 3;
            this.CategoryHeaderLabel.Text = "Category: ";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(90, 42);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(162, 16);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "xxxxxxxxxxxxxxxxxxxxxx";
            // 
            // QuestionProgressLabel
            // 
            this.QuestionProgressLabel.AutoSize = true;
            this.QuestionProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionProgressLabel.Location = new System.Drawing.Point(90, 71);
            this.QuestionProgressLabel.Name = "QuestionProgressLabel";
            this.QuestionProgressLabel.Size = new System.Drawing.Size(29, 16);
            this.QuestionProgressLabel.TabIndex = 5;
            this.QuestionProgressLabel.Text = "0/0";
            // 
            // QuestionNumberLabel
            // 
            this.QuestionNumberLabel.AutoSize = true;
            this.QuestionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionNumberLabel.Location = new System.Drawing.Point(96, 156);
            this.QuestionNumberLabel.Name = "QuestionNumberLabel";
            this.QuestionNumberLabel.Size = new System.Drawing.Size(25, 24);
            this.QuestionNumberLabel.TabIndex = 6;
            this.QuestionNumberLabel.Text = "0.";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(127, 156);
            this.QuestionLabel.MaximumSize = new System.Drawing.Size(800, 0);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(226, 40);
            this.QuestionLabel.TabIndex = 7;
            this.QuestionLabel.Text = "Using a credit card is most like:\r\n\r\n";
            // 
            // RadioAnswerA
            // 
            this.RadioAnswerA.AutoSize = true;
            this.RadioAnswerA.Checked = true;
            this.RadioAnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAnswerA.Location = new System.Drawing.Point(100, 236);
            this.RadioAnswerA.Name = "RadioAnswerA";
            this.RadioAnswerA.Size = new System.Drawing.Size(130, 28);
            this.RadioAnswerA.TabIndex = 8;
            this.RadioAnswerA.TabStop = true;
            this.RadioAnswerA.Text = "A. Answer 1";
            this.RadioAnswerA.UseVisualStyleBackColor = true;
            // 
            // RadioAnswerB
            // 
            this.RadioAnswerB.AutoSize = true;
            this.RadioAnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAnswerB.Location = new System.Drawing.Point(100, 304);
            this.RadioAnswerB.Name = "RadioAnswerB";
            this.RadioAnswerB.Size = new System.Drawing.Size(129, 28);
            this.RadioAnswerB.TabIndex = 9;
            this.RadioAnswerB.Text = "B. Answer 2";
            this.RadioAnswerB.UseVisualStyleBackColor = true;
            // 
            // RadioAnswerC
            // 
            this.RadioAnswerC.AutoSize = true;
            this.RadioAnswerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAnswerC.Location = new System.Drawing.Point(100, 379);
            this.RadioAnswerC.Name = "RadioAnswerC";
            this.RadioAnswerC.Size = new System.Drawing.Size(130, 28);
            this.RadioAnswerC.TabIndex = 10;
            this.RadioAnswerC.Text = "C. Answer 3";
            this.RadioAnswerC.UseVisualStyleBackColor = true;
            // 
            // RadioAnswerD
            // 
            this.RadioAnswerD.AutoSize = true;
            this.RadioAnswerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAnswerD.Location = new System.Drawing.Point(100, 454);
            this.RadioAnswerD.Name = "RadioAnswerD";
            this.RadioAnswerD.Size = new System.Drawing.Size(130, 28);
            this.RadioAnswerD.TabIndex = 11;
            this.RadioAnswerD.Text = "D. Answer 4";
            this.RadioAnswerD.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(499, 524);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(138, 47);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Location = new System.Drawing.Point(909, 45);
            this.reportLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(63, 13);
            this.reportLabel.TabIndex = 14;
            this.reportLabel.TabStop = true;
            this.reportLabel.Text = "Player Stats";
            this.reportLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reportLabel_LinkClicked);
            // 
            // CorrectLabel
            // 
            this.CorrectLabel.AutoSize = true;
            this.CorrectLabel.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CorrectLabel.Location = new System.Drawing.Point(781, 524);
            this.CorrectLabel.Name = "CorrectLabel";
            this.CorrectLabel.Size = new System.Drawing.Size(206, 40);
            this.CorrectLabel.TabIndex = 15;
            this.CorrectLabel.Text = " CORRECT";
            this.CorrectLabel.Visible = false;
            // 
            // WrongLabel
            // 
            this.WrongLabel.AutoSize = true;
            this.WrongLabel.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongLabel.ForeColor = System.Drawing.Color.Red;
            this.WrongLabel.Location = new System.Drawing.Point(756, 531);
            this.WrongLabel.Name = "WrongLabel";
            this.WrongLabel.Size = new System.Drawing.Size(249, 40);
            this.WrongLabel.TabIndex = 16;
            this.WrongLabel.Text = " INCORRECT";
            this.WrongLabel.Visible = false;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressLabel.Location = new System.Drawing.Point(12, 71);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(79, 16);
            this.ProgressLabel.TabIndex = 17;
            this.ProgressLabel.Text = "Progress: ";
            // 
            // SaveQuestionButton
            // 
            this.SaveQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveQuestionButton.Location = new System.Drawing.Point(91, 527);
            this.SaveQuestionButton.Name = "SaveQuestionButton";
            this.SaveQuestionButton.Size = new System.Drawing.Size(262, 47);
            this.SaveQuestionButton.TabIndex = 18;
            this.SaveQuestionButton.Text = "Add to Study Group";
            this.SaveQuestionButton.UseVisualStyleBackColor = true;
            this.SaveQuestionButton.Visible = false;
            // 
            // StudyGroupLink
            // 
            this.StudyGroupLink.AutoSize = true;
            this.StudyGroupLink.Location = new System.Drawing.Point(932, 71);
            this.StudyGroupLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudyGroupLink.Name = "StudyGroupLink";
            this.StudyGroupLink.Size = new System.Drawing.Size(109, 13);
            this.StudyGroupLink.TabIndex = 19;
            this.StudyGroupLink.TabStop = true;
            this.StudyGroupLink.Text = "View My Study Group";
            this.StudyGroupLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StudyGroupLink_LinkClicked);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(499, 524);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(138, 47);
            this.NextButton.TabIndex = 20;
            this.NextButton.Text = "Next Question";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Visible = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameButton.Location = new System.Drawing.Point(499, 518);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(138, 53);
            this.NewGameButton.TabIndex = 21;
            this.NewGameButton.Text = "Start a New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Visible = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // PlayerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 623);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.StudyGroupLink);
            this.Controls.Add(this.SaveQuestionButton);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.WrongLabel);
            this.Controls.Add(this.CorrectLabel);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1133, 662);
            this.MinimumSize = new System.Drawing.Size(1133, 662);
            this.Name = "PlayerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiddie Cash Komprehension";
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
        private System.Windows.Forms.Label CorrectLabel;
        private System.Windows.Forms.Label WrongLabel;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Button SaveQuestionButton;
        private System.Windows.Forms.LinkLabel StudyGroupLink;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button NewGameButton;
    }
}