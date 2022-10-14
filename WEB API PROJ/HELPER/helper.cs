using BAL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELPER
{
    public class helper
    {
        dal dal = null;
        public helper()
        {
            dal = new dal();
        }


        public bool Addmarks(bal employee)
        {
            return dal.Insert(employee);

        }

        public bool Editmarks(bal employee)
        {
            return dal.Update(employee);
        }

        public bal searchmarks(int empid)
        {
            return dal.Find(empid);
        }
        public List<bal> listmarks()
        {
            return dal.list();
        }
        public bool removemarks(int employee_id)
        {
            return dal.Delete(employee_id);
        }
    }
}
