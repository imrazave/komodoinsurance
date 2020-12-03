using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Repository
{
    // Plain Old C# Object -- POCO
    public class DevTeam
    {
        public string TeamName { get; set; }
        public int TeamID { get; set; }

        public List<Developer> Developers { get; set; }

        public DevTeam() { }

        public DevTeam(string teamName, int teamId)
        {
            TeamName = teamName;
            TeamID = teamId;
        }
    }
}
