using Avalonia.Controls;
using Avalonia.Interactivity;

namespace GuardWallet.Views;

public partial class WelcomeWindow : Window
{
    public WelcomeWindow()
    {
        InitializeComponent();
    }

    private void RegisterButton_OnClick(object? sender, RoutedEventArgs e)
    {
        RegisterWindow registerWindow = new RegisterWindow();
        registerWindow.Show();
        this.Close();
    }

    private void AuthorizationButton_OnClick(object? sender, RoutedEventArgs e)
    {
        AuthorizationWindow authorizationWindow = new AuthorizationWindow();
        authorizationWindow.Show();
        this.Close();
    }
}