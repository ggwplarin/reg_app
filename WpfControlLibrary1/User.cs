using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    [Serializable]
    class User
    {


        public string Login { get; set; }
        public string Password { get; set; }
        public string SecretQuestion { get; set; }
        public string SecretAnswer { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public string Passport { get; set; }

        public User(string login, string password, string secretQuestion, string secretAnswer, string eMail, string phoneNumber, string passport)
        {
            Login = login;
            Password = password;
            SecretQuestion = secretQuestion;
            SecretAnswer = secretAnswer;
            EMail = eMail;
            PhoneNumber = phoneNumber;
            Passport = passport;
        }
    }
}
