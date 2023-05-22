using BusinessStaffManger.Models.Reservations;
using System.Linq;

namespace BusinessStaffManager.Models.Data
{
    public class DataWorkerBase
    {
        public delegate void EventDelegate();
        public event EventDelegate myEvent = null;

        /*public static string CreateDepartment(string name)
        {
            string result = "Already exist.";

            using (ApplicationContext db = new ApplicationContext())
            {
                //check if already exist
                bool isExist = db.Departments.Any(element => element.Name == name);
                if (!isExist)
                {
                    DepartmentReservation newDepartment = new DepartmentReservation { Name = name };
                    db.Departments.Add(newDepartment);
                    db.SaveChanges();
                    result = "Done !";
                }
                return result;
            }
        }*/
    }
}
