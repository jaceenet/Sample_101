using System.Collections.Generic;

namespace Gluu_101.SimpleDb
{
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;

    public class GluuSimpleDb : DbContext
    {
        public DbSet<Organization> Organizations { get; set; }

        public DbSet<User> Users { get; set; }
        
        public DbSet<Role> Roles { get; set; }
    }

    public class Role
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class Organization
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }        
    }

    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public ICollection<Role> Roles { get; set; }
    }
}