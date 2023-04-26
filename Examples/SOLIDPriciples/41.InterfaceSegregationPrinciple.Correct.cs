namespace SOLIDPriciples.InterfaceSegregationPrinciple.Correct
{
    public interface IProgrammer
    {
        void WorkOnTask();
    }

    public interface IManage
    {
        void CreateSubTask();
        void AssignTask();
    }

    public class Programmer : IProgrammer
    {
        public void WorkOnTask()
        {
            //code to implement to work on the Task.
        }
    }

    public class TeamLead : IManage, IProgrammer
    {
        public void AssignTask()
        {
            //Code to assign a task.
        }
        public void CreateSubTask()
        {
            //Code to create a sub task
        }
        public void WorkOnTask()
        {
            //Code to implement perform assigned task.
        }
    }

    public class Manager : IManage
    {
        public void AssignTask()
        {
            //Code to assign a task.
        }
        public void CreateSubTask()
        {
            //Code to create a sub task.
        }
    }
}
