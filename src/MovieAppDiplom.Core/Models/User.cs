using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace MovieAppDiplom.Core.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User(FirebaseObject<User> firebase)
        {
            Id = firebase.Object.Id;
            Name = firebase.Object.Name;
            Password = firebase.Object.Password;
        }

        public User() { }
    }
}
