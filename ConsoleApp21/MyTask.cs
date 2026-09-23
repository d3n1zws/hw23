using ConsoleApp21;
using ConsoleApp21.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21;

public class MyTask 
{
    static int id = 0;

    public MyTask(string title, string explanation, DateTime createdAt, DateTime deadLine, TaskStatus taskStatus)
    {
        Id = ++id;
        Title = title;
        Explanation = explanation;
        CreatedAt = createdAt;
        DeadLine = deadLine;
        TaskStatus = taskStatus;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Explanation { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime DeadLine { get; set; }
    public TaskStatus TaskStatus { get; set; }
    public TaskPriority Priority { get; set; }
    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}, Explanation: {Explanation}, Created At: {CreatedAt}, Task Status: {TaskStatus}";
    }
}
