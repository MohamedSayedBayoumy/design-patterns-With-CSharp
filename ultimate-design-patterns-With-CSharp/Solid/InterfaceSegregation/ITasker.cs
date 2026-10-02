using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid.InterfaceSegregation
{
    internal interface ITasker
    {
        public void CreateTask(string taskName);
        public void AssignTask(string taskName, string assignee);
        void EditTask(string taskName, string newTaskName);

    }
}
