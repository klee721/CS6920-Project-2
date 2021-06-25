using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialQuiz.Model;

namespace FinancialQuiz.View
{
    public partial class StudyGroup : Form
    {
        public StudyGroup()
        {
            InitializeComponent();
           
        }

        public void SetUser(User user)
        {
            label1.Text = user.FirstName;
        }

        private void AnswerDisplayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CorrectAnswer.Visible == false)
            {
                this.CorrectAnswer.Visible = true;
            }
            else
            {
                this.CorrectAnswer.Visible = false;
            }
        }
    }
}
