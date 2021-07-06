
namespace FinancialQuiz.View
{
    partial class BackupUserStatsForm
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
            this.StatsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // StatsListView
            // 
            this.StatsListView.HideSelection = false;
            this.StatsListView.Location = new System.Drawing.Point(12, 12);
            this.StatsListView.Name = "StatsListView";
            this.StatsListView.Size = new System.Drawing.Size(888, 407);
            this.StatsListView.TabIndex = 0;
            this.StatsListView.UseCompatibleStateImageBehavior = false;
            // 
            // BackupUserStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 431);
            this.Controls.Add(this.StatsListView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(928, 470);
            this.MinimumSize = new System.Drawing.Size(928, 470);
            this.Name = "BackupUserStatsForm";
            this.Text = "BackupUserStatsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView StatsListView;
    }
}