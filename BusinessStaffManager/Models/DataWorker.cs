using BusinessStaffManager.Models.Data;
using System.Linq;

namespace BusinessStaffManager.Models
{
    public static class DataWorker
    {
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

        public static string CreateStaff(string name, string surName, int positionId, Position position)
        {
            string result = "Already exist.";

            using (ApplicationContext db = new ApplicationContext())
            {
                //check if already exist
                bool isExist = db.Staffs.Any(element =>
                    element.Name == name &&
                    element.SurName == surName &&
                    element.PositionId == positionId
                    );

                if (!isExist)
                {
                    Staff newStaff = new Staff
                    {
                        Name = name,
                        SurName = surName,
                        PositionId = positionId,
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
        #endregion

        #region EditEntity
        #endregion
    }
}
