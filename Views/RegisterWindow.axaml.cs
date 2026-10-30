using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using GuardWallet.Services;

namespace GuardWallet.Views;

public partial class RegisterWindow : Window
{
    public string userLogin { get; set; } = string.Empty;
    public string userEmail { get; set; } = string.Empty;
    public string userPassword { get; set; } = string.Empty;
    public string userRepeatedPassword { get; set; } = string.Empty;
    public RegisterWindow()
    {
        InitializeComponent();

        this.DataContext = this;
    }
    
    private void RegisterButton_Click(object? sender, RoutedEventArgs e)
    {
        if (!ValidationServices.isRegisterFormValid(userLogin, userEmail, userPassword, userRepeatedPassword))
        {
            Console.Write("Some fields are missing or epmty\n");
        }
        
        else if (!ValidationServices.ArePasswordsEqual(userPassword, userRepeatedPassword))
        {
            Console.WriteLine("password do not match");
        }
        
        else
        {
            Console.Write($"\nUser login: {userLogin}, \nUser email: {userEmail}, \nUser password: {userPassword} \nUser repeated password: {userRepeatedPassword}");
        }
        
        
    }

   
}