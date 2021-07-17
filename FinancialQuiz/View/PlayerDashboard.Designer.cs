
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerDashboard));
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
            this.QuizPanel = new System.Windows.Forms.Panel();
            this.ExplanationRichText = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.QuizPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HelloLabel.Location = new System.Drawing.Point(1086, 23);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(57, 23);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "Hello";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UserNameLabel.Location = new System.Drawing.Point(1127, 23);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(231, 23);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "XXXXXXXXXXXXXXXXX";
            // 
            // LogoutLink
            // 
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLink.Location = new System.Drawing.Point(1087, 118);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(68, 21);
            this.LogoutLink.TabIndex = 2;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Logout";
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // CategoryHeaderLabel
            // 
            this.CategoryHeaderLabel.AutoSize = true;
            this.CategoryHeaderLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CategoryHeaderLabel.Location = new System.Drawing.Point(172, 55);
            this.CategoryHeaderLabel.Name = "CategoryHeaderLabel";
            this.CategoryHeaderLabel.Size = new System.Drawing.Size(114, 23);
            this.CategoryHeaderLabel.TabIndex = 3;
            this.CategoryHeaderLabel.Text = "Category: ";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CategoryLabel.Location = new System.Drawing.Point(258, 55);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(252, 23);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "xxxxxxxxxxxxxxxxxxxxxx";
            // 
            // QuestionProgressLabel
            // 
            this.QuestionProgressLabel.AutoSize = true;
            this.QuestionProgressLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionProgressLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.QuestionProgressLabel.Location = new System.Drawing.Point(258, 87);
            this.QuestionProgressLabel.Name = "QuestionProgressLabel";
            this.QuestionProgressLabel.Size = new System.Drawing.Size(41, 23);
            this.QuestionProgressLabel.TabIndex = 5;
            this.QuestionProgressLabel.Text = "0/0";
            // 
            // QuestionNumberLabel
            // 
            this.QuestionNumberLabel.AutoSize = true;
            this.QuestionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionNumberLabel.Location = new System.Drawing.Point(38, 25);
            this.QuestionNumberLabel.Name = "QuestionNumberLabel";
            this.QuestionNumberLabel.Size = new System.Drawing.Size(32, 29);
            this.QuestionNumberLabel.TabIndex = 6;
            this.QuestionNumberLabel.Text = "0.";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(75, 25);
            this.QuestionLabel.MaximumSize = new System.Drawing.Size(933, 0);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(279, 50);
            this.QuestionLabel.TabIndex = 7;
            this.QuestionLabel.Text = "Using a credit card is most like:\r\n\r\n";
            // 
            // RadioAnswerA
            // 
            this.RadioAnswerA.AutoSize = true;
            this.RadioAnswerA.Checked = true;
            this.RadioAnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAnswerA.Location = new System.Drawing.Point(43, 123);
            this.RadioAnswerA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioAnswerA.Name = "RadioAnswerA";
            this.RadioAnswerA.Size = new System.Drawing.Size(139, 29);
            this.RadioAnswerA.TabIndex = 8;
            this.RadioAnswerA.TabStop = true;
            this.RadioAnswerA.Text = "A. Answer 1";
            this.RadioAnswerA.UseVisualStyleBackColor = true;
            // 
            // RadioAnswerB
            // 
            this.RadioAnswerB.AutoSize = true;
            this.RadioAnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAnswerB.Location = new System.Drawing.Point(43, 207);
            this.RadioAnswerB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioAnswerB.Name = "RadioAnswerB";
            this.RadioAnswerB.Size = new System.Drawing.Size(138, 29);
            this.RadioAnswerB.TabIndex = 9;
            this.RadioAnswerB.Text = "B. Answer 2";
            this.RadioAnswerB.UseVisualStyleBackColor = true;
            // 
            // RadioAnswerC
            // 
            this.RadioAnswerC.AutoSize = true;
            this.RadioAnswerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAnswerC.Location = new System.Drawing.Point(43, 299);
            this.RadioAnswerC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioAnswerC.Name = "RadioAnswerC";
            this.RadioAnswerC.Size = new System.Drawing.Size(140, 29);
            this.RadioAnswerC.TabIndex = 10;
            this.RadioAnswerC.Text = "C. Answer 3";
            this.RadioAnswerC.UseVisualStyleBackColor = true;
            // 
            // RadioAnswerD
            // 
            this.RadioAnswerD.AutoSize = true;
            this.RadioAnswerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAnswerD.Location = new System.Drawing.Point(43, 391);
            this.RadioAnswerD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioAnswerD.Name = "RadioAnswerD";
            this.RadioAnswerD.Size = new System.Drawing.Size(139, 29);
            this.RadioAnswerD.TabIndex = 11;
            this.RadioAnswerD.Text = "D. Answer 4";
            this.RadioAnswerD.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(538, 767);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(161, 58);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.Location = new System.Drawing.Point(1087, 55);
            this.reportLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(105, 21);
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
            this.CorrectLabel.Location = new System.Drawing.Point(934, 758);
            this.CorrectLabel.Name = "CorrectLabel";
            this.CorrectLabel.Size = new System.Drawing.Size(260, 50);
            this.CorrectLabel.TabIndex = 15;
            this.CorrectLabel.Text = " CORRECT";
            this.CorrectLabel.Visible = false;
            // 
            // WrongLabel
            // 
            this.WrongLabel.AutoSize = true;
            this.WrongLabel.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongLabel.ForeColor = System.Drawing.Color.Red;
            this.WrongLabel.Location = new System.Drawing.Point(905, 767);
            this.WrongLabel.Name = "WrongLabel";
            this.WrongLabel.Size = new System.Drawing.Size(315, 50);
            this.WrongLabel.TabIndex = 16;
            this.WrongLabel.Text = " INCORRECT";
            this.WrongLabel.Visible = false;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProgressLabel.Location = new System.Drawing.Point(172, 86);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(102, 23);
            this.ProgressLabel.TabIndex = 17;
            this.ProgressLabel.Text = "Progress: ";
            // 
            // SaveQuestionButton
            // 
            this.SaveQuestionButton.BackColor = System.Drawing.Color.Orange;
            this.SaveQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveQuestionButton.Location = new System.Drawing.Point(64, 758);
            this.SaveQuestionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveQuestionButton.Name = "SaveQuestionButton";
            this.SaveQuestionButton.Size = new System.Drawing.Size(308, 67);
            this.SaveQuestionButton.TabIndex = 18;
            this.SaveQuestionButton.Text = "Add to Study Group";
            this.SaveQuestionButton.UseVisualStyleBackColor = false;
            this.SaveQuestionButton.Visible = false;
            this.SaveQuestionButton.Click += new System.EventHandler(this.SaveQuestionButton_Click);
            // 
            // StudyGroupLink
            // 
            this.StudyGroupLink.AutoSize = true;
            this.StudyGroupLink.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyGroupLink.Location = new System.Drawing.Point(1087, 87);
            this.StudyGroupLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudyGroupLink.Name = "StudyGroupLink";
            this.StudyGroupLink.Size = new System.Drawing.Size(189, 21);
            this.StudyGroupLink.TabIndex = 19;
            this.StudyGroupLink.TabStop = true;
            this.StudyGroupLink.Text = "View My Study Group";
            this.StudyGroupLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StudyGroupLink_LinkClicked);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(538, 767);
            this.NextButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(161, 58);
            this.NextButton.TabIndex = 20;
            this.NextButton.Text = "Next Question";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Visible = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.Color.Orange;
            this.NewGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameButton.Location = new System.Drawing.Point(538, 759);
            this.NewGameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(161, 65);
            this.NewGameButton.TabIndex = 21;
            this.NewGameButton.Text = "Start a New Game";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Visible = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // QuizPanel
            // 
            this.QuizPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.QuizPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuizPanel.Controls.Add(this.RadioAnswerB);
            this.QuizPanel.Controls.Add(this.QuestionNumberLabel);
            this.QuizPanel.Controls.Add(this.QuestionLabel);
            this.QuizPanel.Controls.Add(this.RadioAnswerA);
            this.QuizPanel.Controls.Add(this.RadioAnswerC);
            this.QuizPanel.Controls.Add(this.RadioAnswerD);
            this.QuizPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QuizPanel.Location = new System.Drawing.Point(20, 153);
            this.QuizPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuizPanel.Name = "QuizPanel";
            this.QuizPanel.Size = new System.Drawing.Size(1254, 442);
            this.QuizPanel.TabIndex = 22;
            // 
            // ExplanationRichText
            // 
            this.ExplanationRichText.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExplanationRichText.ForeColor = System.Drawing.Color.SeaGreen;
            this.ExplanationRichText.Location = new System.Drawing.Point(20, 615);
            this.ExplanationRichText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExplanationRichText.Name = "ExplanationRichText";
            this.ExplanationRichText.Size = new System.Drawing.Size(1253, 117);
            this.ExplanationRichText.TabIndex = 23;
            this.ExplanationRichText.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, -3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(140, 149);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // PlayerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1299, 845);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ExplanationRichText);
            this.Controls.Add(this.QuizPanel);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.StudyGroupLink);
            this.Controls.Add(this.SaveQuestionButton);
            this.Controls.Add(this.WrongLabel);
            this.Controls.Add(this.CorrectLabel);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.QuestionProgressLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategoryHeaderLabel);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.HelloLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1317, 1037);
            this.MinimumSize = new System.Drawing.Size(1317, 822);
            this.Name = "PlayerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiddie Cash Komprehension";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayerDashboard_FormClosed);
            this.QuizPanel.ResumeLayout(false);
            this.QuizPanel.PerformLayout();
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
        private System.Windows.Forms.Panel QuizPanel;
        private System.Windows.Forms.RichTextBox ExplanationRichText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}