using System;
using System.Collections.Generic;

namespace HomeCinema.Entities
{
    public class Role : IEntityBase
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class User : IEntityBase
    {
        public User()
        {
            UserRoles = new List<UserRole>();
        }

        public string Username { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public bool IsLocked { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public int Id { get; set; }
    }
}