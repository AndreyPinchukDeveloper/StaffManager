using System.Collections.Generic;

namespace BusinessStaffManager.Models
{
    /// <summary>
    /// Base model class for all Departments
    /// </summary>
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Position> Position { get; set; }

        public Department(int id, string name, List<Position> position)
        {
            Id = id;
            Name = name;
            Position = position;
        }
    }
}
