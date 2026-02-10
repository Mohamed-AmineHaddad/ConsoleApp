using Task = ConsoleApp.src.Models.Task;

namespace ConsoleApp.src.Services
{
    class ToDoList
    {
        public List<Task> Tasks = [];

        public void AddTask(string title)
        {
            Tasks.Add(new Task(title));
        }

        public bool RemoveTask(int id)
        {
            if (Tasks.Count <= id) return false;

            Tasks.RemoveAt(id);
            return true;
        }

        public bool MarkTask(int id)
        {
            if (Tasks.Count <= id) return false;

            Tasks[id].IsTaskDone = !Tasks[id].IsTaskDone;
            return true;
        }

        public void DisplayTasks()
        {
            char checkbox;

            foreach (Task task in Tasks)
            {
                checkbox = task.IsTaskDone ? ' ' : 'X';
                Console.WriteLine($"[{checkbox}]" + task.TaskTitle);
            }
        }

        public void RunToDoList()
        {
            ToDoList toDoList = new();

            Console.WriteLine("[#] ToDoList : \n1 - Ajouter une tâche\n2 - Supprimer une tâche\n3 - Cocher une tâche");
            int userActionChoice = Convert.ToInt16(Console.ReadLine());

            switch (userActionChoice)
            {
                case 1:
                    Console.WriteLine("Veuillez entrer un titre à votre tâche.");
                    AddTask(Console.ReadLine()); 
                    break;
                case 2:
                    Console.WriteLine("Veuillez entrer le numéro de la tâche à supprimer.");
                    RemoveTask(Convert.ToInt16(Console.ReadLine())); 
                    break;
                case 3:
                    Console.WriteLine("Veuillez entrer le numéro de la tâche à cocher/décocher.");
                    MarkTask(Convert.ToInt16(Console.ReadLine())); 
                    break;
                default: 
                    Console.WriteLine("Cette action n'est pas possible. Veuillez réessayer"); 
                    break;
            }

        }
    }
}