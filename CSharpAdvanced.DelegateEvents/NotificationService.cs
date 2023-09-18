﻿namespace CSharpAdvanced.DelegateEvents;

public class NotificationService
{
    public void OnCustomerCreated(object sender, CustomerCreatedEventArgs e)
    {
        Console.WriteLine($"Notification: A new customer named {e.CustomerName} has been created!");
    }
}