using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace GuardWallet.Services;

public static class ValidationServices
{
    public static bool isRegisterFormValid(string name, string email, string password, string repeatedPassword)
    {
        if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) 
                                        && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(repeatedPassword))
        {
            return true;
        }
        return false;
    }

    public static bool isLoginFormValid(string name, string password)
    {
        if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(password))
        {
            return true;
        }

        return false;
    }

    public static bool isEmailValid(string email)
    {
        string pattern = "^[a-zA-Z0-9]+@{1}[a-zA-Z0-9]+\\.[a-zA-Z]+$";
        bool isMatch = Regex.IsMatch(email, pattern);
        return isMatch;
    }

    public static bool ArePasswordsEqual(string password, string repeatedPassword)
    {
        
        if(!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(repeatedPassword) && password == repeatedPassword)
        {
            return true;
        }
        return false;
    }
}