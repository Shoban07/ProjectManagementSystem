using System;
namespace ProjectManagementSystem
{
    /*
     1. To Avoid status name conflicts
     2. To have clear overview on what was the current status*/
    public enum Status
    {
        Active,
        InProgress,
        InHold,
        Completed
    }
}
