using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace GuardWallet;

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
        if (!checkFields(userLogin, userEmail, userPassword, userRepeatedPassword))
        {
            Console.Write("Some fields are missing or epmty\n");
        }
        else
        {
            Console.Write($"\nUser login: {userLogin}, \nUser email: {userEmail}, \nUser password: {userPassword} \nUser repeated password: {userRepeatedPassword}");
        }
    }

    private bool checkFields(string name, string email, string password, string repeatedPassword)
    {
        if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) 
                                        && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(repeatedPassword))
        {
           return true;
        }
        return false;
    }
}