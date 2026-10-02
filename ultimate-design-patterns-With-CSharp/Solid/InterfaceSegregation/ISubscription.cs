using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid.InterfaceSegregation
{
    internal interface ISubscription
    {
        void Subscribe(string userId, string topic);
        void Unsubscribe(string userId, string topic);
    }
}
