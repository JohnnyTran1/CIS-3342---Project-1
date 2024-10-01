using HTML_Form_Controls_Example.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace HTML_Form_Controls_Example
{
    public partial class survey : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.Form["txtName"];
            string studentID = Request.Form["txtStudentId"];
            string course = Request.Form["ddlCourse"];

            //The object of the StudentInfo class will take the input from the survey.html that was request from the web browser
            StudentInfo student = new StudentInfo(name, studentID, course);

            //label in the aspx will display the object data from the StudentInfo Class
            lblStudentInfo.Text = $"Name: {student.Name}<br>" +
                      $"Student ID: {student.StudentID}<br>" +
                      $"Course: {student.Course}<br>";


            //I create two seperate list string for each course and professor feedback to retieve the values from the request.form
            /*Instead of doing 20 lines of creating new fields to get each Request.Form of 20 questions
             * 12 questions from course & 8 questions from professor questions
             * Why not just do a forloop since the name and Id values are basically just Q1 or Q of some numeber
             * And that number goes up until to reach to Q20
             * Q1-Q12 are basically all course questions
             * Q13-Q20 are all just professor questions
             * I could have done this way:
             *          string Question1 = Request.Form["Q1"];
             *          string Question2 = Request.Form["Q2"];
             *          string Question3 = Request.Form["Q3"];
             *          string Question4 = Request.Form["Q4"];

             */
            List<string> courseFeedback = new List<string>();

            List<string> professorFeedback = new List<string>();

            for (int i = 1; i <= 20; i++)
            {
                string result = (Request.Form[$"Q{i}"]);
                if (i <= 12)
                {
                    courseFeedback.Add(result);
                }
                else
                {
                    professorFeedback.Add(result);
                }
            }

            //The object courseResult of the CourseFeedback class will display all the radio button input values that user selected for
            CourseFeedback courseResult = new CourseFeedback(courseFeedback);
            for (int i = 0; i < courseResult.CourseRatings.Count; i++)
            {
                string question = courseQuestions[i];
                string feedback = courseResult.CourseRatings[i];
                lblCourseAnswers.Text += $"{question}: {feedback}<br>";
            }

            //The object professorResult of the ProfessorFeedback class will display all the radio button input values that user selected for
            ProfessorFeedback professorResult = new ProfessorFeedback(professorFeedback);
            for (int i = 0; i < professorResult.ProfessorRatings.Count; i++)
            {
                string question = professorquestions[i];
                string feedback = professorResult.ProfessorRatings[i];
                lblProfessorAnswers.Text += $"{question}: {feedback}<br>";
            }

            //display the letter grade and average grade for both professor and course
            CourseCalculator courseCalculator = new CourseCalculator();

            double courseAverage = courseCalculator.CalculateCourseAverageScore(courseFeedback);
            string courseLetterGrade = courseCalculator.GetLetterGrade(courseAverage);
            lblCourseGrade.Text = $"Course Average: {courseAverage}%<br>Course Grade: {courseLetterGrade}<br>";

            ProfessorCalculator professorCalculator = new ProfessorCalculator();

            double professorAverage = professorCalculator.CalculateProfessorAverageScore(professorFeedback);
            string professorLetterGrade = professorCalculator.GetLetterGrade(professorAverage);
            lblProfessorGrade.Text = $"Professor Average: {professorAverage}%<br>Professor Grade: {professorLetterGrade}<br>";
        }


        //For getting the questions in the IIS and aspx was too complex and hard for me because I wrote the questions in <h4> tags in html page
        //Create two array that has all 20 questions to display it with the result page with what the user selected.
        private string[] courseQuestions = new string[]
        {
            "Question 1: The course objectives were clear and defined.",
            "Question 2: The course materials were relevant and useful.",
            "Question 3: The course workload was manageable and appropriate for the credit hours.",
            "Question 4: The structure and organization of the course facilitated learning.",
            "Question 5: The course provided opportunities for interaction and discussion.",
            "Question 6: Assignments and projects contributed significantly to my understanding of the subject.",
            "Question 7: The grading system was clear, and the feedback on assignments was constructive.",
            "Question 8: The course was challenging but achievable, promoting critical thinking and problem solving skills.",
            "Question 9: The course integrated practical examples and real world applications.",
            "Question 10: There were sufficient resources and support available outside of class.",
            "Question 11: You put alot of into this course compared to others.",
            "Question 12:You would like to retake the course again."
        };

        private string[] professorquestions = new string[]
        {
            "Question 13: The professor demonstrated a thorough knowledge of the subject.",
            "Question 14: The professor communicated the content effectively and clearly.",
            "Question 15: The professor was approachable and willing to assist students outside of class.",
            "Question 16: The professor encouraged questions, and addressed them with adequate explanations.",
            "Question 17: The professor created a classroom atmosphere that was conducive to learning.",
            "Question 18: The professor used a variety of teaching methods to cater to different learning styles.",
            "Question 19: The professor provided timely and constructive feedback on assignments and exams.",
            "Question 20: The professor treated all students with respect and fairness."
        };
    }
}