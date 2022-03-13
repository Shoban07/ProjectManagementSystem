using System;
using System.Collections.Generic;

namespace ProjectManagementSystem
{
    public class Project
    {
        //Initializes the project object
        public Project()
        {
        }

     #region properties

        #region Project Attributes
        private string _projectName;
            public string ProjectName
            {
                get{ return _projectName; }
                set { _projectName = value; }
            }

            private int _projectId;
            public int ProjectId
            {
                get { return _projectId; }
                set { _projectId = value; }
            }

            private int _HoursAllotted;
            public int HoursAllotted
            {
                get { return _HoursAllotted; }
                set { _HoursAllotted = value; }
            }

            private Status _projectStatus;
            public Status ProjectStatus
            {
            get { return _projectStatus; }
            set { _projectStatus = value; }
            }
        #endregion

        #region ProjectTaskAttributes
        private List<Task> _taskList;
        public List<Task> TaskList
        {
            get { return _taskList; }
            set { _taskList = value; }
        }
        #endregion

        #endregion
    }
}
