
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
            this.FavoritesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FavoritesDataGrid.Location = new System.Drawing.Point(23, 252);
            this.FavoritesDataGrid.Name = "FavoritesDataGrid";
            this.FavoritesDataGrid.Size = new System.Drawing.Size(836, 174);
            this.FavoritesDataGrid.TabIndex = 0;
            this.FavoritesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FavoritesDataGrid_CellContentClick);
            // 
            // QuestionText
            // 
            this.QuestionText.AutoSize = true;
            this.QuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionText.Location = new System.Drawing.Point(135, 51);
            this.QuestionText.MaximumSize = new System.Drawing.Size(700, 0);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(8, 16);
            this.QuestionText.TabIndex = 8;
            this.QuestionText.Text = "\r\n";
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.AutoSize = true;
            this.CorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectAnswer.Location = new System.Drawing.Point(135, 109);
            this.CorrectAnswer.MaximumSize = new System.Drawing.Size(700, 0);
            this.CorrectAnswer.Name = "CorrectAnswer";
            this.CorrectAnswer.Size = new System.Drawing.Size(0, 16);
            this.CorrectAnswer.TabIndex = 9;
            this.CorrectAnswer.Visible = false;
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabel.Location = new System.Drawing.Point(33, 109);
            this.AnswerLabel.MaximumSize = new System.Drawing.Size(800, 0);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(73, 20);
            this.AnswerLabel.TabIndex = 10;
            this.AnswerLabel.Text = "Answer:";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(33, 51);
            this.QuestionLabel.MaximumSize = new System.Drawing.Size(800, 0);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(86, 20);
            this.QuestionLabel.TabIndex = 11;
            this.QuestionLabel.Text = "Question:";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(692, 196);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(167, 50);
            this.RemoveButton.TabIndex = 12;
            this.RemoveButton.Text = "Remove Question";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(837, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // AnswerDisplayCheckBox
            // 
            this.AnswerDisplayCheckBox.AutoSize = true;
            this.AnswerDisplayCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerDisplayCheckBox.Location = new System.Drawing.Point(37, 148);
            this.AnswerDisplayCheckBox.Name = "AnswerDisplayCheckBox";
            this.AnswerDisplayCheckBox.Size = new System.Drawing.Size(127, 20);
            this.AnswerDisplayCheckBox.TabIndex = 14;
            this.AnswerDisplayCheckBox.Text = "Display Answers";
            this.AnswerDisplayCheckBox.UseVisualStyleBackColor = true;
            this.AnswerDisplayCheckBox.CheckedChanged += new System.EventHandler(this.AnswerDisplayCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Double click to select a question";
            // 
            // StudyGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnswerDisplayCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.CorrectAnswer);
            this.Controls.Add(this.QuestionText);
            this.Controls.Add(this.FavoritesDataGrid);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 489);
            this.MinimumSize = new System.Drawing.Size(900, 489);
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