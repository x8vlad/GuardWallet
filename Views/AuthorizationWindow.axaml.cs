using System;
using System.Net.Mail;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using Avalonia.Interactivity;
using GuardWallet.Services;

namespace GuardWallet.Views;

public partial class AuthorizationWindow : Window
{
    private WindowNotificationManager _notificationManager;
    public string userLogin { get; set; } =  string.Empty;
    public string userPassword { get; set; } =  string.Empty;
    public AuthorizationWindow()
    {
        InitializeComponent();
        
        this.DataContext = this;
        
        _notificationManager = new WindowNotificationManager(this) 
        { 
            Position = NotificationPosition.BottomRight, 
            MaxItems = 3 
        };
    }
    
    private void LoginButton_OnClick(object? sender, RoutedEventArgs e)
    {
        if (!ValidationServices.isLoginFormValid(userLogin, userPassword))
        {
            Console.Write("Some fields are missing or epmty\n");    
            
            NotificationService.NotificationFunction("Warning!", "Warning", "Some fields are missing or empty", _notificationManager);        }
        else
        {
            DashboardWindow dashboardWindow = new DashboardWindow();
            dashboardWindow.Show();
            this.Close();
        }
    }
}