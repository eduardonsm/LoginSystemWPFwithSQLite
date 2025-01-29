using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Model
{
    public class User
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "user";
        public DateTime CreatedAt { get; set; }

        public User(int id, string username, string email, string password, string role, DateTime createdAt)
        {
            Id = id;
            Username = username;
            Email = email;
            Password = password;
            this.Role = role;
            CreatedAt = createdAt;
        }

    }
}
