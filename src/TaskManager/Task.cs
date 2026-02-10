namespace ConsoleApp.src.TaskManager
{
    class Task(string title)
    {
        public string Title {get; set;} = title;
        public bool IsDone {get; set;} = false;
    }
}