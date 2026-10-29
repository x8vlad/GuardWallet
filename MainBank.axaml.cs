using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GuardWallet;

public partial class MainBank : Window
{
    
    public MainBank(string nameUser)
    {
        InitializeComponent();
        
        string currentUser = nameUser;

        this.Title = "Guard Wallet";
        welcome.Text = $"Welcome {currentUser}!";
    }
}