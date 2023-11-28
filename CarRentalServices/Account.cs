using System.Collections.Generic;

namespace CarRentalServices
{
    public class Account
    {
        public static Dictionary<string, string> loginPairs = new Dictionary<string, string>();//Key = Username, Value = Password
        public static Dictionary<string, Account> accountList = new Dictionary<string, Account>(); //Key = Username, Value = Account

        protected string username;
        protected string password;
        
    }
}