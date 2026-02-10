namespace ConsoleApp.src.TaskManager
{
    class ToDoList
    {
        public List<Task> Tasks = [];

        public void AddTask(string title)
        {
            if (string.IsNullOrWhiteSpace(title)) return;
            Tasks.Add(new Task(title));
        }

        public void RemoveTask(int id)
        {
            if (Tasks.Count < id || id == 0) return;
            Tasks.RemoveAt(id - 1);
        }

        public void MarkTask(int id)
        {
            if (Tasks.Count < id || id == 0) return;
            Tasks[id - 1].IsDone = !Tasks[id - 1].IsDone;
        }

        public void DisplayTasks()
        {
            Console.WriteLine(
                "[#] ToDoList :                                        \n\n" +
                "1 - Ajouter une tâche                                 \n"   +
                "2 - Supprimer une tâche                               \n"   +
                "3 - Cocher une tâche                                  \n"   +
                "Appuyez sur n'importe quelle autre touche pour quitter\n"
            );

            char checkbox;

            foreach (Task task in Tasks)
            {
                checkbox = task.IsDone ? '✓' : ' ';
                Console.WriteLine($"[{checkbox}] " + task.Title);
            }
        }

        public bool ReadUserChoice()
        {
            bool reading = true;
            Console.Write("---> ");
            int choice = Convert.ToInt16(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Veuillez entrer un titre à votre tâche : ");
                AddTask(Console.ReadLine() ?? "");
            } else if (choice == 2)
            {
                Console.Write("Veuillez entrer le numéro de la tâche à supprimer : ");
                RemoveTask(Convert.ToInt16(Console.ReadLine()));  
            } else if (choice == 3)
            {
                Console.Write("Veuillez entrer le numéro de la tâche à cocher/décocher : ");
                MarkTask(Convert.ToInt16(Console.ReadLine()));
            } else
            {
                reading = false;
            }

            Console.Clear();
            return reading;
        }

        public void Run()
        {
            bool running = true;
            while(running)
            {
                DisplayTasks();
                running = ReadUserChoice();
            }
        }
    }
}