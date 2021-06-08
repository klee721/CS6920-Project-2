
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
            this.UsersTab = new System.Windows.Forms.TabPage();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.PlayerDashTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerDashTabControl
            // 
            this.PlayerDashTabControl.Controls.Add(this.QuestionsTab);
            this.PlayerDashTabControl.Controls.Add(this.UsersTab);
            this.PlayerDashTabControl.Location = new System.Drawing.Point(0, 2);
            this.PlayerDashTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerDashTabControl.Name = "PlayerDashTabControl";
            this.PlayerDashTabControl.SelectedIndex = 0;
            this.PlayerDashTabControl.Size = new System.Drawing.Size(1491, 769);
            this.PlayerDashTabControl.TabIndex = 1;
            // 
            // QuestionsTab
            // 
            this.QuestionsTab.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.QuestionsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionsTab.Location = new System.Drawing.Point(4, 25);
            this.QuestionsTab.Margin = new System.Windows.Forms.Padding(4);
            this.QuestionsTab.Name = "QuestionsTab";
            this.QuestionsTab.Padding = new System.Windows.Forms.Padding(4);
            this.QuestionsTab.Size = new System.Drawing.Size(1483, 740);
            this.QuestionsTab.TabIndex = 0;
            this.QuestionsTab.Text = "Questions                        ";
            this.QuestionsTab.UseVisualStyleBackColor = true;
            this.QuestionsTab.Click += new System.EventHandler(this.QuestionsTab_Click);
            // 
            // UsersTab
            // 
            this.UsersTab.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UsersTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersTab.Location = new System.Drawing.Point(4, 25);
            this.UsersTab.Margin = new System.Windows.Forms.Padding(4);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Padding = new System.Windows.Forms.Padding(4);
            this.UsersTab.Size = new System.Drawing.Size(1483, 740);
            this.UsersTab.TabIndex = 1;
            this.UsersTab.Text = "Users                                 ";
            this.UsersTab.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 764);
            this.Controls.Add(this.PlayerDashTabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1507, 811);
            this.MinimumSize = new System.Drawing.Size(1507, 811);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.PlayerDashTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PlayerDashTabControl;
        private System.Windows.Forms.TabPage QuestionsTab;
        private System.Windows.Forms.TabPage UsersTab;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}