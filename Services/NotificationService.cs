using System;
using Avalonia.Controls;
using Avalonia.Controls.Notifications;

namespace GuardWallet.Services;

public  static class NotificationService
{

    public static void NotificationFunction(string title, string notificationType, string message, WindowNotificationManager notificationManager)     {

        Console.WriteLine("Notification Function");
        Console.WriteLine($"Notification type: {notificationType}");
        
        
        switch (notificationType)
        {
            case "Info":
                notificationManager.Show(new Notification(
                    title,
                    message,
                    NotificationType.Information,
                    TimeSpan.FromSeconds(3)));
                break;
            case "Warning":
                Console.WriteLine("In warning case");
                notificationManager.Show(new Notification(
                    title,
                    message,
                    NotificationType.Warning,
                    TimeSpan.FromSeconds(3)));
                break;
            case "Success":
                notificationManager.Show(new Notification(
                    title,
                    message,
                    NotificationType.Success,
                    TimeSpan.FromSeconds(3)));
                break;
            case "Error":
                notificationManager.Show(new Notification(
                    title,
                    message,
                    NotificationType.Error,
                    TimeSpan.FromSeconds(3)));
                break;
        }
        
        
    }
}