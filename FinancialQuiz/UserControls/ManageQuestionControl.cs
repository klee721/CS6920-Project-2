using FinancialQuiz.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialQuiz.UserControls
{
    public partial class ManageQuestionControl : UserControl
    {
        private readonly QuestionController questionController;
        public ManageQuestionControl()
        {
            InitializeComponent();
            this.questionController = new QuestionController();
        }

    }
}
