using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HumaneSociety
{
    class Client
    {
        Management management;
        UserInterface UI;
        public int userID;
            // will change
        string userName;
        string passWord;
        string state;
        string city;
        string zipcode;
        string street;
        string addressNumber;
        string gender;
        string phoneNumber;
        string firstName;
        string lastName;
        bool isEmployee;
        string statusLevel;
        bool isReturningUser;
        int userNameID;
        int animalSearchID;
        public Client()
        {
            UI = new UserInterface();
            management = new Management();
            // will need to send in the new management class that is intatiated in the program
        }
        public void RunClient()
        {
            RunLogInChecks();
            if(isReturningUser == false)
            {
                CreateAccount();
            }
            else
            {
                LogIn();
            }

 
        }
        void RunMainMenu()
        {
            if (statusLevel == "Employee")
            {
                CheckEmployeeMainMenuAnswer();
            }
            else
            {
                CheckAnimalViewAnswer();
            }

        }
        void CheckEmployeeMainMenuAnswer()
        {
            UI.DisplayEmployeeOptions();
            if (UI.GetUserInput() == "1")
            {
                CheckAnimalViewAnswer();
            }
            else if (UI.GetUserInput() == "2")
            {
            //    AddNewAnimal();
            //}
            //else if (UI.GetUserInput() == "3")
            //{
            //    ChangeExistingAnimal();
            }
        }
        void CheckAnimalViewAnswer()
        {

        }
        void CheckForAnimalIDAnswer()
        {
            UI.DisplayCheckIfAnimalIDIsKnown();
            if (UI.GetUserInput() == "1")
            {
                CheckForAnimalID();
            }
            else if (UI.GetUserInput() == "2")
            {
                
            }
            else
            {
                CheckForAnimalIDAnswer();
            }
        }
        void CheckForAnimalID()
        {
            UI.DisplayAnimalIDQuestion();
            animalSearchID = Convert.ToInt32(UI.GetUserInput());
            if (management.CheckPreviousAnimalID(animalSearchID) == true)
            {
                management.ShowAnimalInformationByID(animalSearchID);
            }
        }
        public void RunLogInChecks()
        {
            CheckIfEmployee();
            CheckIfReturningUser();
        }
        public void CreateAccount()
        {
            SetUserName();
            CheckUserName();
            SetUserFirstName();
            CheckUserFirstName();
            SetUserLastName();
            CheckUserLastName();
            SetPassWord();
            CheckPassword();
            SetGender();
            CheckGenderChoice();
            SetPhoneNumber();
            CheckPhoneNumber();
            SetZipCode();
            CheckZipCode();
            SetState();
            CheckState();
            SetCity();
            CheckCity();
            SetStreet();
            CheckStreet();
            SetAddressNumber();
            CheckAddressNumber();
            CheckAcocountCreation();
        }
        void LogIn()
        {
            UI.DisplayUserNameLogIn();
            userName = UI.GetUserInput();
            UI.DisplayPassWordLogIn();
            passWord = UI.GetUserInput();
            if (management.CheckPreviousUserName(userName) == true)
            {

               if (management.CheckPassWordMatchToUserID(management.MatchUserNameToUserNameID(userName)) == false)
                {
                    UI.DisplayIncorrectLogIn();
                    LogIn();
                }
               else 
                {
                    userID = management.MatchUserNameToUserNameID(userName);
                    statusLevel = management.MatchUserIDToUserStatus(userID);
                }
            }
        }
        void CheckIfEmployee()
        {
            UI.Welcome();
            if (UI.GetUserInput() == "1")
            {
                isEmployee = false;
                statusLevel = "Customer";
            }
            else if (UI.GetUserInput() == "2")
            {
                CheckEmployeePassWord();
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

            if (management.CheckPreviousUserName(UI.GetUserInput()) == false)
            {
                CheckIfEmployee();
            }
            else
            {
                statusLevel = "Employee";
                isEmployee = true;
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
        void SetPassWord()
        {
            UI.DisplaySetUserPassWordOption();
            passWord = UI.GetUserInput();
        }
        void CheckPassword()
        {
            UI.DisplayCheckUserPassWord();
            if (UI.GetUserInput() != passWord)
            {
                UI.DisplayIncorrectPasswordMatch();
                SetPassWord();
            }
        }
        void SetGender()
        {
            UI.DisplayGenderOptions();
            gender = UI.GetUserInput();
        }
        void CheckGenderChoice()
        {
            UI.DisplayGenderCheck(gender);
            if (UI.GetUserInput() == "1")
            {
            }
            else if (UI.GetUserInput() == "2")
            {
                SetGender();
            }
            else
            {
                CheckGenderChoice();
            }
        }
        public void SetPhoneNumber()
        {
            UI.DisplayUserPhoneNumberInputOption();
            phoneNumber = UI.GetUserInput();
        }
        public void CheckPhoneNumber()
        {
            UI.DisplayUserPhoneNumberCheck(phoneNumber);
            if (UI.GetUserInput() == "1")
            {
            }
            else if (UI.GetUserInput() == "2")
            {
                SetPhoneNumber();
            }
            else
            {
                CheckPhoneNumber();
            }
        }
        public void SetZipCode()
        {
            UI.DisplayZipCode();
            zipcode = UI.GetUserInput();
        }
        public void CheckZipCode()
        {
            UI.DisplayZipCodeCheck(zipcode);
            if (UI.GetUserInput() == "1")
            {
            }
            else if (UI.GetUserInput() == "2")
            {
                SetZipCode();
            }
            else
            {
                CheckZipCode();
            }
        }
        public void SetState()
        {
            UI.DisplayStateName();
            state = UI.GetUserInput();
        }
        public void CheckState()
        {
            UI.DisplayStateCheck(state);
            if (UI.GetUserInput() == "1")
            {
            }
            else if (UI.GetUserInput() == "2")
            {
                SetState();
            }
            else
            {
                CheckState();
            }
        }
        public void SetCity()
        {
            UI.DisplayCityName();
            city = UI.GetUserInput();
        }
        public void CheckCity()
        {
            UI.DisplayCityCheck(city);
            if (UI.GetUserInput() == "1")
            {
            }
            else if (UI.GetUserInput() == "2")
            {
                SetCity();
            }
            else
            {
                CheckCity();
            }
        }
        public void SetStreet()
        {
            UI.DisplayStreet();
            street = UI.GetUserInput();
        }
        public void CheckStreet()
        {
            UI.DisplayStreetCheck(street);
            if (UI.GetUserInput() == "1")
            {
            }
            else if (UI.GetUserInput() == "2")
            {
                SetStreet();
            }
            else
            {
                CheckStreet();
            }
        }
        public void SetAddressNumber()
        {
            UI.DisplayAddressNumber();
            addressNumber = UI.GetUserInput();
        }
        public void CheckAddressNumber()
        {
            UI.DisplayAddressNumberCheck(addressNumber);
            if (UI.GetUserInput() == "1")
            {
            }
            else if (UI.GetUserInput() == "2")
            {
                SetAddressNumber();
            }
            else
            {
                CheckAddressNumber();
            }

        }
        public void CheckAcocountCreation()
        {
            UI.DisplayCheckToGoBack();
            switch (UI.GetUserInput())
            {
                case "1":
                    SetUserFirstName();
                    break;
                case "2":
                    SetUserFirstName();
                    break;
                case "3":
                    SetUserLastName();
                    break;
                case "4":
                    SetPassWord();
                    break;
                case "5":
                    SetGender();
                    break;
                case "6":
                    SetPhoneNumber();
                    break;
                case "7":
                    SetZipCode();
                    break;
                case "8":
                    SetState();
                    break;
                case "9":
                    SetCity();
                    break;
                case "10":
                    SetStreet();
                    break;
                case "11":
                    SetAddressNumber();
                    break;
                case "12":
                    CreateAccount();
                    break;
                case "13":
                    if (management.CheckPreviousUserName(userName) == false)
                    {
                        SendNewAccountInformation();
                    }
                    else
                    {
                        UI.DisplayUsedUserName();
                        CheckAcocountCreation();
                    }
                    // run this shit
                    break;
                default:
                    CheckAcocountCreation();
                    break;
            }
        }
        public void SendNewAccountInformation()
        {
            userID = management.AddUser(userName, passWord, gender, phoneNumber, city, state, zipcode, street, addressNumber, statusLevel);
            Console.WriteLine(userID);
        }


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
