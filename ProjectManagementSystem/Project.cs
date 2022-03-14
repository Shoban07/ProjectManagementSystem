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

        #region functionsforTaskCalculation

        /*
         * Method 1: function to calculate total task hours
         */
        public int TaskHoursCalculation()
        {
            int _taskHours = 0;

            foreach(Task task in TaskList)
            {
                _taskHours += task.TaskTimeAllotted;
            }

            return _taskHours;
        }


        /*
         * Method 2: function to predict project is deliverable or not based on given time
         */
        public Boolean PredictedProjectDelivery()
        {

            // Time required for sequence of task to be completed shoud be lesser than or equal to the project time allotted
            return TaskHoursCalculation() <= HoursAllotted;
        }
        #endregion

        #endregion
    }
}
