using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid
{
    internal class NotificationServices
    {
        internal void SendEmailNotification(Customer customer, string message)
        {
            Console.WriteLine($"Sending email notification to: {customer.Email} with message: {message}");
        }
    }
}
