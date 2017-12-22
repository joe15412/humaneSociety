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
        Queue<string> userNames = new Queue<string>();
        List<char> passWords = new List<char>();
        List<char> addresses = new List<char>();
        List<char> genders = new List<char>();
        List<char> phoneNumbers = new List<char>();
        List<char> addressNumbers = new List<char>();
        List<char> streets = new List<char>();
        List<char> cities = new List<char>();
        List<char> zipCodes = new List<char>();
        List<char> states = new List<char>();

        //Add this to database later.
        public string employeePassWord = "1234";

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
            var results = (from x in humaneSocietyData.UserNames// need to fix this
                         where x.User_Name == userInput
                         select x.User_Name).ToList();
            foreach (string result in results)
            {
                userNames.Enqueue(result);
            }
        }
        //void FindUserName2(string userInput)
        //{
        //    var matchedUserName = humaneSocietyData.UserNames.FindByUserName_ID(userInput)    Where(userName => userName.ToString() == userInput);

        //}
        //void FindUserNameID(string userInput)
        //{
        //    userNameIDs.Clear();
        //    userNameIDs = (from x in humaneSocietyData.Users.FindByUser_ID()
        //                 where x == Convert.ToInt32(userInput)
        //                 select x).ToList();
        //}
        public bool CheckUserName(string userInput)
        {
            FindUserName(userInput);
            bool userInputCreationAllowed = CheckList(userNames);
            return userInputCreationAllowed;
        }
        bool CheckList(Queue<string> chosenList)
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
        //bool CheckAddress(string userInput)
        //{
        //    bool AddressCreationAllowed = CheckList(addresses);
        //    return AddressCreationAllowed;
        //    // this will have to go more in depth since there are several foreign keys
        //}
        //void FindAddress(string userInput)
        //{
        //    addresses.Clear();
        //    addresses = (from x in humaneSocietyData.PassWords.Namespace
        //                 where x == Convert.ToChar(userInput)
        //                 select x).ToList();
        //}
        void FindCity(string userInput)
        {
            cities.Clear();
            cities = (from x in humaneSocietyData.Cities.Namespace
                         where x == Convert.ToChar(userInput)
                         select x).ToList();
        }
        bool CheckCities(string userInput)
        {
            bool CityCeationAllowed = CheckList(cities);
            return CityCeationAllowed;
            // this will have to go more in depth since there are several foreign keys
        }
        void FindState(string userInput)
        {
            states.Clear();
            states = (from x in humaneSocietyData.States.Namespace
                      where x == Convert.ToChar(userInput)
                      select x).ToList();
        }
        bool CheckStates(string userInput)
        {
            bool StateCeationAllowed = CheckList(states);
            return StateCeationAllowed;
            // this will have to go more in depth since there are several foreign keys
        }
        void FindZipCode(string userInput)
        {
            zipCodes.Clear();
            zipCodes = (from x in humaneSocietyData.ZipCodes.Namespace
                      where x == Convert.ToChar(userInput)
                      select x).ToList();
        }
        bool CheckZipCodes(string userInput)
        {
            bool ZipCodeCeationAllowed = CheckList(zipCodes);
            return ZipCodeCeationAllowed;
            // this will have to go more in depth since there are several foreign keys
        }

        void FindStreet(string userInput)
        {
            streets.Clear();
            streets = (from x in humaneSocietyData.Streets.Namespace
                       where x == Convert.ToChar(userInput)
                       select x).ToList();
        }
        bool CheckStreets(string userInput)
        {
            bool StreetCeationAllowed = CheckList(streets);
            return StreetCeationAllowed;
            // this will have to go more in depth since there are several foreign keys
        }
        void FindAddressNumber(string userInput)
        {
            addressNumbers.Clear();
            addressNumbers = (from x in humaneSocietyData.Address_Numbers.Namespace
                              where x == Convert.ToChar(userInput)
                              select x).ToList();
        }
        bool CheckAddressNumber(string userInput)
        {
            bool AddressNumberCeationAllowed = CheckList(addressNumbers);
            return AddressNumberCeationAllowed;
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
        public int AddUser(string userNameInput, string passWordInput, string genderInput,string phoneNumberInput, string cityInput, string stateInput, string zipCodeInput, string streetInput, string addressNumberInput)
        {
            HumaneSocietyDatabaseDataSet.UsersRow newUsersRow = humaneSocietyData.Users.NewUsersRow();
            newUsersRow.UserName_ID = AddUserNameID(userNameInput);
            newUsersRow.PassWord_ID = AddPassWordID(passWordInput);
            newUsersRow.Gender_ID = AddGenderID(genderInput);
            newUsersRow.Phone_Number_ID = AddPhoneNumberID(phoneNumberInput);
            newUsersRow.Address_ID = AddAddress(cityInput,stateInput,zipCodeInput,streetInput, addressNumberInput);
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
        int AddAddress(string cityInput, string stateInput, string zipCodeInput, string streetInput, string addressNumberInput)
        {
            HumaneSocietyDatabaseDataSet.AddressesRow newAddressesRow = humaneSocietyData.Addresses.NewAddressesRow();
                newAddressesRow.City_ID = AddCityID(cityInput);
                newAddressesRow.State_ID = AddStateID(stateInput);
                newAddressesRow.ZipCode_ID = AddZipCodeID(zipCodeInput);
                //newAddressesRow.Street_ID = AddStreetID(streetInput);
                //newAddressesRow.Address_Number_ID = AddAddressNumberID(addressNumberInput);
                return newAddressesRow.Address_ID;
        }
        int AddCityID(string cityInput)
        {
            if (CheckCities(cityInput) == true)
            {
                HumaneSocietyDatabaseDataSet.CitiesRow newCitiesRow = humaneSocietyData.Cities.NewCitiesRow();
                newCitiesRow.City_Name = cityInput;
                return newCitiesRow.City_ID;
            }
            else
            {
                FindCity(cityInput);
                return cities[0];
            }

        }

        int AddStateID(string stateInput)
        {
            if (CheckStates(stateInput) == true)
            {
                HumaneSocietyDatabaseDataSet.StatesRow newStatesRow = humaneSocietyData.States.NewStatesRow();
                newStatesRow.State_Name = stateInput;
                return newStatesRow.State_ID;
            }
            else
            {
                FindCity(stateInput);
                return cities[0];
            }

        }
        int AddZipCodeID(string zipCodeInput)
        {
            if (CheckZipCodes(zipCodeInput) == true)
            {
                HumaneSocietyDatabaseDataSet.ZipCodesRow newZipCodesRow = humaneSocietyData.ZipCodes.NewZipCodesRow();
                newZipCodesRow.ZipCode_Number = zipCodeInput;
                return newZipCodesRow.ZipCode_ID;
            }
            else
            {
                FindZipCode(zipCodeInput);
                return zipCodes[0];
            }
        }
        //int AddStreetID(string streetInput)
        //{
        //    if (CheckStreets(streetInput) == true)
        //    {
        //        HumaneSocietyDatabaseDataSet.StreetsRow newStreetsRow = humaneSocietyData.Streets.NewStreetsRow();
        //        newStreetsRow.Streets_Name = streetInput;
        //        return newStreetsRow.Streets_ID;
        //    }
        //    else
        //    {
        //        FindStreet(streetInput);
        //        return streets[0];
        //    }
        //}
        //int AddAddressNumberID(string addressNumberInput)
        //{
        //    if (CheckAddressNumber(addressNumberInput) == true)
        //    {
        //        HumaneSocietyDatabaseDataSet.Address_NumbersRow newAddressNumbersRow = humaneSocietyData.Address_Numbers.NewAddress_NumbersRow();
        //        newAddressNumbersRow.Address_Number = addressNumberInput;
        //        return newAddressNumbersRow.Address_Number_ID; ;
        //    }
        //    else
        //    {
        //        FindAddressNumber(addressNumberInput);
        //        return addressNumbers[0];
        //    }
        //}
    }
}
