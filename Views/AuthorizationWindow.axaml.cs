using Avalonia.Controls;
using Avalonia.Interactivity;

namespace GuardWallet.Views;

public partial class AuthorizationWindow : Window
{
    public AuthorizationWindow()
    {
        InitializeComponent();
    }
    
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        string userLoginCS = userLogin.Text;
        string userPasswordCS = userPassword.Text;
        // result.Text = $"Name user: {userName} Age user: {userAge}";

        if (!string.IsNullOrEmpty(userPasswordCS) && !string.IsNullOrEmpty(userLoginCS))
        {
            
        }
    }
}