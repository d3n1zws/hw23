using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21;

public static class TaskHelper
{
    public static TimeSpan GetRemainingTime(this MyTask task)
    {
        return task.DeadLine - DateTime.Now;
    }
    public static TimeSpan GetAllocatedTime(this MyTask task)
    {
        return task.DeadLine - task.CreatedAt;
    }
}
