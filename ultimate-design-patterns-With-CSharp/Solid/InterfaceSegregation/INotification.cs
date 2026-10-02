using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid.InterfaceSegregation
{
    internal interface INotification
    {
        void SendNotification(string message, string recipient);
        void DeleteNotification(string messageId);
    }
}
