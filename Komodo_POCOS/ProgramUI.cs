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
        private DevTeamRepo _devTeamRepo = new DevTeamRepo();
        // Method that runs/starts the application
        public void Run()
        {
            SeedDeveloperList();
            SeedTeamList();
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
        public void CreateNewDeveloper()
        {
            Console.Clear();
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

            _devRepo.AddDeveloperToList(newDeveloper);
        }

        // View all developers
        private void ViewAllDevelopers()
        {
            Console.Clear();

            List<Developer> listOfDevelopers = _devRepo.GetDeveloperList();

            foreach(Developer developer in listOfDevelopers)
            {
                Console.WriteLine($"ID: {developer.EmployeeID}\n" +
                    $"First Name: {developer.FirstName}\n" +
                    $"Last Name: {developer.LastName}\n");
            }
        }
        // View developers by ID
        private void ViewDevelopersByID()
        {
            Console.Clear();
            Console.WriteLine("Please enter an ID");
            //Prompt the user to give an ID
            string stringId = Console.ReadLine();
            int id = int.Parse(stringId);

            //Find the developer by that name
            Developer developer = _devRepo.GetDeveloperByID(id);

            //Display said content if it isn't null
            if (developer != null)
            {
                Console.WriteLine($"ID: {developer.EmployeeID}\n" +
                      $"First Name: {developer.FirstName}\n" +
                      $"Last Name: {developer.LastName}\n");
            }
            else
            {
                Console.WriteLine("No Developer By That ID");
            }
        }
        //Update existing developer
        private void UpdateExistingDeveloper()
        {

        }
        //Delete existing developer
        private void DeleteExistingDeveloper()
        {
            Console.Clear();

            ViewAllDevelopers();

            //Get the ID they want to remove
            Console.WriteLine("Enter the ID of the developer you want to remove");

            string input = Console.ReadLine();
            int id = int.Parse(input);

            //Call the delete method
            bool wasDeleted = _devRepo.RemoveDeveloperFromList(id);

            //If the content was deleted, say so
            if (wasDeleted)
            {
                Console.WriteLine("The content was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The content could not be deleted.");
            }
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

            _devTeamRepo.AddTeamToList(newDevTeam);

        }
        //View all teams
 
        private void ViewAllTeams()
        {
            Console.Clear();

            List<DevTeam> listOfTeams = _devTeamRepo.GetDevTeamList();

            foreach (DevTeam team in listOfTeams)
            {
                Console.WriteLine($"Team ID: {team.TeamID}\n" +
                    $"Team Name: {team.TeamName}\n");
            }
        }
        //Update a team
        private void UpdateATeam()
        {

        }
        //Delete a team
        private void DeleteATeam()
        {
            ViewAllTeams();

            //Get the team that they want to remove

            Console.WriteLine("Enter the ID of the team that you want to remove.");

            string input = Console.ReadLine();
            int id = int.Parse(input);

            // Call the delete method
            bool wasDeleted = _devTeamRepo.RemoveTeamFromList(id);

            //if the content was deleted, say so
            //Otherwise state it could not be deleted
            if (wasDeleted)
            {
                Console.WriteLine("The content was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The content could not be deleted.");
            }
        }
        //Return a list of developers needing PluralSight
        private void PluralSight()
        {

        }
        //Add Multiple Developers to a Team
        private void MultiDev()
        {

        }
        //Seed methods
        private void SeedDeveloperList()
        {
            Developer daveSmith = new Developer("Dave", "Smith", 1, true);
            Developer joeKemp = new Developer("Joe", "Kemp", 2, false);
            Developer brianJones = new Developer("Brian", "Jones", 3, true);

            _devRepo.AddDeveloperToList(daveSmith);
            _devRepo.AddDeveloperToList(joeKemp);
            _devRepo.AddDeveloperToList(brianJones);
        }
        private void SeedTeamList()
        {
            DevTeam teamVenture = new DevTeam("Team Venture", 1);
            DevTeam teamAlpha = new DevTeam("Team Alpha", 2);
            DevTeam teamBeta = new DevTeam("Team Beta", 3);

            _devTeamRepo.AddTeamToList(teamVenture);
            _devTeamRepo.AddTeamToList(teamAlpha);
            _devTeamRepo.AddTeamToList(teamBeta);

        }
    }
}
