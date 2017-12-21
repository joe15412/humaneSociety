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
        List<char> userNames = new List<char>();
        

       public Management()
        {
            humaneSocietyData = new HumaneSocietyDatabaseDataSet();
        }

        void FindUserName(char userInput )
        {
            userNames = (from x in humaneSocietyData.Users.UserName_IDColumn.Namespace
                         where x == userInput
                         select x).ToList();
        }
        bool CheckUserName()
        {
            if (userNames.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void AddUser(char userNameInput, char passWordInput, char AddressInput, char genderInput, char phoneNumberInput)
        {
            HumaneSocietyDatabaseDataSet.UsersRow newUsersRow = humaneSocietyData.Users.NewUsersRow();
            newUsersRow.UserName_ID = userNameInput;
            newUsersRow.PassWord_ID = passWordInput;
            newUsersRow.Gender_ID = genderInput;
            newUsersRow.PassWord_ID = phoneNumberInput;
            
        }

    }
}
