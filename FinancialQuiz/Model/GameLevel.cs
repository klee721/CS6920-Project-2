using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialQuiz.Model
{
    /// <summary>
    /// Class representing a Game Level in the DB.
    /// </summary>
     public class GameLevel
    {
            public int GameLevelID { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

    }
}
