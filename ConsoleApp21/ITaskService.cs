namespace ConsoleApp21;

internal interface ITaskService
{
    void AddTask(MyTask task);
    MyTask FindTaskByTitle(string title);
    List<MyTask> FindTasksByStatus(string s);
    void RemoveTask(int id);
    List<MyTask> FindTasksByPriority(string s);
    void ChangePriority(int id, string s);
}