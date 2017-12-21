using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HumaneSociety
{
    class Client
    {

        string status;
        Management management;
        UserInterface UI;
        public int userID;
            // will change
        string userName;
        string passWord;
        string Address;
        string Gender;
        string firstName;
        string lastName;
        bool isEmployee;
        bool isReturningUser;
        public Client()
        {
            UI = new UserInterface();
            management = new Management();
        }
        public void RunClient()
        {
            RunLogIn();
            RunLogIn();
            if(isReturningUser == false)
            {
                CreateAccount();
            }
 
        }
        public void RunLogIn()
        {
            CheckIfEmployee();
            CheckIfReturningUser();
            if (isEmployee == true)
            {
             CheckEmployeePassWord();
            }
        }
        public void CreateAccount()
        {
            SetUserName();
            SetUserFirstName();
            SetUserLastName();
        }
        void CheckIfEmployee()
        {
            UI.Welcome();
            if (UI.GetUserInput() == "1")
            {
                isEmployee = false;
            }
            else if (UI.GetUserInput() == "2")
            {
                isEmployee = true;
            }
        }
        void CheckIfReturningUser()
        {
            UI.DisplayReturningUserOption();
            if (UI.GetUserInput() == "1")
            {
                isReturningUser = false;
            }
          else if (UI.GetUserInput() == "2")
            {
                isReturningUser = true;
            }
          else
            {
                CheckIfReturningUser();
            }
        }
        void CheckEmployeePassWord()
        {
            UI.DisplayEmployeeComfirmation();
            if (UI.GetUserInput() != management.employeePassWord)
            {
                CheckIfEmployee();
            }

        }
        void SetUserName()
        {
            UI.DisplaySetUserNameOption();
            userName = UI.GetUserInput();
        }
        void CheckUserName()
        {
            UI.DisplayUserNameCheck(userName);
            if (UI.GetUserInput() == "1")
            {
                //maybe add something here???
            }
            else if (UI.GetUserInput() == "2")
            {
                SetUserName();
            }
            else
            {
                CheckUserName();
            }
        }
        void SetUserFirstName()
        {
            UI.DisplayUserFirstNameOption();
            firstName = UI.GetUserInput();
        }
        void CheckUserFirstName()
        {
            UI.DisplayUserFirstNameCheck(firstName);
            if (UI.GetUserInput() == "1")
            {
                //maybe add something here???
            }
            else if (UI.GetUserInput() == "2")
            {
                SetUserFirstName();
            }
            else
            {
                CheckUserFirstName();
            }
        }
        void SetUserLastName()
        {
            UI.DisplayUserLastNameOption();
            lastName = UI.GetUserInput();
        }
        void CheckUserLastName()
        {
            UI.DisplayUserLastNameCheck(lastName);
            if (UI.GetUserInput() == "1")
            {
                //maybe add something here???
            }
            else if (UI.GetUserInput() == "2")
            {
                SetUserLastName();
            }
            else
            {
                CheckUserLastName();
            }
        }




        //UI.Are you a new or old user?

        //If new user - ask to put information


        //if old user= ask for username/password



        //Put a password for creating a new account with employee access.

        // Ask if there was a nane/animalID they were searching for in the database

        // ask if there were any specifications they wanted to look deeper into (put all the options into the UI)

        // or if they just want to view their names/ show they names for all animals in there

        // Then show the information for that animal.

        // If they are an employee, ask if they wanted to edit the information for this animal

        // if they want to change it, then allow them to make an input, then replace the information in the database.

        // THen show the information for the animal again with the updated informatiomn

        // otherwise if they are a customer/non employee, ask if they want to adopt the dog. Or if they wanted to search for another animal.

        //if they want to adopt the animal, use swipe to impliment a buying system.
        // if we cant use an api in this instance, I would do something like we did soda machine but I dont think thats the case.

        // Then after they view/buy/change something, as if they wanted to look at another animal. 
    }
}
