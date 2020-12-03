using Komodo_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_POCOS
{
    class ProgramUI
    {
        private DeveloperRepo _devRepo = new DeveloperRepo();
        // Method that runs/starts the application
        public void Run()
        {
            Menu();
        }

        // Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                // Display our options to the user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Developer\n" +
                    "2. View All Developers\n" +
                    "3. View Developers by Employee ID\n" +
                    "4. Update Existing Developer\n" +
                    "5. Delete Existing Developer\n" +
                    "6. Create New Team\n" +
                    "7. View All Teams\n" +
                    "8. Update A Team\n" +
                    "9. Delete A Team\n" +
                    "10. Return A List Of Developers Needing PluralSight\n" +
                    "11. Add Multiple Developers To A Team\n" +
                    "12. Exit");
                // Get the user's input
                string input = Console.ReadLine();

                // Evaluate the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        // Create new developer
                        CreateNewDeveloper();
                        break;
                    case "2":
                        // View all developers
                        ViewAllDevelopers();
                        break;
                    case "3":
                        // View developers by ID
                        ViewDevelopersByID();
                        break;
                    case "4":
                        //Update existing developer
                        UpdateExistingDeveloper();
                        break;
                    case "5":
                        //Delete existing developer
                        DeleteExistingDeveloper();
                        break;
                    case "6":
                        //Create new team
                        CreateNewTeam();
                        break;
                    case "7":
                        //View all teams
                        ViewAllTeams();
                        break;
                    case "8":
                        //Update a team
                        UpdateATeam();
                        break;
                    case "9":
                        //Delete a team
                        DeleteATeam();
                        break;
                    case "10":
                        //Return a list of developers needing PluralSight
                        PluralSight();
                        break;
                    case "11":
                        //Add Multiple Developers to a Team
                        MultiDev();
                        break;
                    case "12":
                        //Exit
                        Console.WriteLine("Good Bye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;


                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        // Create new developer
        private void CreateNewDeveloper()
        {
            Developer newDeveloper = new Developer();

            //EmployeeID
            Console.WriteLine("Enter the ID of the Employee");
            string IdAsString = Console.ReadLine();
            newDeveloper.EmployeeID = int.Parse(IdAsString);

            //FirstName
            Console.WriteLine("Enter the first name for the employee:");
            newDeveloper.FirstName = Console.ReadLine();

            //LastName
            Console.WriteLine("Enter the last name for the employee:");
            newDeveloper.LastName = Console.ReadLine();

            //HasPluralsightAccess
            Console.WriteLine("Does this Employee Have PluralSight Access? (y/n)");
            string pluralSight = Console.ReadLine().ToLower();
            if (pluralSight == "y")
            {
                newDeveloper.HasPluralsightAccess = true;
            }
            else
            {
                newDeveloper.HasPluralsightAccess = false;
            }
        }

        // View all developers
        private void ViewAllDevelopers()
        {

        }
        // View developers by ID
        private void ViewDevelopersByID()
        {

        }
        //Update existing developer
        private void UpdateExistingDeveloper()
        {

        }
        //Delete existing developer
        private void DeleteExistingDeveloper()
        {

        }
        //Create new team
        private void CreateNewTeam()
        {
            DevTeam newDevTeam = new DevTeam();

            //TeamID
            Console.WriteLine("Enter a Team ID (must be an integer):");
            string teamId = Console.ReadLine();
            newDevTeam.TeamID = int.Parse(teamId);

            //TeamName
            Console.WriteLine("Enter A Team Name");
            newDevTeam.TeamName = Console.ReadLine();
        }
        //View all teams
        private void ViewAllTeams()
        {

        }
        //Update a team
        private void UpdateATeam()
        {

        }
        //Delete a team
        private void DeleteATeam()
        {

        }
        //Return a list of developers needing PluralSight
        private void PluralSight()
        {

        }
        //Add Multiple Developers to a Team
        private void MultiDev()
        {

        }
    }
}
