using System;

namespace HomeCinema.Entities
{
    public class UserRole : IEntityBase
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int Id { get; set; }
    }

    public class Error : IEntityBase
    {
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime DateCreated { get; set; }
        public int Id { get; set; }
    }
}