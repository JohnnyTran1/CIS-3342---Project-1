using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTML_Form_Controls_Example
{
    public class ProfessorFeedback
    {
        private List<string> professorRatings;

        public ProfessorFeedback()
        {
            professorRatings = new List<string>();
        }

        public ProfessorFeedback(List<string> professorRatings)
        {
            this.professorRatings = professorRatings;
        }
        public List<string> ProfessorRatings
        {
            get { return professorRatings; }
            set { professorRatings = value; }
        }
    }
}