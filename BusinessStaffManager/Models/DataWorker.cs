using BusinessStaffManager.Models.Data;
using System.Collections.Generic;
using System.Linq;
using static BusinessStaffManager.Models.Data.DataWorkerBase;

namespace BusinessStaffManager.Models
{
    public static class DataWorker
    {
        //TODO - need to rebuild and separate logic it's file
        //public event EventDelegate myEvent = null;

        #region GetAllLists
        public static List<Department> GetAllDepartments()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Departments.ToList();
                return result;
            }
        }

        public static List<Position> GetAllPositions()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Positions.ToList();
                return result;
            }
        }

        public static List<Staff> GetAllStaffs()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Staffs.ToList();
                return result;
            }
        }
        #endregion


        #region CreateEntity
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

        public static string CreatePosition(string name, decimal salary, int maxNumber, Department department)
        {
            string result = "Already exist.";

            using (ApplicationContext db = new ApplicationContext())
            {
                //check if already exist
                bool isExist = db.Positions.Any(element => element.Name == name && element.Salary == salary);
                if (!isExist)
                {
                    Position newPosition = new Position
                    {
                        Name = name,
                        Salary = salary,
                        MaxNumber = maxNumber,
                        Id = department.Id
                    };

                    db.Positions.Add(newPosition);
                    db.SaveChanges();
                    result = "Done !";
                }
                return result;
            }
        }

        public static string CreateStaff(string name, string surName, int phone, Position position)
        {
            string result = "Already exist.";

            using (ApplicationContext db = new ApplicationContext())
            {
                //check if already exist
                bool isExist = db.Staffs.Any(element =>
                    element.Name == name &&
                    element.SurName == surName &&
                    element.Phone == phone
                    );

                if (!isExist)
                {
                    Staff newStaff = new Staff
                    {
                        Name = name,
                        SurName = surName,
                        Phone = phone,
                        Id = position.Id
                    };

                    db.Staffs.Add(newStaff);
                    db.SaveChanges();
                    result = "Done !";
                }
                return result;
            }
        }
        #endregion

        #region DeletyEntity
        public static string DeleteDepartment(Department department)
        {
            string result = "This department has already deleted or had never existed.";
            using(ApplicationContext db = new ApplicationContext())
            {
                db.Departments.Remove(department);
                db.SaveChanges();
                result = "This department has been deleted successfully !";
            }
            return result;
        }

        public static string DeletePosition(Position position)
        {
            string result = "This position has already deleted or had never existed.";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Positions.Remove(position);
                db.SaveChanges();
                result = "This position has been deleted successfully !";
            }
            return result;
        }

        public static string DeleteStaff(Staff staff)
        {
            string result = "This staff has already deleted or had never existed.";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Staffs.Remove(staff);
                db.SaveChanges();
                result = "This staff has been deleted successfully !";
            }
            return result;
        }
        #endregion

        #region EditEntity
        public static string EditDepartment(Department departmentToChange, string newName)
        {
            string result = "";
            using (ApplicationContext db = new ApplicationContext())
            {
                Department department = db.Departments.FirstOrDefault(department => department.Id == departmentToChange.Id);
                department.Name = newName;
                db.SaveChanges();
                result = "This department has been changed successfully !";
            }
            return result;
        }

        public static string EditPossition(Position positionToChange, string newName, int newMaxNumber, decimal newSalary, Department newDepartment)
        {
            string result = "";
            using (ApplicationContext db = new ApplicationContext())
            {
                Position position = db.Positions.FirstOrDefault(position => position.Id == positionToChange.Id);

                position.Name = newName;
                position.Salary = newSalary;
                position.MaxNumber = newMaxNumber;
                position.Id = newDepartment.Id;

                db.SaveChanges();
                result = "This position has been changed successfully !";
            }
            return result;
        }

        public static string EditStaff(Staff staffToChange, string newName, string newSurName, int newPhone, Position newPosition)
        {
            string result = "";
            using (ApplicationContext db = new ApplicationContext())
            {
                Staff staff = db.Staffs.FirstOrDefault(staff => staff.Id == staffToChange.Id);
                if (staff != null)
                {
                    staff.Name = newName;
                    staff.SurName = newSurName;
                    staff.Phone = newPhone;
                    staff.Id = newPosition.Id;
                    db.SaveChanges();
                    result = "The information about staff has been changed successfully !";
                }
            }
            return result;
        }
        #endregion
    }
}
