using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Repository
{
    public class DevTeamRepo
    {
        private List<DevTeam> _listOfTeams = new List<DevTeam>();

        //Create
        public void AddTeamToList(DevTeam team)
        {
            _listOfTeams.Add(team);
        }

        public bool AddDeveloperToTeam(int teamId, Developer dev)
        {
            DevTeam team = GetTeamByID(teamId);
            

            int initialCount = team.TeamMembers.Count;
            if (dev == null)
            {
                return false;
            }

            team.TeamMembers.Add(dev);

            if (initialCount < team.TeamMembers.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Read
        public List<DevTeam> GetDevTeamList()
        {
            return _listOfTeams;
        }
        //Update
        public bool UpdateTeamsFromList(int originalTeamId, DevTeam newTeam)
        {
            // Find the content
            DevTeam oldTeam = GetTeamByID(originalTeamId);

            //Update the content
            if (oldTeam != null)
            {
                oldTeam.TeamID = newTeam.TeamID;
                oldTeam.TeamName = newTeam.TeamName;
                oldTeam.TeamMembers = newTeam.TeamMembers;

                return true;
            }
            else
            {
                return false;
            }
        }
        //Delete

        //Remove a team from list
        public bool RemoveTeamFromList(int teamId)
        {
            DevTeam team = GetTeamByID(teamId);

            if (team == null)
            {
                return false;
            }

            int initialCount = _listOfTeams.Count;
            _listOfTeams.Remove(team);

            if (initialCount > _listOfTeams.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Remove a developer from a team
        public bool RemoveDeveloperFromTeam(int teamId, Developer dev)
        {
            DevTeam team = GetTeamByID(teamId);

            foreach (Developer developer in team.TeamMembers)
            {
                if (developer.EmployeeID == dev.EmployeeID)
                {
                    team.TeamMembers.Remove(developer);
                    return true;
                }
            }
            return false;
        }
        //Helper
        public DevTeam GetTeamByID(int teamId)
        {
            foreach (DevTeam team in _listOfTeams)
            {
                if (team.TeamID == teamId)
                {
                    return team;
                }
            }

            return null;
        }
    }
}
