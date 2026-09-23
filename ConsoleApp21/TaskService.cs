
namespace ConsoleApp21;
using ConsoleApp21.exceptions;
internal class TaskService : ITaskService
{
    static List<MyTask> tasks = new List<MyTask>();
    public void AddTask(MyTask task)
    {
        MyTask? task1 = tasks.Find(x => x.Title == task.Title);
        if (task1 != null)
        {
            throw new ConflictException("bu task artiq yaradilib.");
        }
        tasks.Add(task);
    }
    public MyTask FindTaskForTitle(string title)
    {
        MyTask? task1 = tasks.Find(x => x.Title == title);
        if (task1 == null)
        {
            throw new NotFoundException("task tapilmadi:(");
        }
        return task1;
    }
    public List<MyTask> FindTasksForStatus(string s)
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
    }
}