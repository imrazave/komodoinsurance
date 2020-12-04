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

                return true;
            }
            else
            {
                return false;
            }
        }
        //Delete
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
