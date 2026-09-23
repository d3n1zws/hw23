using ConsoleApp21.exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21;

public class UserService : IUserService
{
    public static List<User> users = new List<User>();
    public void AddUser(User user)
    {
        User? user1 = users.Find(x => x.Email == user.Email);
        if (user1 != null)
        {
            throw new ConflictException("bu task artiq yaradilib.");
        }
        users.Add(user);
        Console.WriteLine("User yaradildi!");
    }
    public User FindUserByEmail(string email)
    {
        User? user1 = users.Find(x => x.Email == email);
        if (user1 == null)
        {
            throw new NotFoundException("user tapilmadi:(");
        }
        return user1;
    }

}



