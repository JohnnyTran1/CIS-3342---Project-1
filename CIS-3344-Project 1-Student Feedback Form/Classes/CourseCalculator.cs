using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTML_Form_Controls_Example
{
    public class CourseCalculator
    {
        //Field that always 12 - total course questions will remain the saem
        private const int courseTotalQuestions = 12;
       //Dictionary that respresentation and correspond to values that will be use for calculation
        private Dictionary<string, double> ratingValues = new Dictionary<string, double>
        {
            {"StronglyAgree", 1},
            {"Agree", 0.8},
            {"Neutral", 0.6},
            {"Disagree", 0.4},
            {"StronglyDisagree", 0.2}
        };

        //calculation  to get the average score for course
        public double CalculateCourseAverageScore(List<string> courseRatings)
        {
            double totalScore = 0;
            foreach (string rating in courseRatings)
            {
                totalScore += ratingValues[rating];
            }
            double score = Math.Round(((totalScore / courseTotalQuestions) * 100), 2);

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