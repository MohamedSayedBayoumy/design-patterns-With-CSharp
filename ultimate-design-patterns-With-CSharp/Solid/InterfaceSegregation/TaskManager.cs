using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid.InterfaceSegregation
{
    internal class TaskManager : ITasker
    {
        public void AssignTask(string taskName, string assignee)
        {
            throw new NotImplementedException();
        }

        public void CreateTask(string taskName)
        {
            throw new NotImplementedException();
        }

        public void EditTask(string taskName, string newTaskName)
        {
            throw new NotImplementedException();
        }
    }
}
