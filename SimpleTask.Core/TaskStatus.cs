namespace SimpleTask
{
    public class TaskStatus
    {
        public enum TaskState
        {
            Done = 1,
            InPreview = 2,
            InProcess = 3,
            ToDo = 4
        }

        public enum TaskPrioritys
        {
            Top = 1,
            Middle = 2,
            Low = 3
        }

        public enum TaskType
        {
            Bug = 1,
            Iprovement = 2,
            Feature = 3,
            Task = 4
        }
    }
}
