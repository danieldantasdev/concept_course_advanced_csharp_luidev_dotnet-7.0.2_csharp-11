﻿namespace CSharpAdvanced.DelegateEvents
{
	public class IntegrationService
	{
        public void OnCustomerCreated(object sender, CustomerCreatedEventArgs e)
        {
            Console.WriteLine($"Integration: A new customer named {e.CustomerName} has been created!");
        }
    }
}

