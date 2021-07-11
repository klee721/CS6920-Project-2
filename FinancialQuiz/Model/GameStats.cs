using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialQuiz.Model
{
    public class GameStats
    {
        public int GameID { get; set; }

        public int userID { get; set; }

        public int totalQuestions { get; set; }

        public string compIndex { get; set; }

        public int questionsCorrect { get; set; }

        public int questionsMissed { get; set; }

        public int score { get; set; }

    }
}
