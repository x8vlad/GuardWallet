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

    private void SendData_Click(object? sender, RoutedEventArgs routedEventArgs)
    {
        // Debug.WriteLine("Sent data");
        var nameUser = this.nameUser.Text;
        var ageUser = this.ageUser.Text;
        Debug.WriteLine("Sent data: " + "\nName user: " + nameUser + "\nAge user: " + ageUser);
    }
}