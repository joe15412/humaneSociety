using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{

    public class UserInterface

    //employee or costumer
    {
        public UserInterface()
        {

        }
        public void Welcome()
        {
            Console.WriteLine("Welcome to the Humane Society!");
            Console.WriteLine("Are you a");
            Console.WriteLine("1: Costumer");
            Console.WriteLine("2: Employee?");
        }
        public string GetUserInput()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }
        //user name or password   
        public void DisplayReturningUserOption()
        {
            Console.WriteLine("Are you a");
            Console.WriteLine("1: New User?");
            Console.WriteLine("2: Returning User?");
            //Console.WriteLine("3: Guest?");
        }
        public void DisplayEmployeeComfirmation()
        {
            Console.WriteLine("Please enter your employee certification password.");
        }
        //add name
        public void DisplayUserFirstNameOption()
        {
            Console.WriteLine("Please enter Your First Name");
        }
        public void DisplayUserNameCheck(string userName)
        {
            Console.WriteLine("Your current username is " + userName + "." + Environment.NewLine + "Would you like to:" + Environment.NewLine + "1) Keep this User Name" + Environment.NewLine + "2) Change your User Name");
        }
        public void DisplayUserFirstNameCheck(string firstName)
        {
            Console.WriteLine("Your current first name is " + firstName + "." + Environment.NewLine + "Would you like to:" + Environment.NewLine + "1) Keep this first name" + Environment.NewLine + "2) Change your first name");
        }
        public void DisplayUserLastNameCheck(string lastName)
        {
            Console.WriteLine("Your current last name is " + lastName + "." + Environment.NewLine + "Would you like to:" + Environment.NewLine + "1) Keep this last name" + Environment.NewLine + "2) Change your last name");
        }
        public void DisplayUserLastNameOption()
        {
            Console.WriteLine("Please enter Your Last Name");
        }
        //make username
        public void DisplaySetUserNameOption()
        {
            Console.WriteLine("Please create a user name");
        }
        //password
        public void DisplaySetUserPassWordOption()
        {
            Console.WriteLine("Please create a password");
        }
        public void DisplayCheckUserPassWord()
        {
            Console.WriteLine("Please re-write your password.");
        }
        public void DisplayIncorrectPasswordMatch()
        {
            Console.WriteLine("The passwords you have written do not match. Please try again.");
        }
        //add email and phone number
        //public void DisplayUserEmailInputOption()
        //{
        //    Console.WriteLine("Please enter your email..");
        //}
        public void DisplayGenderOptions()
        {
            Console.WriteLine("What is your gender?");
        }

        public void DisplayIncorrectOption()
        {
            Console.WriteLine("What you have chosen is not an option. Please try again.");
        }
        public void DisplayGenderCheck(string userInput)
        {
            Console.WriteLine("The current gender you have chosen is " + userInput + "." + Environment.NewLine + "Is this correct?" + Environment.NewLine + "1)Yes" + Environment.NewLine + "2)No");
        }
        public void DisplayUserPhoneNumberInputOption()
        {
            Console.WriteLine("Please enter Your phone number");
        }
        public void DisplayUserPhoneNumberCheck(string userInput)
        {
            Console.WriteLine("Your current phone number is " + userInput + "." + Environment.NewLine + "Is this correct?" + Environment.NewLine + "1)Yes" + Environment.NewLine + "2)No");
        }
        public void DisplayUserNameInputOption()
        {
            Console.WriteLine("Please enter your User Name");
        }
        public void DisplayUserPasswordInputOption()
        {
            Console.WriteLine("Please enter your password");
        }
        //add address
        public void DisplayUserStreetNumber()
        {
            Console.WriteLine("What is your Street Number?");
        }
        public void DisplayStreetName()
        {
            Console.WriteLine("What is your Street Name?");
        }
        public void DisplayCityName()
        {
            Console.WriteLine("What City do you live in?");
        }
        public void DisplayStateName()
        {
            Console.WriteLine("What State do you live in?");
        }

        public void DisplayZipCode()
        {
            Console.WriteLine("What is your Zip Code?");
        }
        public void DisplayZipCodeCheck(string userInput)
        {
            Console.WriteLine("Your current zip code is " + userInput + "." + Environment.NewLine + "Is this correct?" + Environment.NewLine + "1)Yes" + Environment.NewLine + "2)No");
        }
        public void DisplayStateCheck(string userInput)
        {
            Console.WriteLine("Your current state is" + userInput + "." + Environment.NewLine + "Is this correct?" + Environment.NewLine + "1)Yes" + Environment.NewLine + "2)No");
        }
        public void DisplayCityCheck(string userInput)
        {
            Console.WriteLine("Your current city is" + userInput + "." + Environment.NewLine + "Is this correct?" + Environment.NewLine + "1)Yes" + Environment.NewLine + "2)No");

        }
        public void DisplayStreet()
        {
            Console.WriteLine("What is your street name?");
        }
        public void DisplayStreetCheck(string userInput)
        {
            Console.WriteLine("Your current street name is" + userInput + "." + Environment.NewLine + "Is this correct?" + Environment.NewLine + "1)Yes" + Environment.NewLine + "2)No");

        }
        public void DisplayUsedUserName()
        {
            Console.WriteLine("The user name you have chosen is already in use." + Environment.NewLine + "Please choose a different user name.");
        }
        public void DisplayAddressNumber()
        {
            Console.WriteLine("What is address number?");
        }
        public void DisplayAddressNumberCheck(string userInput)
        {
            Console.WriteLine("Your current address number is" + userInput + "." + Environment.NewLine + "Is this correct?" + Environment.NewLine + "1)Yes" + Environment.NewLine + "2)No");

        }
        public void DisplayCheckToGoBack()
        {
            Console.WriteLine("You have completed your account creation." + Environment.NewLine + "Please select any of the follow:" +Environment.NewLine + "1) UserName" + Environment.NewLine + "2) First Name" + Environment.NewLine + "3) Last Name" + Environment.NewLine + "4) PassWord" + Environment.NewLine + "5) Gender" + Environment.NewLine + "6) Phone Number" + Environment.NewLine + "7) Zip Code" + Environment.NewLine + "8) State" + Environment.NewLine + "9) City" + Environment.NewLine + "10) Street" + Environment.NewLine + "11) Address Number" + Environment.NewLine + "12) Restart account creation" +Environment.NewLine + "13) Log in with your new account");
        }
        public void DisplayEmployeeOptions()
        {
            Console.WriteLine("As an employee, would you like to:" + Environment.NewLine + "1) Look at available animals" + Environment.NewLine + "2) Add an animal" + Environment.NewLine + "3) Edit an existing animal's information");
        }
        //employee adds animal
        public void DisplayUserNameLogIn()
        {
            Console.WriteLine("Please enter your username.");
        }
        public void DisplayPassWordLogIn()
        {
            Console.WriteLine("Please enter your password.");
        }
        public void DisplayIncorrectLogIn()
        {
            Console.WriteLine("You have entered the incorrect combination of Username and Password");
        }
        public void AddAnimalType()
        {
            Console.WriteLine("What type of Animal do you want to add?");
        }
        public void AddAnimalName()
        {
            Console.WriteLine("What is there name?");
        }
        public void AddAnimalGender()
        {
            Console.WriteLine("Is the animal");
            Console.WriteLine("1: Male");
            Console.WriteLine("2: Female");
        }
        public void AddAnimalBreed()
        {
            Console.WriteLine("What is the Animals Breed?");

        }
        public void AddAnimalPrice()
        {
            Console.WriteLine("What is the Animal Price?");
        }
        public void AddAnimalColor()
        {
            Console.WriteLine("What color is the animal");
        }
        public void EmployeeRemoveAnimal()
        {
            Console.WriteLine("Do you want to remove an animal that was adopted");
        }
        //select animal
        public void UserSelectAnimal()
        {
            Console.WriteLine("What type of animal are you looking for?");
            Console.WriteLine("1: Dog");
            Console.WriteLine("2: Cat");
            Console.WriteLine("3: Reptiles");
            Console.WriteLine("4: Birds");
            Console.WriteLine("5: Ferrets");
            Console.WriteLine("6: Rabbits");

            // in client, we will match the pick to save what their choice was. Then we will take the info for later UIs
        }
        public void DisplayCheckIfAnimalIDIsKnown()
        {
            Console.WriteLine("Do you know the ID associated with the animal you are looking for?" +Environment.NewLine + "1) Yes" +Environment.NewLine+ "2)No");
        }
        public void DisplayAnimalIDQuestion()
        {
            Console.WriteLine("What is the ID associated with the animal you are looking for?");
        }
        // for(int i ; i < animal.attributes.count; i++) { cw"i + ")" + animal.Attributes[i] "."
        //public void DisplayAnimalOptions(Client client)
        //{
        //    Console.WriteLine("Search for " + client.animalChoice + " by:");
        //    Console.WriteLine("1: Name");
        //    Console.WriteLine("2: Breed/Species");
        //    Console.WriteLine("3: Color");
        //    Console.WriteLine("4: Size");
        //    Console.WriteLine("5: Gender");
        //    Console.WriteLine("6: Price");
        //    //UI.DisplaySearchOptions(this)
        //}
         public void AdoptInformation()
        {

            Console.WriteLine("Do you want information on adopting this animal?");
            Console.WriteLine("1: Yes");
            Console.WriteLine("2: No");
            Console.WriteLine("3: Search again");
            Console.WriteLine("4: Start Over"); 
        }
    }
}          

