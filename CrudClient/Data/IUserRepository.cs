using System.Collections.Generic;
using CrudClient.Models;

namespace CrudClient.Data
{
    public interface IUserRepository
    {
         bool SaveChanges();
         IEnumerable<User> GetAllUsers();
         User GetUserById(int id);
         void CreateUser(User user);
         void UpdateUser(User user);
         void DeleteUser(User user);
    }
}