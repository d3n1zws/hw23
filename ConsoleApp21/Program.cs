using ConsoleApp21;
using ConsoleApp21.enums;
using ConsoleApp21.exceptions;

UserService userService = new UserService();
TaskService taskService = new TaskService();

while (true)
{
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1. User əlavə et");
    Console.WriteLine("2. User-i email-ə görə tap");
    Console.WriteLine("3. Task əlavə et");
    Console.WriteLine("4. Task-ı title-a görə tap");
    Console.WriteLine("5. Task-ları status-a görə tap");
    Console.WriteLine("6. Task sil");
    Console.WriteLine("7. Task-ları priority-ə görə tap");
    Console.WriteLine("8. Task priority dəyiş");
    Console.WriteLine("9. Task-ı User-ə təyin et");
    Console.WriteLine("10. User-in task-larını göstər");
    Console.WriteLine("0. Çıxış");

    Console.Write("\nSeçim: ");
    string choice = Console.ReadLine();

    try
    {
        if (choice == "1")
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            User user = new User
            {
                Name = name,
                Email = email
            };

            userService.AddUser(user);
        }

        else if (choice == "2")
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();

            User user = userService.FindUserByEmail(email);

            Console.WriteLine($"Id: {user.Id}");
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Email: {user.Email}");
        }

        else if (choice == "3")
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Explanation: ");
            string explanation = Console.ReadLine();

            Console.Write("Deadline (məsələn: 2026-10-10): ");
            DateTime deadline = DateTime.Parse(Console.ReadLine());

            Console.Write("Status (ToDo, InProgress, Done): ");
            TaskStatus status =
                Enum.Parse<TaskStatus>(Console.ReadLine(), true);

            MyTask task = new MyTask(
                title,
                explanation,
                DateTime.Now,
                deadline,
                status
            );

            Console.Write("Priority (Low, Medium, High): ");
            task.Priority =
                Enum.Parse<TaskPriority>(Console.ReadLine(), true);

            taskService.AddTask(task);
        }

        else if (choice == "4")
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            MyTask task = taskService.FindTaskByTitle(title);

            Console.WriteLine(task);
        }

        else if (choice == "5")
        {
            Console.Write("Status (ToDo, InProgress, Done): ");
            string status = Console.ReadLine();

            List<MyTask> tasks =
                taskService.FindTasksByStatus(status);

            foreach (MyTask task in tasks)
            {
                Console.WriteLine(task);
            }
        }

        else if (choice == "6")
        {
            Console.Write("Task Id: ");
            int id = int.Parse(Console.ReadLine());

            taskService.RemoveTask(id);
        }

        else if (choice == "7")
        {
            Console.Write("Priority (Low, Medium, High): ");
            string priority = Console.ReadLine();

            List<MyTask> tasks =
                taskService.FindTasksByPriority(priority);

            foreach (MyTask task in tasks)
            {
                Console.WriteLine(task);
            }
        }

        else if (choice == "8")
        {
            Console.Write("Task Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Yeni priority (Low, Medium, High): ");
            string priority = Console.ReadLine();

            taskService.ChangePriority(id, priority);
        }

        else if (choice == "9")
        {
            Console.Write("Task Id: ");
            int taskId = int.Parse(Console.ReadLine());

            Console.Write("User Id: ");
            int userId = int.Parse(Console.ReadLine());

            taskService.AssignTaskToUser(taskId, userId);

            Console.WriteLine("Task user-ə təyin edildi!");
        }

        else if (choice == "10")
        {
            Console.Write("User Id: ");
            int userId = int.Parse(Console.ReadLine());

            List<MyTask> tasks =
                taskService.GetTasksByUserId(userId);

            foreach (MyTask task in tasks)
            {
                Console.WriteLine(task);
            }
        }

        else if (choice == "0")
        {
            Console.WriteLine("Program bağlandı.");
            break;
        }

        else
        {
            Console.WriteLine("Yanlış seçim!");
        }
    }
    catch (NotFoundException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (ConflictException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (FormatException)
    {
        Console.WriteLine("Daxil etdiyiniz məlumatın formatı yanlışdır.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}