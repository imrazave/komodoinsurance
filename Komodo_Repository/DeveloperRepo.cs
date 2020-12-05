using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Repository
{
    public class DeveloperRepo
    {
        public List<Developer> _listOfDevelopers = new List<Developer>();

        //Create
        public void AddDeveloperToList(Developer dev)
        {
            _listOfDevelopers.Add(dev);
        }

        //Read
        public List<Developer> GetDeveloperList()
        {
            return _listOfDevelopers;
        }

        //Update
        public bool UpdateDevelopersFromList(int originalId, Developer newDev)
        {
            // Find the content
            Developer oldDev = GetDeveloperByID(originalId);

            //Update the content
            if (oldDev != null)
            {
                oldDev.EmployeeID = newDev.EmployeeID;
                oldDev.FirstName = newDev.FirstName;
                oldDev.LastName = newDev.LastName;
                oldDev.HasPluralsightAccess = newDev.HasPluralsightAccess;
                oldDev.TeamID = newDev.TeamID;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool RemoveDeveloperFromList(int employeeId)
        {
            Developer dev = GetDeveloperByID(employeeId);

            if (dev == null)
            {
                return false;
            }

            int initialCount = _listOfDevelopers.Count;
            _listOfDevelopers.Remove(dev);

            if (initialCount > _listOfDevelopers.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper method
        public Developer GetDeveloperByID(int employeeId)
        {
            foreach (Developer dev in _listOfDevelopers)
            {
                if(dev.EmployeeID == employeeId)
                {
                    return dev;
                }
            }

            return null;
        }
    }
}
