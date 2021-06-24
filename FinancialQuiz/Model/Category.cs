using System;

namespace FinancialQuiz.Model
{
    /// <summary>
    /// Class representing a Category of questions in the DB
    /// </summary>
    public class Category
    {

        public int CategoryID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


    }
}
