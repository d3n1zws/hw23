namespace ConsoleApp21
{
    internal interface ITaskService
    {
        void AddTask(MyTask task);
        MyTask FindTaskForTitle(string title);
        List<MyTask> FindTasksForStatus(string s);
        void RemoveTask(int id);
    }
}