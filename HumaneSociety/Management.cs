using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;

namespace HumaneSociety
{
    class Management
    {
        HumaneSocietyDatabaseDataSet humaneSocietyData;
        List<int> userNameIDs = new List<int>();
        List<char> userNames = new List<char>();
        List<char> passWords = new List<char>();
        List<char> addresses = new List<char>();
        List<char> genders = new List<char>();
        List<char> phoneNumbers = new List<char>();



        public Management()
        {
            humaneSocietyData = new HumaneSocietyDatabaseDataSet();
        }
        public static char StringToChar(string input)
        {
            char inputChar = Convert.ToChar(input);
            return inputChar;
        }
        void FindUserName(string userInput )
        {
            userNames.Clear();
            userNames = (from x in humaneSocietyData.UserNames.User_NameColumn.Namespace
                         where x == Convert.ToChar(userInput)
                         select x).ToList();
        }
        //void FindUserNameID(string userInput)
        //{
        //    userNameIDs.Clear();
        //    userNameIDs = (from x in humaneSocietyData.Users.FindByUser_ID()
        //                 where x == Convert.ToInt32(userInput)
        //                 select x).ToList();
        //}
        bool CheckUserName(string userInput)
        {
            FindUserName(userInput);
            bool userInputCreationAllowed = CheckList(passWords);
            return userInputCreationAllowed;
        }
        bool CheckList(List<char> chosenList)
        {
            if (chosenList.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool CheckPassWord(string userInput)
        {
            FindPassword(userInput);
            bool passWordCreationAllowed = CheckList(passWords);
            return passWordCreationAllowed;
        }
        void FindPassword(string userInput)
        {
            passWords.Clear();
            passWords = (from x in humaneSocietyData.PassWords.Namespace
                         where x == Convert.ToChar(userInput)
                         select x).ToList();
        }
        bool CheckAddress(string userInput)
        {
            bool AddressCreationAllowed = CheckList(addresses);
            return AddressCreationAllowed;
            // this will have to go more in depth since there are several foreign keys
        }
        void FindAddress(string userInput)
        {
            addresses.Clear();
            addresses = (from x in humaneSocietyData.PassWords.Namespace
                         where x == Convert.ToChar(userInput)
                         select x).ToList();
        }
        bool CheckGender(string userInput)
        {
            bool genderCreationAllowed = CheckList(genders);
            return genderCreationAllowed;
        }
        void FindGender(string userInput)
        {
            genders.Clear();
            genders = (from x in humaneSocietyData.Genders.Namespace
                       where x == Convert.ToChar(userInput)
                       select x).ToList();
        }
        bool CheckPhoneNumber(string userInput)
        {
            bool phoneNumberCreationAllowed = CheckList(phoneNumbers);
            return phoneNumberCreationAllowed;
        }
        void FindPhoneNumber(string userInput)
        {
            phoneNumbers.Clear();
            phoneNumbers = (from x in humaneSocietyData.Phone_Numbers.Namespace
                            where x == Convert.ToChar(userInput)
                            select x).ToList();
        }
        int AddUser(string userNameInput, string passWordInput, string AddressInput, string genderInput,string phoneNumberInput)
        {
            HumaneSocietyDatabaseDataSet.UsersRow newUsersRow = humaneSocietyData.Users.NewUsersRow();
            newUsersRow.UserName_ID = AddUserNameID(userNameInput);
            newUsersRow.PassWord_ID = AddPassWordID(passWordInput);
            newUsersRow.Gender_ID = AddGenderID(genderInput);
            newUsersRow.Phone_Number_ID = AddPhoneNumberID(phoneNumberInput);
            return newUsersRow.User_ID;
        }
        int ReplaceUserName(int userID, string userNameInput)
        {
            if (CheckUserName(userNameInput) == true)
            {
                int newUserNameID = AddUserNameID(userNameInput);
                HumaneSocietyDatabaseDataSet.UsersRow currentUserRow = humaneSocietyData.Users.FindByUser_ID(userID);
                currentUserRow.UserName_ID = newUserNameID;
                return currentUserRow.UserName_ID;
               
            }
            else
            {
                FindUserName(userNameInput);
                return userNames[0];
            }
        }
        int ReplacePassWord(int userID, string passWordInput)
        {
            if (CheckPassWord(passWordInput) == true)
            {
                int newPassWordID = AddPassWordID(passWordInput);
                HumaneSocietyDatabaseDataSet.UsersRow currentUserRow = humaneSocietyData.Users.FindByUser_ID(userID);
                currentUserRow.PassWord_ID = newPassWordID;
                return newPassWordID;

            }
            else
            {
                FindPassword(passWordInput);
                return passWords[0];
            }
        }
        int ReplaceGender(int userID, string genderInput)
        {
            if (CheckGender(genderInput) == true)
            {
                int newGenderID = AddGenderID(genderInput);
                HumaneSocietyDatabaseDataSet.UsersRow currentUserRow = humaneSocietyData.Users.FindByUser_ID(userID);
                currentUserRow.Gender_ID = newGenderID;
                return newGenderID;

            }
            else
            {
                FindGender(genderInput);
                return genders[0];
            }
        }
        int ReplacePhoneNumber(int userID, string phoneNumberInput)
        {
            if (CheckGender(phoneNumberInput) == true)
            {
                int newPhoneNumberID = AddPhoneNumberID(phoneNumberInput);
                HumaneSocietyDatabaseDataSet.UsersRow currentUserRow = humaneSocietyData.Users.FindByUser_ID(userID);
                currentUserRow.Phone_Number_ID = newPhoneNumberID;
                return newPhoneNumberID;

            }
            else
            {
                FindPhoneNumber(phoneNumberInput);
                return phoneNumbers[0];
            }
        }
        int AddUserNameID(string userNameInput)
        {
            HumaneSocietyDatabaseDataSet.UserNamesRow newUserName = humaneSocietyData.UserNames.NewUserNamesRow();
            newUserName.User_Name = userNameInput;
            return newUserName.UserName_ID;
        }
        int AddPassWordID(string passWordInput)
        {
            if (CheckPassWord(passWordInput) == true)
            {
                HumaneSocietyDatabaseDataSet.PassWordsRow newPassWord = humaneSocietyData.PassWords.NewPassWordsRow();
                newPassWord.PassWord = passWordInput;
                return newPassWord.PassWord_ID;
            }
            else
            {
                FindPassword(passWordInput);
                return passWords[0];
            }

        }
        int AddGenderID(string genderInput)
        {
            if (CheckGender(genderInput) == true)
            {
                HumaneSocietyDatabaseDataSet.GendersRow newGender = humaneSocietyData.Genders.NewGendersRow();
                newGender.Gender_Name = genderInput;
                return newGender.Gender_ID;
            }
            else
            {
                FindGender(genderInput);
                return genderInput[0];
            }

        }
        int AddPhoneNumberID(string phoneNumberInput)
        {
            if (CheckPhoneNumber(phoneNumberInput) == true)
            {
                HumaneSocietyDatabaseDataSet.Phone_NumbersRow newPhoneNumber = humaneSocietyData.Phone_Numbers.NewPhone_NumbersRow();
                newPhoneNumber.Phone_Number = phoneNumberInput;
                return newPhoneNumber.Phone_Number_ID;
            }
            else
            {
                FindPhoneNumber(phoneNumberInput);
                return phoneNumbers[0];
            }
        }
    }
}
