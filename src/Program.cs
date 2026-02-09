using Task = ConsoleApp.src.Models.Task;

namespace ConsoleApp.src
{
    class Program
    {
        static void Main()
        {
            Task task1 = new();
            Task task2 = new();
            Task task3 = new("Faire du sport");

            Console.WriteLine("Tâche 1 : " + task1.Title);
            Console.WriteLine("Tâche 2 : " + task2.Title);
            Console.WriteLine("Tâche 3 : " + task3.Title);
        }
    }
}