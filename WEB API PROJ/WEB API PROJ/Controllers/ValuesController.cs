using BAL;
using HELPER;
using System;
using System.Collections.Generic;
using WEB_API_PROJ.Models;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEB_API_PROJ.Controllers
{
    public class ValuesController : ApiController
    {
        helper obj = null;
        public ValuesController()
        {
            obj = new helper();
        }
        [HttpGet]
        public List<StudentsModel> marklist()
        {
            //return new string[] { "value1", "value2" };

            List<bal> empbal = new List<bal>();
            empbal = obj.listmarks();
            List<StudentsModel> emps = new List<StudentsModel>();
            foreach (var item in empbal)
            {
                //Employees emp = new Employees();
                emps.Add(new StudentsModel
                {
                    student_id = item.student_id,
                    student_name = item.student_name,
                    subject_marks = item.subject_marks
                });
            }
            return emps;
        }
        public StudentsModel marksbyid(int id)
        {
            bal empbal = new bal();
            empbal = obj.searchmarks(id);
            StudentsModel emp = new StudentsModel();
            emp.student_id = empbal.student_id;
            emp.student_name = empbal.student_name;
            emp.subject_marks = empbal.subject_marks;

            return emp;
           
        }

        // POST api/<controller>
        public HttpResponseMessage Postmarks([FromBody] StudentsModel empdata)
        {
            bal empbal = new bal();
            empbal.student_id = empdata.student_id;
            empbal.student_name = empdata.student_name;
            empbal.subject_marks = empdata.subject_marks;



            bool ans = obj.Addmarks(empbal);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

        }

        
        [HttpPut]


        public HttpResponseMessage Putmarks([FromBody] StudentsModel empdata)
        {

            bal empbal = new bal();
            empbal.student_id = empdata.student_id;
            empbal.student_name = empdata.student_name;
            empbal.subject_marks = empdata.subject_marks;

            bool ans = obj.Editmarks(empbal);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }

       
        public HttpResponseMessage Deletemarks(int id)
        {
            bool ans = obj.removemarks(id);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

        }

    }
}
