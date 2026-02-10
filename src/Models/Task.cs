namespace ConsoleApp.src.Models
{
    class Task(string title)
    {
        public string TaskTitle {get; set;} = title;
        public bool IsTaskDone {get; set;} = false;
    }
}