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
        int userAge = int.Parse(ageUser.Text);
        // result.Text = $"Name user: {userName} Age user: {userAge}";

        MainBank bankWindow = new MainBank();
        
        bankWindow.Show();
        
        this.Close();
    }
}