
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameLauncher));
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeComboBox = new System.Windows.Forms.ComboBox();
            this.NumberOfQuestionsLabel = new System.Windows.Forms.Label();
            this.BeginGameButton = new System.Windows.Forms.Button();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.NewGameTitleLabel = new System.Windows.Forms.Label();
            this.NumberOfQuestionsNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfQuestionsNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.CategoryLabel.Location = new System.Drawing.Point(107, 181);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(103, 23);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(236, 181);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(191, 24);
            this.CategoryComboBox.TabIndex = 1;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.AgeLabel.Location = new System.Drawing.Point(148, 256);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(59, 23);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Age: ";
            // 
            // AgeComboBox
            // 
            this.AgeComboBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.AgeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeComboBox.FormattingEnabled = true;
            this.AgeComboBox.Location = new System.Drawing.Point(236, 253);
            this.AgeComboBox.Name = "AgeComboBox";
            this.AgeComboBox.Size = new System.Drawing.Size(62, 24);
            this.AgeComboBox.TabIndex = 3;
            // 
            // NumberOfQuestionsLabel
            // 
            this.NumberOfQuestionsLabel.AutoSize = true;
            this.NumberOfQuestionsLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfQuestionsLabel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.NumberOfQuestionsLabel.Location = new System.Drawing.Point(108, 326);
            this.NumberOfQuestionsLabel.Name = "NumberOfQuestionsLabel";
            this.NumberOfQuestionsLabel.Size = new System.Drawing.Size(114, 69);
            this.NumberOfQuestionsLabel.TabIndex = 4;
            this.NumberOfQuestionsLabel.Text = "Number of \r\nQuestions:  \r\n(5-10)";
            // 
            // BeginGameButton
            // 
            this.BeginGameButton.BackColor = System.Drawing.Color.Orange;
            this.BeginGameButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginGameButton.ForeColor = System.Drawing.Color.White;
            this.BeginGameButton.Location = new System.Drawing.Point(233, 431);
            this.BeginGameButton.Name = "BeginGameButton";
            this.BeginGameButton.Size = new System.Drawing.Size(128, 57);
            this.BeginGameButton.TabIndex = 6;
            this.BeginGameButton.Text = "Begin Game";
            this.BeginGameButton.UseVisualStyleBackColor = false;
            this.BeginGameButton.Click += new System.EventHandler(this.BeginGameButton_Click);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.InstructionsLabel.Location = new System.Drawing.Point(211, 91);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(246, 16);
            this.InstructionsLabel.TabIndex = 7;
            this.InstructionsLabel.Text = "Please select your game parameters";
            // 
            // NewGameTitleLabel
            // 
            this.NewGameTitleLabel.AutoSize = true;
            this.NewGameTitleLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameTitleLabel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.NewGameTitleLabel.Location = new System.Drawing.Point(229, 46);
            this.NewGameTitleLabel.Name = "NewGameTitleLabel";
            this.NewGameTitleLabel.Size = new System.Drawing.Size(224, 25);
            this.NewGameTitleLabel.TabIndex = 8;
            this.NewGameTitleLabel.Text = "Create a New Game";
            // 
            // NumberOfQuestionsNumUpDown
            // 
            this.NumberOfQuestionsNumUpDown.BackColor = System.Drawing.SystemColors.MenuBar;
            this.NumberOfQuestionsNumUpDown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfQuestionsNumUpDown.Location = new System.Drawing.Point(236, 342);
            this.NumberOfQuestionsNumUpDown.Name = "NumberOfQuestionsNumUpDown";
            this.NumberOfQuestionsNumUpDown.Size = new System.Drawing.Size(62, 23);
            this.NumberOfQuestionsNumUpDown.TabIndex = 9;
            this.NumberOfQuestionsNumUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(153, 152);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // GameLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 531);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.NumberOfQuestionsNumUpDown);
            this.Controls.Add(this.NewGameTitleLabel);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.BeginGameButton);
            this.Controls.Add(this.NumberOfQuestionsLabel);
            this.Controls.Add(this.AgeComboBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.MaximizeBox = false;
            this.Name = "GameLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameLauncher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameLauncher_FormClosed);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}