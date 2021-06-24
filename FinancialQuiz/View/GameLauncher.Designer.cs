
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
            this.AgeComboBox = new System.Windows.Forms.ComboBox();
            this.NumberOfQuestionsLabel = new System.Windows.Forms.Label();
            this.BeginGameButton = new System.Windows.Forms.Button();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.NewGameTitleLabel = new System.Windows.Forms.Label();
            this.NumberOfQuestionsNumUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfQuestionsNumUpDown)).BeginInit();
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
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // AgeComboBox
            // 
            this.AgeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgeComboBox.FormattingEnabled = true;
            this.AgeComboBox.Location = new System.Drawing.Point(145, 237);
            this.AgeComboBox.Name = "AgeComboBox";
            this.AgeComboBox.Size = new System.Drawing.Size(62, 21);
            this.AgeComboBox.TabIndex = 3;
            // 
            // NumberOfQuestionsLabel
            // 
            this.NumberOfQuestionsLabel.AutoSize = true;
            this.NumberOfQuestionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfQuestionsLabel.Location = new System.Drawing.Point(41, 316);
            this.NumberOfQuestionsLabel.Name = "NumberOfQuestionsLabel";
            this.NumberOfQuestionsLabel.Size = new System.Drawing.Size(89, 48);
            this.NumberOfQuestionsLabel.TabIndex = 4;
            this.NumberOfQuestionsLabel.Text = "Number of \r\nQuestions:  \r\n(5 - 20)";
            // 
            // BeginGameButton
            // 
            this.BeginGameButton.Location = new System.Drawing.Point(181, 436);
            this.BeginGameButton.Name = "BeginGameButton";
            this.BeginGameButton.Size = new System.Drawing.Size(128, 57);
            this.BeginGameButton.TabIndex = 6;
            this.BeginGameButton.Text = "Begin Game";
            this.BeginGameButton.UseVisualStyleBackColor = true;
            this.BeginGameButton.Click += new System.EventHandler(this.BeginGameButton_Click);
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
            // NumberOfQuestionsNumUpDown
            // 
            this.NumberOfQuestionsNumUpDown.Location = new System.Drawing.Point(145, 328);
            this.NumberOfQuestionsNumUpDown.Name = "NumberOfQuestionsNumUpDown";
            this.NumberOfQuestionsNumUpDown.Size = new System.Drawing.Size(62, 20);
            this.NumberOfQuestionsNumUpDown.TabIndex = 9;
            this.NumberOfQuestionsNumUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // GameLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 531);
            this.Controls.Add(this.NumberOfQuestionsNumUpDown);
            this.Controls.Add(this.NewGameTitleLabel);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.BeginGameButton);
            this.Controls.Add(this.NumberOfQuestionsLabel);
            this.Controls.Add(this.AgeComboBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.MaximizeBox = false;
            this.Name = "GameLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameLauncher";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfQuestionsNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.ComboBox AgeComboBox;
        private System.Windows.Forms.Label NumberOfQuestionsLabel;
        private System.Windows.Forms.Button BeginGameButton;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Label NewGameTitleLabel;
        private System.Windows.Forms.NumericUpDown NumberOfQuestionsNumUpDown;
    }
}