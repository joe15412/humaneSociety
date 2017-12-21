using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{

    public class UserInterFace

    //employee or costumer

    {

        public void Welcome()
        {
            Console.WriteLine("Welcome to the Humane Society!");
            Console.WriteLine("Are you a");
            Console.WriteLine("1: Costumer");
            Console.WriteLine("2: Employee?");
        }
        public string GetUserInput()
        { string userInput = Console.ReadLine();
            return userInput;
        }
        //user name or password   
        public void DisplayReturningUserOption()
        {
            Console.WriteLine("Are you a");
            Console.WriteLine("1:new user");
            Console.WriteLine("2: returning user?");
        }

        public void DisplayUserFirstNameOption()
        {
            Console.WriteLine("Please enter Your First Name");
        }
        public void DisplayUserLastNameOption()
        {
            Console.WriteLine("Please enter Your Last Name");
        }
        public void DisplaySetUserNameOption()
        {
            Console.WriteLine("Please create a user name");
        }
        public void DisplaySetUserPassWordOption()
        {
            Console.WriteLine("Please create a password");
        }
        public void DisplayUserEmailInputOption()
        {
            Console.WriteLine("Please enter your email");
        }
        public void DisplayUserPhoneNumberInputOption()
        {
            Console.WriteLine("Please enter Your phone number");
        }
        public void DisplayUserNameInputOption()
        {
            Console.WriteLine("Please enter your User Name");
        }
        public void DisplayUserPasswordInputOption()
        {
            Console.WriteLine("Please enter your password");
        }

        public void employeeAddAnimal()
        {
            Console.WriteLine("Do you want to add a new animal?");
        }
        public void employeeRemoveAnimal()
        {
            Console.WriteLine("Do you want to remove an animal that was adopted");

        }

        public void userSelectAnimal()
        {
            Console.WriteLine("What type of animal are you looking for?");
            Console.WriteLine("1: Dog");
            Console.WriteLine("2: Cat");
            Console.WriteLine("3: Reptiles");
            Console.WriteLine("4: Birds");
            Console.WriteLine("5: Ferrets");


        }
        public void SearchCats()
        {
            Console.WriteLine("Search for cats by");
            Console.WriteLine("1: Name");
            Console.WriteLine("2: Breed");
            Console.WriteLine("3: Size");
            Console.WriteLine("4: Gender");
            Console.WriteLine("5: Price");


        }
        public void SearchDogs()
        {
            Console.WriteLine("Search for dogs by");
            Console.WriteLine("1: Name");
            Console.WriteLine("2: Breed");
            Console.WriteLine("3: Color");
            Console.WriteLine("4: Size");
            Console.WriteLine("5: Gender");
            Console.WriteLine("6: Price");
        }
        public void SearchBirds()
        {
            Console.WriteLine("Search for birds by");
            Console.WriteLine("1:Name");
            Console.WriteLine("2: Breed");
            Console.WriteLine("3: Color");
            Console.WriteLine("4: Size");
            Console.WriteLine("5: Price");
        }
        public void SearchReptiles()
        {
            Console.WriteLine("Search for reptiles");
            Console.WriteLine("1: Name");
            Console.WriteLine("2: Species");
            Console.WriteLine("3: Color");
            Console.WriteLine("4: Size");
            Console.WriteLine("5: Price");
        }
        public void SearchRabbits()
        {
            Console.WriteLine("Search for rabbits");
            Console.WriteLine("1: Name");
            Console.WriteLine("2: Breed");
            Console.WriteLine("3: Color");
            Console.WriteLine("4: Size");
            Console.WriteLine("5: Gender");
            Console.WriteLine("6: Price");

        }
        public void SearchFerrets()
        {
            Console.WriteLine("Search for ferrets");
            Console.WriteLine("1: Name");
            Console.WriteLine("2: Breed");
            Console.WriteLine("3: Color");
            Console.WriteLine("4: Size");
            Console.WriteLine("5: Gender");
            Console.WriteLine("6: Price");

        }
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
        
      

       //Put a password for creating a new account with employee access.

        // Ask if there was a name/animalID they were searching for in the database

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
        // when creating a new account, ask if they are an employee. Then make a new UI asking what the employee password is

