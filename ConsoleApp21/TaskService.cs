
namespace ConsoleApp21;
using ConsoleApp21.exceptions;
internal class TaskService
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
    public void FindTask(string title)
    {
        MyTask? task1 = tasks.Find(x => x.Title == title);
        if (task1 == null)
        {
            throw new NotFoundException
        }
    }
}

//ITaskService interfeysi yaradırıq
//3.1. Siyahıya Task əlavə etmək üçün metod. (eyni başlıqlı Task artırılsa ConflictException qaytaracaq)
//3.2 Title-a görə Siyahıdan task-i tapan metod
//3.3 Göndərilən Status-da olan task-ları tapan metod
//3.4 Göndərilən Id-də olan elementi siyahıdan silmək üçün metod
//TaskService class-ı yaradırıq
//Task-lar üçün statik Massiv saxlayır özündə
//3.1-deki tapsirigda Siyahıya Task əlavə etmək üçün metodda eyni başlıqlı Task artırılsa ConflictException qaytaracaq
//3.2 -deki Title-a görə Siyahıdan task-i tapan metod-da eger hec bir task tapilmasa NotFoundException qaytarsın
//3.3 string-i enum-a cevirmeyi goster
//3.4 - də göndərilən Id-də element tapılmasa NotFoundException