using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;


namespace GuardWallet;

public partial class MainWindow : Window
{
   
    
 
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Authorization_Click(object? sender, RoutedEventArgs routedEventArgs)
    {
        // Debug.WriteLine("Sent data");
        string userName = nameUser.Text;
        string userPassword = passwordUser.Text;
        // result.Text = $"Name user: {userName} Age user: {userAge}";

        if (!string.IsNullOrEmpty(userPassword) && !string.IsNullOrEmpty(userName))
        {
            MainBank bankWindow = new MainBank(userName);
            bankWindow.Show(); 
            this.Close();
        }
    }
}