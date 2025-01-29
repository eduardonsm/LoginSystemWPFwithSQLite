using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginSystem.Model;

namespace LoginSystem.ViewModel
{
    internal class ViewModelController
    {
        public void AddUser(int id, string username, string email, string password, string role, DateTime createdAt)
        {
            User user = new()
            {
                Username = "testuser",
                Password = "password123",
                Email = "test@example.com",
                Role = "user",
                CreatedAt = DateTime.Now
            };
            //query add
        }
    }
}
