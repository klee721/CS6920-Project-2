﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialQuiz.DAL;
using FinancialQuiz.Model;

namespace FinancialQuiz.Controller
{
   

    public class QuestionController
    {
        QuestionDAL questionDAL;

        public QuestionController()
        {
            this.questionDAL = new QuestionDAL();
        }

        /// <summary>
        /// Methos to retrieve the first question in the DB for demo and development purposes
        /// </summary>
        /// <returns>A question object populated from the DB</returns>
        public Question GetSampleQuestion()
        {
            return this.questionDAL.GetSampleQuestion();
        }
        
    }
}