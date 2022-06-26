using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp
{
    public class User
    {
        string name;
        int id;
        int age;
        string gender;
        string userName;
        string password;
        Preferences prefs;

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public User(string name, int id, int age, string gender, string userName, string password)
        {
            Name = name;
            Id = id;
            Age = age;
            Gender = gender;
            UserName = userName;
            Password = password;
        }

        
        public override string ToString()
        {
            return $"{Name}, {Age}, {Gender}";
        }

        public override bool Equals(object? obj)
        {
            return (
                obj is User user 
                && UserName == user.UserName 
                && Password == user.Password
            );
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public Preferences Prefs { get => prefs; set => prefs = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

       
    }
}
