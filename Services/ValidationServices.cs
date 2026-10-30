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
}