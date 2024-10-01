using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace HTML_Form_Controls_Example
{
    public class CourseFeedback
    {
        private List<string> courseRatings;
        /*private List<double> courseValue;*/

        public CourseFeedback()
        {
            courseRatings = new List<string>();
            /*courseValue = new List<double>();*/
        }

        public CourseFeedback(List<string> courseRatings)
        {
            this.courseRatings = courseRatings;
            /*this.courseValue = courseValue;*/
        }

        public List<String> CourseRatings
        {
            get { return courseRatings; }
            set { courseRatings = value; }
        }
    }
}