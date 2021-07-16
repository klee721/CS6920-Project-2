
namespace FinancialQuiz.View
{
    partial class AdminDashboard
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
            this.PlayerDashTabControl = new System.Windows.Forms.TabControl();
            this.QuestionsTab = new System.Windows.Forms.TabPage();
            this.manageQuestionControl1 = new FinancialQuiz.UserControls.ManageQuestionControl();
            this.UsersTab = new System.Windows.Forms.TabPage();
            this.manageUserControl1 = new FinancialQuiz.UserControls.ManageUserControl();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.PlayerDashTabControl.SuspendLayout();
            this.QuestionsTab.SuspendLayout();
            this.UsersTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerDashTabControl
            // 
            this.PlayerDashTabControl.Controls.Add(this.QuestionsTab);
            this.PlayerDashTabControl.Controls.Add(this.UsersTab);
            this.PlayerDashTabControl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerDashTabControl.Location = new System.Drawing.Point(0, 65);
            this.PlayerDashTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerDashTabControl.Name = "PlayerDashTabControl";
            this.PlayerDashTabControl.SelectedIndex = 0;
            this.PlayerDashTabControl.Size = new System.Drawing.Size(1491, 1200);
            this.PlayerDashTabControl.TabIndex = 1;
            // 
            // QuestionsTab
            // 
            this.QuestionsTab.Controls.Add(this.manageQuestionControl1);
            this.QuestionsTab.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.QuestionsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionsTab.Location = new System.Drawing.Point(4, 32);
            this.QuestionsTab.Margin = new System.Windows.Forms.Padding(4);
            this.QuestionsTab.Name = "QuestionsTab";
            this.QuestionsTab.Padding = new System.Windows.Forms.Padding(4);
            this.QuestionsTab.Size = new System.Drawing.Size(1483, 1164);
            this.QuestionsTab.TabIndex = 0;
            this.QuestionsTab.Text = "Questions                        ";
            this.QuestionsTab.UseVisualStyleBackColor = true;
            // 
            // manageQuestionControl1
            // 
            this.manageQuestionControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.manageQuestionControl1.Location = new System.Drawing.Point(-8, 0);
            this.manageQuestionControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageQuestionControl1.Name = "manageQuestionControl1";
            this.manageQuestionControl1.Size = new System.Drawing.Size(1495, 957);
            this.manageQuestionControl1.TabIndex = 0;
            // 
            // UsersTab
            // 
            this.UsersTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UsersTab.Controls.Add(this.manageUserControl1);
            this.UsersTab.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UsersTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersTab.Location = new System.Drawing.Point(4, 32);
            this.UsersTab.Margin = new System.Windows.Forms.Padding(4);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Padding = new System.Windows.Forms.Padding(4);
            this.UsersTab.Size = new System.Drawing.Size(1483, 1164);
            this.UsersTab.TabIndex = 1;
            this.UsersTab.Text = "Users                                 ";
            // 
            // manageUserControl1
            // 
            this.manageUserControl1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.manageUserControl1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUserControl1.Location = new System.Drawing.Point(7, 0);
            this.manageUserControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageUserControl1.Name = "manageUserControl1";
            this.manageUserControl1.Size = new System.Drawing.Size(1112, 782);
            this.manageUserControl1.TabIndex = 0;
            // 
            // LogoutLink
            // 
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLink.Location = new System.Drawing.Point(1171, 50);
            this.LogoutLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(68, 21);
            this.LogoutLink.TabIndex = 5;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Logout";
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.UserNameLabel.Location = new System.Drawing.Point(1220, 15);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(231, 22);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "XXXXXXXXXXXXXXXXX";
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.HelloLabel.Location = new System.Drawing.Point(1171, 15);
            this.HelloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(53, 22);
            this.HelloLabel.TabIndex = 3;
            this.HelloLabel.Text = "Hello";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1488, 1055);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.PlayerDashTabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1506, 1400);
            this.MinimumSize = new System.Drawing.Size(1506, 1028);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.PlayerDashTabControl.ResumeLayout(false);
            this.QuestionsTab.ResumeLayout(false);
            this.UsersTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl PlayerDashTabControl;
        private System.Windows.Forms.TabPage QuestionsTab;
        private System.Windows.Forms.TabPage UsersTab;
        private UserControls.ManageUserControl manageUserControl1;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label HelloLabel;
        private UserControls.ManageQuestionControl manageQuestionControl1;
    }
}