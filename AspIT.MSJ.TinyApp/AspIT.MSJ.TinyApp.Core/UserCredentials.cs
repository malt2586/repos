using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.MSJ.TinyApp.Core
{
    public class UserCredentials
    {
        //FIELDS
        private string username;
        private string password;

        //PROPERTIES
        public string Username
        {
            get { return username; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(Username));
                }
                username = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(Password));
                }
                password = value;
            }
        }

        //CONSTRUCTORS
        public UserCredentials(string username, string password)
        {
            try
            {
                Username = username;
                Password = password;
            }
            catch (ArgumentException)
            {
                throw;
            }
        }

        //METHODS
        public override string ToString()
        {
            return $"Bruger: {Username}, kodeord: {Password}";
        }

        public static bool IsUsernameValid(string username)
        {
            if (!String.IsNullOrWhiteSpace(username))
            {
                if (username.Length >= 4 && username.Length <= 8)
                {
                    foreach (char c in username)
                    {
                        if (!Char.IsLetter(c))
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
