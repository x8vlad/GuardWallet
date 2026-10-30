using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace GuardWallet;

public partial class RegisterWindow : Window
{
    public RegisterWindow()
    {
        InitializeComponent();
    }

    public RegisterWindow(string? userLoginCS) : this()
    {
        
    }

    private void RegisterButton_Click(object? sender, RoutedEventArgs e)
    {
        AuthorizationWindow authorizationWindow = new AuthorizationWindow();
        authorizationWindow.Show();
        this.Close();
    }
}