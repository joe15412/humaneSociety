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
        Queue<int> userNameIDs = new Queue <int>();
        Queue<string> userNames = new Queue<string>();
        Queue<string> passWords = new Queue<string>();
        Queue<string> addresses = new Queue<string>();
        Queue<string> genders = new Queue<string>();
        Queue<string> phoneNumbers = new Queue<string>();
        Queue<string> addressNumbers = new Queue<string>();
        Queue<string> streets = new Queue<string>();
        Queue<string> cities = new Queue<string>();
        Queue<string> zipCodes = new Queue<string>();
        Queue<string> states = new Queue<string>();

        //Add this to database later.
        public string employeePassWord = "1234";

        public Management()
        {
            humaneSocietyData = new HumaneSocietyDatabaseDataSet();
        }

        //void FindUserNameID(string userInput)
        //{
        //    userNameIDs.Clear();
        //    userNameIDs = (from x in humaneSocietyData.Users.FindByUser_ID()
        //                 where x == Convert.ToInt32(userInput)
        //                 select x).ToList();
        //}
        void FindUserName(string userInput )
        {
            userNames.Clear();
            var results = (from x in humaneSocietyData.UserNames
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
            FindPasswords(userInput);
            bool passWordCreationAllowed = CheckList(passWords);
            return passWordCreationAllowed;
        }

        void FindPasswords(string userInput)
        {
            passWords.Clear();
            var results = (from x in humaneSocietyData.PassWords
                         where x.PassWord == userInput
                         select x.PassWord).ToList();
            foreach (string result in results)
            {
                passWords.Enqueue(result);
            }
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
            var results = (from x in humaneSocietyData.Cities
                         where x.City_Name == userInput
                         select x.City_Name).ToList();
            foreach (string result in results)
            {
                cities.Enqueue(result);
            }
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
           var results = (from x in humaneSocietyData.States
                      where x.State_Name == userInput
                      select x.State_Name).ToList();
            foreach (string result in results)
            {
                states.Enqueue(result);
            }
        }
        bool CheckStates(string userInput)
        {
            bool StateCeationAllowed = CheckList(states);
            return StateCeationAllowed;
            // this will have to go more in depth since there are several foreign keys
        }
        void FindZipCode(string userInput)
        {
           var results = (from x in humaneSocietyData.ZipCodes
                      where x.ZipCode_Number == userInput
                      select x.ZipCode_Number).ToList();
            foreach (string result in results)
            {
                zipCodes.Enqueue(result);
            }
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
            var results = (from x in humaneSocietyData.Streets
                       where x.Street_Name == userInput
                       select x.Street_Name).ToList();
            foreach (string result in results)
            {
                streets.Enqueue(result);
            }
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
            var results  = (from x in humaneSocietyData.Address_Numbers
                              where x.Address_Number == userInput
                              select x.Address_Number).ToList();
            foreach (string result in results)
            {
                addressNumbers.Enqueue(result);
            }
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
            var results = (from x in humaneSocietyData.Genders
                       where x.Gender_Name == userInput
                       select x.Gender_Name).ToList();
            foreach (string result in results)
            {
                genders.Enqueue(result);
            }
        }
        bool CheckPhoneNumber(string userInput)
        {
            bool phoneNumberCreationAllowed = CheckList(phoneNumbers);
            return phoneNumberCreationAllowed;
        }
        void FindPhoneNumber(string userInput)
        {
            phoneNumbers.Clear();
            var results = (from x in humaneSocietyData.Phone_Numbers
                            where x.Phone_Number == userInput
                            select x.Phone_Number).ToList();
            foreach (string result in results)
            {
                phoneNumbers.Enqueue(result);
            }
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
