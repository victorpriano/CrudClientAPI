using System.Collections.Generic;
using CrudClient.Models;

namespace CrudClient.Data
{
    public class MockUserRepository : IUserRepository
    {
        public void CreateUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            var users = new List<User>
            {
                new User { Id = 0, Name = "Fulano", Email = "fufu@fu" },
                new User { Id = 1, Name = "Ciclano", Email = "cici@ci" },
                new User { Id = 2, Name = "Beltrano", Email = "belbel@bel" }
            };

            return users;
        }

        public User GetUserById(int id)
        {
            return new User { Id = 0, Name = "Fulano", Email = "fufu@fu" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}