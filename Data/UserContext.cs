using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using CDNDev.Models;

namespace CDNDev.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
