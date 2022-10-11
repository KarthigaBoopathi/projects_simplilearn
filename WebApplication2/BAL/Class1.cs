using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class subjects
    {
        public int subject_id { get; set; }
        public string subject_name { get; set; }
    }
    public class classes
    {
        public int class_roomno { get; set; }
        public int class_strength { get; set; }
    }
    public class students
    {
        public int student_id { get; set; }
        public string student_name { get; set; }
        public int student_class { get; set; }

    }
}
