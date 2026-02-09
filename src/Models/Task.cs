namespace ConsoleApp.src.Models
{
    class Task
    {
        public string Title {get; set;}
        public bool IsDone {get; set;} = false;
        private static int counter = 0;

        public Task()
        {
            Title = "Task" + counter++;
        }

        public Task(string title)
        {
            Title = title;
        }
    }
}