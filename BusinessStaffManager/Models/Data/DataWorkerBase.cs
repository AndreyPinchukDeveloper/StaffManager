using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManager.Models.Data
{
    public class DataWorkerBase
    {
        public delegate void EventDelegate();
        public event EventDelegate myEvent = null;

        public virtual 

        public static string CreateDepartment(string name)
        {
            string result = "Already exist.";

            using (ApplicationContext db = new ApplicationContext())
            {
                //check if already exist
                bool isExist = db.Departments.Any(element => element.Name == name);
                if (!isExist)
                {
                    Department newDepartment = new Department { Name = name };
                    db.Departments.Add(newDepartment);
                    db.SaveChanges();
                    result = "Done !";
                }
                return result;
            }
        }
    }
}
