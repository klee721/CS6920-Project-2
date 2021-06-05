
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
            this.PlayerDashTabControl = new System.Windows.Forms.TabControl();
            this.QuizTab = new System.Windows.Forms.TabPage();
            this.StatsTab = new System.Windows.Forms.TabPage();
            this.PlayerDashTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerDashTabControl
            // 
            this.PlayerDashTabControl.Controls.Add(this.QuizTab);
            this.PlayerDashTabControl.Controls.Add(this.StatsTab);
            this.PlayerDashTabControl.Location = new System.Drawing.Point(2, 3);
            this.PlayerDashTabControl.Name = "PlayerDashTabControl";
            this.PlayerDashTabControl.SelectedIndex = 0;
            this.PlayerDashTabControl.Size = new System.Drawing.Size(1118, 625);
            this.PlayerDashTabControl.TabIndex = 0;
            // 
            // QuizTab
            // 
            this.QuizTab.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.QuizTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizTab.Location = new System.Drawing.Point(4, 22);
            this.QuizTab.Name = "QuizTab";
            this.QuizTab.Padding = new System.Windows.Forms.Padding(3);
            this.QuizTab.Size = new System.Drawing.Size(1110, 599);
            this.QuizTab.TabIndex = 0;
            this.QuizTab.Text = "Quiz                   ";
            this.QuizTab.UseVisualStyleBackColor = true;
            // 
            // StatsTab
            // 
            this.StatsTab.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StatsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsTab.Location = new System.Drawing.Point(4, 22);
            this.StatsTab.Name = "StatsTab";
            this.StatsTab.Padding = new System.Windows.Forms.Padding(3);
            this.StatsTab.Size = new System.Drawing.Size(1110, 599);
            this.StatsTab.TabIndex = 1;
            this.StatsTab.Text = "My Stats                      ";
            this.StatsTab.UseVisualStyleBackColor = true;
            // 
            // PlayerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 629);
            this.Controls.Add(this.PlayerDashTabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1135, 668);
            this.MinimumSize = new System.Drawing.Size(1135, 668);
            this.Name = "PlayerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerDashboard";
            this.PlayerDashTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PlayerDashTabControl;
        private System.Windows.Forms.TabPage QuizTab;
        private System.Windows.Forms.TabPage StatsTab;
    }
}