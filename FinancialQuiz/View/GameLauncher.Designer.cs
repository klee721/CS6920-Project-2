
namespace FinancialQuiz.View
{
    partial class GameLauncher
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
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NumberOfQuestionsLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BeginGameButton = new System.Windows.Forms.Button();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.NewGameTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(60, 161);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(75, 16);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(145, 159);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(191, 21);
            this.CategoryComboBox.TabIndex = 1;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(80, 234);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(44, 16);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Age: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(62, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // NumberOfQuestionsLabel
            // 
            this.NumberOfQuestionsLabel.AutoSize = true;
            this.NumberOfQuestionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfQuestionsLabel.Location = new System.Drawing.Point(41, 316);
            this.NumberOfQuestionsLabel.Name = "NumberOfQuestionsLabel";
            this.NumberOfQuestionsLabel.Size = new System.Drawing.Size(85, 32);
            this.NumberOfQuestionsLabel.TabIndex = 4;
            this.NumberOfQuestionsLabel.Text = "Number of \r\nQuestions: ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(145, 327);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(62, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // BeginGameButton
            // 
            this.BeginGameButton.Location = new System.Drawing.Point(181, 436);
            this.BeginGameButton.Name = "BeginGameButton";
            this.BeginGameButton.Size = new System.Drawing.Size(128, 57);
            this.BeginGameButton.TabIndex = 6;
            this.BeginGameButton.Text = "Begin Game";
            this.BeginGameButton.UseVisualStyleBackColor = true;
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Location = new System.Drawing.Point(142, 65);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(177, 13);
            this.InstructionsLabel.TabIndex = 7;
            this.InstructionsLabel.Text = "Please select your game parameters";
            // 
            // NewGameTitleLabel
            // 
            this.NewGameTitleLabel.AutoSize = true;
            this.NewGameTitleLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameTitleLabel.Location = new System.Drawing.Point(141, 26);
            this.NewGameTitleLabel.Name = "NewGameTitleLabel";
            this.NewGameTitleLabel.Size = new System.Drawing.Size(187, 22);
            this.NewGameTitleLabel.TabIndex = 8;
            this.NewGameTitleLabel.Text = "Create a New Game";
            // 
            // GameLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 531);
            this.Controls.Add(this.NewGameTitleLabel);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.BeginGameButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.NumberOfQuestionsLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.MaximizeBox = false;
            this.Name = "GameLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameLauncher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label NumberOfQuestionsLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BeginGameButton;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Label NewGameTitleLabel;
    }
}