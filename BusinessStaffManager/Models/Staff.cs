using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManager.Models
{
    /// <summary>
    /// Base model class for all Staffs
    /// </summary>
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Phone { get; set; }
        public virtual Position Position { get; set; }
        public Staff(int id, string name, string surName, int phone, Position position)
        {
            Id = id;
            Name = name;
            SurName = surName;
            Phone = phone;
            Position = position;
        }
    }
}
