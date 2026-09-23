
namespace ConsoleApp21;

using ConsoleApp21.enums;
using ConsoleApp21.exceptions;
internal class TaskService : ITaskService
{
    static List<MyTask> tasks = new List<MyTask>();
    public void AddTask(MyTask task)
    {
        MyTask? task1 = tasks.Find(x => x.Title == task.Title);
        if (task1 != null)
        {
            throw new ConflictException("Bu task artiq yaradilib.");
        }
        tasks.Add(task);
        Console.WriteLine("Task yaradildi!");
    }
    public MyTask FindTaskByTitle(string title)
    {
        MyTask? task1 = tasks.Find(x => x.Title == title);
        if (task1 == null)
        {
            throw new NotFoundException("Task tapilmadi:(");
        }
        return task1;
    }
    public List<MyTask> FindTasksByStatus(string s)
    {
        TaskStatus status = Enum.Parse<TaskStatus>(s);
        return tasks.FindAll(x => x.TaskStatus == status);
    }
    public void RemoveTask(int id)
    {
        MyTask? task = tasks.Find(x => x.Id == id);
        if (task == null)
        {
            throw new NotFoundException("task tapilmadi:(");
        }
        tasks.Remove(task);
        Console.WriteLine("Task silindi!");
    }
    public List<MyTask> FindTasksByPriority(string s)
    {
        TaskPriority priority = Enum.Parse<TaskPriority>(s);
        List<MyTask> Tasks = tasks.FindAll(x => x.Priority == priority);
        if (Tasks.Count == 0 || Tasks == null)
        {
            throw new NotFoundException("hec bir task tapilmadi:(");
        }
        return tasks;
    }
    public void ChangePriority(int id, string s)
    {
        MyTask? task = tasks.Find(x => x.Id == id);
        if (task == null)
        {
            throw new NotFoundException("task tapilmadi:(");
        }
        TaskPriority priority = Enum.Parse<TaskPriority>(s);
        task.Priority = priority;
        Console.WriteLine("Deyisiklik ugurlu oldu");
    }
    public void AssignTaskToUser(int taskId, int userId)
    {
        MyTask? task = tasks.Find(x => x.Id == taskId);
        if (task == null)
        {
            throw new NotFoundException("task tapilmadi:(");
        }
        User? user1 = UserService.users.Find(x => x.Id == userId);
        if (user1 == null)
        {
            throw new ConflictException("user tapilmadi:(");
        }
        user1.tasks.Add(task);
    }
    public List<MyTask> GetTasksByUserId(int userId)
    {
        User? user1 = UserService.users.Find(x => x.Id == userId);
        if (user1 != null)
        {
            throw new ConflictException("user tapilmadi:(");
        }
        return user1.tasks;
    }
}