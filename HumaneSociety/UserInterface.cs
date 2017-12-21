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
        {   string userInput = Console.ReadLine();
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

>>>>>>> 4a5762f6c62659f36b8ae269cab49b16fe31144d
    }

}
}
