using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using GuardWallet.Services;

namespace GuardWallet.Views;

public partial class AuthorizationWindow : Window
{
    public string userLogin { get; set; } =  string.Empty;
    public string userPassword { get; set; } =  string.Empty;
    public AuthorizationWindow()
    {
        InitializeComponent();
        
        this.DataContext = this;
    }
    
    private void LoginButton_OnClick(object? sender, RoutedEventArgs e)
    {
        if (!ValidationServices.isLoginFormValid(userLogin, userPassword))
        {
            Console.Write("Some fields are missing or epmty\n");
        }
        else
        {
            Console.Write($"Login successful, data: \n {userLogin}, {userPassword}");
        }
    }
}