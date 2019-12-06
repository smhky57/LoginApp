using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Data.Models
{
    public class LoginContext : DbContext
    {
        public LoginContext()
        {
            Database.Connection.ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LoginDB;Integrated Security=true";
        }
        public DbSet<User> Users { get; set; }

    }
}
