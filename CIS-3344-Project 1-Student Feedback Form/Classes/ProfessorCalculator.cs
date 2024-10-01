using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTML_Form_Controls_Example.Classes
{
    public class ProfessorCalculator
    {
        //Field that always 8 - total professor questions will remain the saem
        private const int professorTotalQuestions = 8;
        //Dictionary that respresentation and correspond to values that will be use for calculation
        private Dictionary<string, double> ratingValues = new Dictionary<string, double>
        {
            {"StronglyAgree", 1},
            {"Agree", 0.8},
            {"Neutral", 0.6},
            {"Disagree", 0.4},
            {"StronglyDisagree", 0.20}
        };

        //calculation  to get the average score for course
        public double CalculateProfessorAverageScore(List<string> professorRatings)
        {
            double totalScore = 0;
            foreach (string rating in professorRatings)
            {
                totalScore += ratingValues[rating];
            }
            double score = Math.Round(((totalScore / professorTotalQuestions) * 100), 2);

            return score;
        }

        //if statement to converts pecentage score to a letter grade
        public string GetLetterGrade(double averageScore)
        {
            if (averageScore >= 90)
            {
                return "A";
            }
            else if (averageScore >= 80)
            {
                return "B";
            }
            else if (averageScore >= 70)
            {
                return "C";
            }
            else if (averageScore >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
