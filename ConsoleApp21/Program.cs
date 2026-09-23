
TaskAssignment adlı class yaradılacaq
Id
TaskId
UserId
AssignedDate
IUserService adlı interfeys yaradılacaq
2.1 İstifadəçi əlavə etmək üçün metod
2.2 Email-ə görə istifadəçini tapan metod
UserService class-ı yaradılacaq
İstifadəçilər üçün statik Massiv saxlayır özündə
2.1 -deki tapsirigda İstifadəçi əlavə etmək üçün metod-da eyni email-li istifadəçi artırılsa ConflictException qaytaracaq
2.2 -deki Email-ə görə istifadəçini tapan metod-da eger hec bir istifadəçi tapilmasa NotFoundException qaytarsın
ITaskService interfeysində aşağıdakı metodlar əlavə ediləcək:
3.7 Task - ı istifadəçiyə təyin etmək üçün metod
3.8 İstifadəçiyə təyin edilmiş task-ları tapan metod
TaskService class-ında aşağıdakı metodlar əlavə ediləcək:
3.7 - deki tapsirigda Task-ı istifadəçiyə təyin etmək üçün metodda eğer göndərilən TaskId və UserId-də element tapılmasa NotFoundException qaytarsın
3.8 -deki İstifadəçiyə təyin edilmiş task-ları tapan metod-da eger hec bir task tapilmasa NotFoundException qaytarsın