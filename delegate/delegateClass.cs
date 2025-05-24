class Worker {
    public void DoTask(string task) {
        Console.WriteLine("Working on: " + task);
    }
}

class Manager {
    public delegate void TaskDelegate(string task);

    public void AssignWork(TaskDelegate taskHandler, string? task) {
        Console.WriteLine("Manager delegating task...");
        taskHandler(task); // Delegating the task dynamically
    }
}

