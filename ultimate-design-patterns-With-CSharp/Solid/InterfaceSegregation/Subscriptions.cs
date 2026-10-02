using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid.InterfaceSegregation
{
    internal class Subscriptions : ISubscription, INotification
    {
        public void Subscribe(string userId, string topic)
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe(string userId, string topic)
        {
            throw new NotImplementedException();
        }

        public void DeleteNotification(string messageId)
        {
            throw new NotImplementedException();
        }

        public void SendNotification(string message, string recipient)
        {
            throw new NotImplementedException();
        }

      
    }
}
