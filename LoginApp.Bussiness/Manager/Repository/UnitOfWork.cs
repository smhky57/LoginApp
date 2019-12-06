using LoginApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Bussiness.Manager
{
    public class UnitOfWork
    {
        private LoginContext db;
        private GenericRepository<User> userRepo;
        public UnitOfWork()
        {
            db = new LoginContext();
        }
        public GenericRepository<User> UserRepo
        {
            get
            {
                if (userRepo == null)
                    userRepo = new GenericRepository<User>(db);
                return userRepo;
            }
        }
        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
