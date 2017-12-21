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
            Console.WriteLine("3: Guest?");
        }
        //add name
        public void DisplayUserFirstNameOption()
        {
            Console.WriteLine("Please enter Your First Name");
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
        //add email and phone number
        public void DisplayUserEmailInputOption()
        {
            Console.WriteLine("Please enter your email..");
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
        public void DisplayStateNAme()
        {
            Console.WriteLine("What State do you live in?");
        }

        public void DisplayZipCode()
        {
            Console.WriteLine("What is your Zip Code?");
        }
        //employee adds animal
        public void EmployeeAddAnimal()
        {
            Console.WriteLine("Do you want to add a new animal?");
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

