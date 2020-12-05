using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Repository
{
    //Plain Old C# Object
    public class Developer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeID { get; set; }
        public bool HasPluralsightAccess { get; set; }
        public int TeamID { get; set; }

        public Developer() { }
        public Developer(string firstName, string lastName, int employeeId, bool hasPluralSight, int teamId)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeID = employeeId;
            HasPluralsightAccess = hasPluralSight;
            TeamID = teamId;
        }
    }
}
