using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_API_PROJ.Models
{
    public class StudentsModel
    {
        public int student_id { get; set; }
        public string student_name { get; set; }
        public int subject_marks { get; set; }
    }
}