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
        Queue<int> passWordIDs = new Queue<int>();
        Queue<int> addressIDs = new Queue<int>();
        Queue<int> genderIDs = new Queue<int>();
        Queue<int> phoneNumberIDs = new Queue<int>();
        Queue<int> addressNumberIDs = new Queue<int>();
        Queue<int> streetIDs = new Queue<int>();
        Queue<int> cityIDs = new Queue<int>();
        Queue<int> zipCodeIDs = new Queue<int>();
        Queue<int> stateIDs = new Queue<int>();
        Queue<string> employeePassWords = new Queue<string>();
        Queue<string> statuses = new Queue<string>();
        Queue<int> statusIDs = new Queue<int>();
        Queue<int> userIDs = new Queue<int>();
        //Add this to database later.

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
            var results = (from x in humaneSocietyData.UserNames
                         where x.User_Name == userInput
                         select x.User_Name).ToList();
            foreach (string result in results)
            {
                userNames.Enqueue(result);
            }
        }
        public bool CheckPreviousUserName(string userInput)
        {
            FindUserName(userInput);
            bool userInputCreationAllowed = CheckIfThereIsInput(userNames);
            return userInputCreationAllowed;
        }
        bool CheckIfThereIsInput(Queue<string> chosenList)
        {
            if (chosenList.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool CheckPreviousStatuses(string userInput)
        {
            FindStatus(userInput);
            bool statusCreationAllowed = CheckIfThereIsInput(statuses);
            return statusCreationAllowed;
        }

        void FindStatus(string userInput)
        {
            var results = (from x in humaneSocietyData.EmployeeStatuses
                           where x.Status_Name == userInput
                           select x.Status_Name).ToList();
            foreach (string result in results)
            {
                statuses.Enqueue(result);
            }
        }

        void FindStatusID(string userInput)
        {
            var results = (from x in humaneSocietyData.EmployeeStatuses
                           where x.Status_Name == userInput
                           select x.EmployeeStatus_ID).ToList();
            foreach (int result in results)
            {
                statusIDs.Enqueue(result);
            }
        }
        bool CheckPreviousPassWord(string userInput)
        {
            FindPassword(userInput);
            bool passWordCreationAllowed = CheckIfThereIsInput(passWords);
            return passWordCreationAllowed;
        }

        void FindPassword(string userInput)
        {
            var results = (from x in humaneSocietyData.PassWords
                         where x.PassWord == userInput
                         select x.PassWord).ToList();
            foreach (string result in results)
            {
                passWords.Enqueue(result);
            }
        }
        void FindPasswordID(string userInput)
        {
            var results = (from x in humaneSocietyData.PassWords
                           where x.PassWord == userInput
                           select x.PassWord_ID).ToList();
            foreach (int result in results)
            {
                passWordIDs.Enqueue(result);
            }
        }
        void FindEmployeePassWord(string userInput)
        {
            var results = (from x in humaneSocietyData.Employee_Passwords
                           where x.Employee_PassWord == userInput
                           select x.Employee_PassWord).ToList();
            foreach (string result in results)
            {
                employeePassWords.Enqueue(result);
            }
        }
        bool CheckPreviousEmployeePassWord(string userInput)
        {
            FindEmployeePassWord(userInput);
            bool employeePassWordCreationAllowed = CheckIfThereIsInput(employeePassWords);
            return employeePassWordCreationAllowed;
        }
        void FindGenderID(string userInput)
        {
            var results = (from x in humaneSocietyData.Genders
                           where x.Gender_Name == userInput
                           select x.Gender_ID).ToList();
            foreach (int result in results)
            {
                genderIDs.Enqueue(result);
            }
        }
        void FindUserNameID(string userInput)
        {
            var results = (from x in humaneSocietyData.UserNames
                           where x.User_Name == userInput
                           select x.UserName_ID).ToList();
            foreach (int result in results)
            {
                userNameIDs.Enqueue(result);
            }
        }
        void FindPhoneNumberID(string userInput)
        {
            var results = (from x in humaneSocietyData.Phone_Numbers
                           where x.Phone_Number == userInput
                           select x.Phone_Number_ID).ToList();
            foreach (int result in results)
            {
                phoneNumberIDs.Enqueue(result);
            }
        }
        void FindAddressNumberID(string userInput)
        {
            var results = (from x in humaneSocietyData.Address_Numbers
                           where x.Address_Number == userInput
                           select x.Address_Number_ID).ToList();
            foreach (int result in results)
            {
                addressNumberIDs.Enqueue(result);
            }
        }
        void FindStreetID(string userInput)
        {
            var results = (from x in humaneSocietyData.Streets
                           where x.Street_Name == userInput
                           select x.Street_ID).ToList();
            foreach (int result in results)
            {
                streetIDs.Enqueue(result);
            }
        }
        void FindCityID(string userInput)
        {
            var results = (from x in humaneSocietyData.Cities
                           where x.City_Name == userInput
                           select x.City_ID).ToList();
            foreach (int result in results)
            {
                cityIDs.Enqueue(result);
            }
        }
        void FindStateID(string userInput)
        {
            var results = (from x in humaneSocietyData.States
                           where x.State_Name == userInput
                           select x.State_ID).ToList();
            foreach (int result in results)
            {
                stateIDs.Enqueue(result);
            }
        }
        void FindZipCodeID(string userInput)
        {
            var results = (from x in humaneSocietyData.ZipCodes
                           where x.ZipCode_Number == userInput
                           select x.ZipCode_ID).ToList();
            foreach (int result in results)
            {
                zipCodeIDs.Enqueue(result);
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
            var results = (from x in humaneSocietyData.Cities
                         where x.City_Name == userInput
                         select x.City_Name).ToList();
            foreach (string result in results)
            {
                cities.Enqueue(result);
            }
        }
        bool CheckPreviousCities(string userInput)
        {
            bool CityCeationAllowed = CheckIfThereIsInput(cities);
            return CityCeationAllowed;
            // this will have to go more in depth since there are several foreign keys
        }
        void FindState(string userInput)
        {
           var results = (from x in humaneSocietyData.States
                      where x.State_Name == userInput
                      select x.State_Name).ToList();
            foreach (string result in results)
            {
                states.Enqueue(result);
            }
        }
        bool CheckPreviousStates(string userInput)
        {
            bool StateCeationAllowed = CheckIfThereIsInput(states);
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
        bool CheckPreviousZipCodes(string userInput)
        {
            bool ZipCodeCeationAllowed = CheckIfThereIsInput(zipCodes);
            return ZipCodeCeationAllowed;
            // this will have to go more in depth since there are several foreign keys
        }

        void FindStreet(string userInput)
        {
            var results = (from x in humaneSocietyData.Streets
                       where x.Street_Name == userInput
                       select x.Street_Name).ToList();
            foreach (string result in results)
            {
                streets.Enqueue(result);
            }
        }
        bool CheckPreviousStreets(string userInput)
        {
            bool StreetCeationAllowed = CheckIfThereIsInput(streets);
            return StreetCeationAllowed;
            // this will have to go more in depth since there are several foreign keys
        }
        void FindAddressNumber(string userInput)
        {
            var results  = (from x in humaneSocietyData.Address_Numbers
                              where x.Address_Number == userInput
                              select x.Address_Number).ToList();
            foreach (string result in results)
            {
                addressNumbers.Enqueue(result);
            }
        }
        bool CheckPreviousAddressNumber(string userInput)
        {
            bool AddressNumberCeationAllowed = CheckIfThereIsInput(addressNumbers);
            return AddressNumberCeationAllowed;
        }

        bool CheckPreviousGender(string userInput)
        {
            bool genderCreationAllowed = CheckIfThereIsInput(genders);
            return genderCreationAllowed;
        }
        void FindGender(string userInput)
        {
            var results = (from x in humaneSocietyData.Genders
                       where x.Gender_Name == userInput
                       select x.Gender_Name).ToList();
            foreach (string result in results)
            {
                genders.Enqueue(result);
            }
        }
        bool CheckPreviousPhoneNumber(string userInput)
        {
            bool phoneNumberCreationAllowed = CheckIfThereIsInput(phoneNumbers);
            return phoneNumberCreationAllowed;
        }
        void FindPhoneNumber(string userInput)
        {
            var results = (from x in humaneSocietyData.Phone_Numbers
                            where x.Phone_Number == userInput
                            select x.Phone_Number).ToList();
            foreach (string result in results)
            {
                phoneNumbers.Enqueue(result);
            }
        }
        public bool CheckPassWordMatchToUserID(int userIDInput)
        {
            var results = (from x in humaneSocietyData.Users
                           where x.User_ID == userIDInput
                           select x.PassWord_ID).ToList();
            foreach(int result in results)
            {
                MatchPassWordIDToPassword(result);
            }
            return CheckIfThereIsInput(passWords);
        }
        void MatchPassWordIDToPassword(int passwordIDInput)
        {
            var results = (from x in humaneSocietyData.PassWords
                          where x.PassWord_ID == passwordIDInput
                          select x.PassWord).ToList();
            foreach(string result in results)
            {
                passWords.Enqueue(result);
            }
        }
        public int MatchUserNameToUserNameID(string userNameImput)
        {
            FindUserNameID(userNameImput);
            var results = (from x in humaneSocietyData.Users
                           where x.UserName_ID == (userNameIDs.Dequeue())
                           select x.User_ID).ToList();
            foreach (int result in results)
            {
                userIDs.Enqueue(result);
            }
            return userIDs.Dequeue();
        }
        int MatchUserIDToUserStatusID(int userIDInput)
        {
            var results = (from x in humaneSocietyData.Users
                           where x.User_ID == userIDInput
                           select x.Status_ID).ToList();
            foreach (int result in results)
            {
                statusIDs.Enqueue(result);
            }
            return statusIDs.Dequeue();
        }
        public string MatchUserIDToUserStatus(int userIDInput)
        {

            var results = (from x in humaneSocietyData.EmployeeStatuses
                           where x.EmployeeStatus_ID == MatchUserIDToUserStatusID(userIDInput)
                           select x.Status_Name).ToList();
            foreach (string result in results)
            {
                statuses.Enqueue(result);
            }
            return statuses.Dequeue();
        }
   
        public int AddUser(string userNameInput, string passWordInput, string genderInput,string phoneNumberInput, string cityInput, string stateInput, string zipCodeInput, string streetInput, string addressNumberInput, string status)
        {
            HumaneSocietyDatabaseDataSet.UsersRow newUsersRow = humaneSocietyData.Users.NewUsersRow();
            newUsersRow.UserName_ID = AddUserNameID(userNameInput);
            newUsersRow.PassWord_ID = AddPassWordID(passWordInput);
            newUsersRow.Gender_ID = AddGenderID(genderInput);
            newUsersRow.Phone_Number_ID = AddPhoneNumberID(phoneNumberInput);
            newUsersRow.Address_ID = AddAddressID(cityInput,stateInput,zipCodeInput,streetInput, addressNumberInput);
            newUsersRow.Status_ID = AddStatusID(status);
            return newUsersRow.User_ID;
        }
        int ReplaceUserName(int userID, string userNameInput)
        {
            if (CheckPreviousUserName(userNameInput) == true)
            {
                int newUserNameID = AddUserNameID(userNameInput);
                HumaneSocietyDatabaseDataSet.UsersRow currentUserRow = humaneSocietyData.Users.FindByUser_ID(userID);
                currentUserRow.UserName_ID = newUserNameID;
                return currentUserRow.UserName_ID;
            }
            else
            {
                FindUserNameID(userNameInput);
                return userNameIDs.Dequeue();
            }
        }
        int ReplacePassWord(int userID, string passWordInput)
        {
            if (CheckPreviousPassWord(passWordInput) == true)
            {
                int newPassWordID = AddPassWordID(passWordInput);
                HumaneSocietyDatabaseDataSet.UsersRow currentUserRow = humaneSocietyData.Users.FindByUser_ID(userID);
                currentUserRow.PassWord_ID = newPassWordID;
                return newPassWordID;

            }
            else
            {
                FindPasswordID(passWordInput);
                return passWordIDs.Dequeue();

            }
        }
        int ReplaceGender(int userID, string genderInput)
        {
            if (CheckPreviousGender(genderInput) == true)
            {
                int newGenderID = AddGenderID(genderInput);
                HumaneSocietyDatabaseDataSet.UsersRow currentUserRow = humaneSocietyData.Users.FindByUser_ID(userID);
                currentUserRow.Gender_ID = newGenderID;
                return newGenderID;

            }
            else
            {
                FindGenderID(genderInput);
                return genderIDs.Dequeue();
            }
        }
        int ReplacePhoneNumber(int userID, string phoneNumberInput)
        {
            if (CheckPreviousGender(phoneNumberInput) == true)
            {
                int newPhoneNumberID = AddPhoneNumberID(phoneNumberInput);
                HumaneSocietyDatabaseDataSet.UsersRow currentUserRow = humaneSocietyData.Users.FindByUser_ID(userID);
                currentUserRow.Phone_Number_ID = newPhoneNumberID;
                return newPhoneNumberID;

            }
            else
            {
                FindPhoneNumberID(phoneNumberInput);
                return phoneNumberIDs.Dequeue();
            }
        }
        int AddUserNameID(string userNameInput)
        {
            if (CheckPreviousUserName(userNameInput) == false)
            {
                HumaneSocietyDatabaseDataSet.UserNamesRow newUserName = humaneSocietyData.UserNames.NewUserNamesRow();
                newUserName.User_Name = userNameInput;
                return newUserName.UserName_ID;
            }
            else
            {
                FindUserNameID(userNameInput);
                return userNameIDs.Dequeue();
            }

        }
        int AddPassWordID(string passWordInput)
        {
            if (CheckPreviousPassWord(passWordInput) == false)
            {
                HumaneSocietyDatabaseDataSet.PassWordsRow newPassWord = humaneSocietyData.PassWords.NewPassWordsRow();
                newPassWord.PassWord = passWordInput;
                return newPassWord.PassWord_ID;
            }
            else
            {
                FindPasswordID(passWordInput);
                return passWordIDs.Dequeue();
            }

        }
        int AddGenderID(string genderInput)
        {
            if (CheckPreviousGender(genderInput) == false)
            {
                HumaneSocietyDatabaseDataSet.GendersRow newGender = humaneSocietyData.Genders.NewGendersRow();
                newGender.Gender_Name = genderInput;
                return newGender.Gender_ID;
            }
            else
            {
                FindGenderID(genderInput);
                return genderIDs.Dequeue();
            }

        }
        int AddPhoneNumberID(string phoneNumberInput)
        {
            if (CheckPreviousPhoneNumber(phoneNumberInput) == false)
            {
                HumaneSocietyDatabaseDataSet.Phone_NumbersRow newPhoneNumber = humaneSocietyData.Phone_Numbers.NewPhone_NumbersRow();
                newPhoneNumber.Phone_Number = phoneNumberInput;
                return newPhoneNumber.Phone_Number_ID;
            }
            else
            {
                FindPhoneNumberID(phoneNumberInput);
                return genderIDs.Dequeue();
            }
        }
        int AddStatusID(string statusInput)
        {
            if (CheckPreviousStatuses(statusInput) == false)
            {
                HumaneSocietyDatabaseDataSet.EmployeeStatusesRow newStatusesRow = humaneSocietyData.EmployeeStatuses.NewEmployeeStatusesRow();
                newStatusesRow.Status_Name = statusInput;
                return newStatusesRow.EmployeeStatus_ID;
            }
            else
            {
                FindStatusID(statusInput);
                return statusIDs.Dequeue();
            }

        }
        int AddAddressID(string cityInput, string stateInput, string zipCodeInput, string streetInput, string addressNumberInput)
        {
            HumaneSocietyDatabaseDataSet.AddressesRow newAddressesRow = humaneSocietyData.Addresses.NewAddressesRow();
                newAddressesRow.City_ID = AddCityID(cityInput);
                newAddressesRow.State_ID = AddStateID(stateInput);
                newAddressesRow.ZipCode_ID = AddZipCodeID(zipCodeInput);
                newAddressesRow.Street_ID = AddStreetID(streetInput);
                newAddressesRow.Address_Number_ID = AddAddressNumberID(addressNumberInput);
            return newAddressesRow.Address_ID;
        }
        int AddCityID(string cityInput)
        {
            if (CheckPreviousCities(cityInput) == false)
            {
                HumaneSocietyDatabaseDataSet.CitiesRow newCitiesRow = humaneSocietyData.Cities.NewCitiesRow();
                newCitiesRow.City_Name = cityInput;
                return newCitiesRow.City_ID;
            }
            else
            {
                FindCityID(cityInput);
                return cityIDs.Dequeue();
            }

        }

        int AddStateID(string stateInput)
        {
            if (CheckPreviousStates(stateInput) == false)
            {
                HumaneSocietyDatabaseDataSet.StatesRow newStatesRow = humaneSocietyData.States.NewStatesRow();
                newStatesRow.State_Name = stateInput;
                return newStatesRow.State_ID;
            }
            else
            {
                FindStateID(stateInput);
                return stateIDs.Dequeue();
            }

        }
        int AddZipCodeID(string zipCodeInput)
        {
            if (CheckPreviousZipCodes(zipCodeInput) == false)
            {
                HumaneSocietyDatabaseDataSet.ZipCodesRow newZipCodesRow = humaneSocietyData.ZipCodes.NewZipCodesRow();
                newZipCodesRow.ZipCode_Number = zipCodeInput;
                return newZipCodesRow.ZipCode_ID;
            }
            else
            {
                FindZipCodeID(zipCodeInput);
                return zipCodeIDs.Dequeue();
            }
        }
        int AddStreetID(string streetInput)
        {
            if (CheckPreviousStreets(streetInput) == false)
            {
                HumaneSocietyDatabaseDataSet.StreetsRow newStreetsRow = humaneSocietyData.Streets.NewStreetsRow();
                newStreetsRow.Street_Name = streetInput;
                return newStreetsRow.Street_ID;
            }
            else
            {
                FindStreetID(streetInput);
                return streetIDs.Dequeue();
            }
        }
        int AddAddressNumberID(string addressNumberInput)
        {
            if (CheckPreviousAddressNumber(addressNumberInput) == false)
            {
                HumaneSocietyDatabaseDataSet.Address_NumbersRow newAddressNumbersRow = humaneSocietyData.Address_Numbers.NewAddress_NumbersRow();
                newAddressNumbersRow.Address_Number = addressNumberInput;
                return newAddressNumbersRow.Address_Number_ID; ;
            }
            else
            {
                FindAddressNumber(addressNumberInput);
                return addressIDs.Dequeue();
            }
        }
    }
}
