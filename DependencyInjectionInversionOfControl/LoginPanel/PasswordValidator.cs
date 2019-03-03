using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Dependency_Injection___Inversion_of_Control
{
    public interface IPasswordValidator
    {
        bool PasswordValidate(string password);
    }

    public class PasswordValidator: IPasswordValidator
    {
        string PasswordPattern = @"(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}";

        public bool PasswordValidate(string password)
        {
            Match passwordmatchresult = Regex.Match(password, PasswordPattern);

            if (passwordmatchresult.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
