
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.QuestionText = new System.Windows.Forms.Label();
            this.CorrectAnswer = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(836, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // QuestionText
            // 
            this.QuestionText.AutoSize = true;
            this.QuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionText.Location = new System.Drawing.Point(130, 53);
            this.QuestionText.MaximumSize = new System.Drawing.Size(800, 0);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(226, 40);
            this.QuestionText.TabIndex = 8;
            this.QuestionText.Text = "Using a credit card is most like:\r\n\r\n";
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.AutoSize = true;
            this.CorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectAnswer.Location = new System.Drawing.Point(130, 172);
            this.CorrectAnswer.MaximumSize = new System.Drawing.Size(800, 0);
            this.CorrectAnswer.Name = "CorrectAnswer";
            this.CorrectAnswer.Size = new System.Drawing.Size(105, 20);
            this.CorrectAnswer.TabIndex = 9;
            this.CorrectAnswer.Text = "Both A and D";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabel.Location = new System.Drawing.Point(28, 172);
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
            this.QuestionLabel.Location = new System.Drawing.Point(28, 53);
            this.QuestionLabel.MaximumSize = new System.Drawing.Size(800, 0);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(86, 20);
            this.QuestionLabel.TabIndex = 11;
            this.QuestionLabel.Text = "Question:";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(664, 172);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(167, 50);
            this.RemoveButton.TabIndex = 12;
            this.RemoveButton.Text = "Remove Question";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // StudyGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.CorrectAnswer);
            this.Controls.Add(this.QuestionText);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 489);
            this.MinimumSize = new System.Drawing.Size(900, 489);
            this.Name = "StudyGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudyGroup";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.Label CorrectAnswer;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label label1;
    }
}