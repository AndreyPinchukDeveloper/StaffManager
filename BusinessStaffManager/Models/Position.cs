using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManager.Models
{
    /// <summary>
    /// Base model class for all Positions
    /// </summary>
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int MaxNumber { get; set; }
        public List<Staff> Staff { get; set; }
        public List<Department> Department { get; set; }

        public Position(int id, string name, decimal salary, int maxNumber, List<Staff> staff, List<Department> department)
        {
            Id = id;
            Name = name;
            Salary = salary;
            MaxNumber = maxNumber;
            Staff = staff;
            Department = department;
        }
    }
}
