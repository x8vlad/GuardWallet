using System.Runtime.CompilerServices;

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
    

    public static bool ArePasswordsEqual(string password, string repeatedPassword)
    {
        
        if(!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(repeatedPassword) && password == repeatedPassword)
        {
            return true;
        }
        return false;
    }
}