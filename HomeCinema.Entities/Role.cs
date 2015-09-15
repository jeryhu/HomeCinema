using System;
using System.Collections.Generic;

namespace HomeCinema.Entities
{
    class Role:IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    class User:IEntityBase
    {
        public int Id { get; set; }
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
    }
}