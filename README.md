# ProjectManagementSystem
Object model of PRMS which maintains, manipulates and predicts the project delivery possibilities in given timeframe

Classes: 
1. Project.cs
  This class holds the responsiblities of creation of project and list of tasks assigned underneath it.
    
    Properties holdings were: Project Id, Project Name, Hours Allotted, List of Task under them
    
    Methods holdings were: 
    1. Calculates the total time hours on list of task.
    2. Prediction of project's delivery is possible or not.
    
 2. Task.cs
    This class holds the reponsiblity of creation of each task under a project
    
    Properties holdings were: Task Id, Task Name, Resource used, Allotted Time, Spent Time, Respective Project's Id.
    
    Method holdings were: 
    Nil.
    
 3. ResourceAvailable.enum
    : Enumerates or contains the list of resource available
    
 4. Status.enum
    : To avoid task status confusion have clearly used enumeration to iterate between them for maintaining the each task statuss
