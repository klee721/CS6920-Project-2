using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialQuiz.Model
{
    /// <summary>
    /// Model class for Question object
    /// </summary>
    class Question
    {
        public int QuestionID { get; set; }

        public string Description { get; set; }

        public string OptionA { get; set; }

        public string OptionB { get; set; }

        public string OptionC { get; set; }

        public string OptionD { get; set; }

        public string CorrectOption { get; set; }

        public int AgeRangeID { get; set; }

        public int CategoryID { get; set; }

        public int GameLevelID { get; set; }

    }
}
