using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid.InterfaceSegregation
{
    internal interface _IViolationsTaskExample
    {
        void CreateTask(string taskName);
        void AssignTask(string taskName, string assignee);
        void SendNotification(string message, string recipient);

        void DeleteNotification(string messageId);

        void EditTask(string taskName, string newTaskName);
    }

    internal class TaskService : _IViolationsTaskExample
    {
        public void CreateTask(string taskName)
        {
            // Logic to create a task
        }

        public void AssignTask(string taskName, string assignee)
        {
            // Logic to assign a task
        }

        public void SendNotification(string message, string recipient)
        {
            // Don't Need this Function
        }

        public void DeleteNotification(string messageId)
        {
            // Don't Need this Function
        }

        public void EditTask(string taskName, string newTaskName)
        {
            // Logic to assign a task
        }
    }

    internal class SubscriptionService : _IViolationsTaskExample
        {

            public void SendNotification(string message, string recipient)
            {
                // Need Notification Function
            }
            public void AssignTask(string taskName, string assignee)
            {
                // Don't Need this Function
            }

            public void CreateTask(string taskName)
            {
                // Don't Need this Function
            }

            public void DeleteNotification(string messageId)
            {
                // Don't Need this Function
            }

            public void EditTask(string taskName, string newTaskName)
            {
                // Don't Need this Function
            }

          
        }
}
