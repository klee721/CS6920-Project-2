
namespace FinancialQuiz.View
{
    partial class StudyGroup
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
            this.FavoritesDataGrid = new System.Windows.Forms.DataGridView();
            this.QuestionText = new System.Windows.Forms.Label();
            this.CorrectAnswer = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AnswerDisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FavoritesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FavoritesDataGrid
            // 
            this.FavoritesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FavoritesDataGrid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.FavoritesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FavoritesDataGrid.Location = new System.Drawing.Point(31, 310);
            this.FavoritesDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.FavoritesDataGrid.Name = "FavoritesDataGrid";
            this.FavoritesDataGrid.RowHeadersWidth = 51;
            this.FavoritesDataGrid.Size = new System.Drawing.Size(1115, 214);
            this.FavoritesDataGrid.TabIndex = 0;
            this.FavoritesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FavoritesDataGrid_CellContentClick);
            // 
            // QuestionText
            // 
            this.QuestionText.AutoSize = true;
            this.QuestionText.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionText.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.QuestionText.Location = new System.Drawing.Point(180, 63);
            this.QuestionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuestionText.MaximumSize = new System.Drawing.Size(933, 0);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(9, 19);
            this.QuestionText.TabIndex = 8;
            this.QuestionText.Text = "\r\n";
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.AutoSize = true;
            this.CorrectAnswer.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectAnswer.ForeColor = System.Drawing.Color.DarkOrange;
            this.CorrectAnswer.Location = new System.Drawing.Point(180, 134);
            this.CorrectAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CorrectAnswer.MaximumSize = new System.Drawing.Size(933, 0);
            this.CorrectAnswer.Name = "CorrectAnswer";
            this.CorrectAnswer.Size = new System.Drawing.Size(0, 19);
            this.CorrectAnswer.TabIndex = 9;
            this.CorrectAnswer.Visible = false;
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AnswerLabel.Location = new System.Drawing.Point(44, 134);
            this.AnswerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AnswerLabel.MaximumSize = new System.Drawing.Size(1067, 0);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(87, 23);
            this.AnswerLabel.TabIndex = 10;
            this.AnswerLabel.Text = "Answer:";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.QuestionLabel.Location = new System.Drawing.Point(44, 63);
            this.QuestionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuestionLabel.MaximumSize = new System.Drawing.Size(1067, 0);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(103, 23);
            this.QuestionLabel.TabIndex = 11;
            this.QuestionLabel.Text = "Question:";
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Orange;
            this.RemoveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(923, 241);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(223, 62);
            this.RemoveButton.TabIndex = 12;
            this.RemoveButton.Text = "Remove Question";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1116, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // AnswerDisplayCheckBox
            // 
            this.AnswerDisplayCheckBox.AutoSize = true;
            this.AnswerDisplayCheckBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerDisplayCheckBox.Location = new System.Drawing.Point(49, 182);
            this.AnswerDisplayCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.AnswerDisplayCheckBox.Name = "AnswerDisplayCheckBox";
            this.AnswerDisplayCheckBox.Size = new System.Drawing.Size(162, 25);
            this.AnswerDisplayCheckBox.TabIndex = 14;
            this.AnswerDisplayCheckBox.Text = "Display Answers";
            this.AnswerDisplayCheckBox.UseVisualStyleBackColor = true;
            this.AnswerDisplayCheckBox.CheckedChanged += new System.EventHandler(this.AnswerDisplayCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 283);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Click a row to select a question";
            // 
            // StudyGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1176, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnswerDisplayCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.CorrectAnswer);
            this.Controls.Add(this.QuestionText);
            this.Controls.Add(this.FavoritesDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1194, 591);
            this.MinimumSize = new System.Drawing.Size(1194, 591);
            this.Name = "StudyGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudyGroup";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.FavoritesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FavoritesDataGrid;
        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.Label CorrectAnswer;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AnswerDisplayCheckBox;
        private System.Windows.Forms.Label label2;
    }
}