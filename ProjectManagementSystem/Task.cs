using System;
namespace ProjectManagementSystem
{
    public class Task
    {
        public Task()
        {
        }

        #region Task Attributes
        /* Note:
         1. Responsible for handling the details related around task
        */

        private int _taskId;
        public int TaskId
        {
            get { return _taskId; }
            set { _taskId = value; }
        }

        private string _taskName;
        public string TaskName
        {
            get { return _taskName; }
            set { _taskName = value; }
        }

        private int _taskTimeAllotted;
        public int TaskTimeAllotted
        {
            get { return _taskTimeAllotted; }
            set { TaskTimeAllotted = value; }
        }

        private int _taskTimeSpent;
        public int TaskTimeSpent
        {
            get { return _taskTimeSpent; }
            set { _taskTimeSpent = value; }
        }

        private ResourceAvailable _resourceAlloted;
        public ResourceAvailable ResourceAlloted
        {
            get { return _resourceAlloted; }
            set { _resourceAlloted = value; }
        }

        #endregion

        #region
        /*Note:
         1. Task mapped with project id to categorize the tasks under the project 
         */

        private int _projectId;
        public int ProjectId
        {
            get { return _projectId; }
            set { _projectId = value; }
        }

        #endregion
    }
}
