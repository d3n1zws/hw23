namespace ConsoleApp21;

internal interface ITaskService
{
    void AddTask(MyTask task);
    MyTask FindTaskForTitle(string title);
    List<MyTask> FindTasksForStatus(string s);
    void RemoveTask(int id);
    List<MyTask> FindTasksForPriority(string s);
    void ChangePriority(int id, string s);
}