using System;
using System.Text.RegularExpressions;
namespace UserRegistrationForm
{
    public class Registration
    {
        public static bool CheckUserName(string name)
        {
            string pattern = @"^[A-Z]{1}[a-z0-9_.+@-]{2,}$";
            Match m = Regex.Match(name, pattern);
            if (m.Success)
            {
                return true;
            }
            else
                return false;
        }
        public static bool CheckMobileNumber(string mob)
        {
            string pattern1 = @"^[+91]{3}[0-9]{10}$";
            Match match = Regex.Match(mob,pattern1);
            if (match.Success)
            {
                return true;
            }
            else
                return false;
        }

        public static bool CheckEmail(string email)
        {
            string epattern = @"^[a-z0-9-.$#]+@[a-z0-9-+]+\.?com$";

            Match match1 = Regex.Match(email, epattern);
            if (match1.Success)
            {
                return true;
            }
                return false;
        }
        public static bool CheckPassword(string pwd)
        {
            string pwdpattern = @"^[A_Za-z0-9@#$.+]{8,}";
            Match match2 = Regex.Match(pwd, pwdpattern);
            if (match2.Success)
                return true;
             return false;
        }
        public static void Main()
        {
            Console.WriteLine("vuhsisisisisisisi");
        }
        }
    }

