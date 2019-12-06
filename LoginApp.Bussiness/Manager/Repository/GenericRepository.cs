using LoginApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Bussiness.Manager
{
    public class GenericRepository<T> : IRepository<T> where T : Base
    {
        internal LoginContext db;
        internal DbSet<T> dbSet;
        internal DateTime _date;
        public GenericRepository()
        {
            db = new LoginContext();
            dbSet = db.Set<T>();
            _date = DateTime.Now;
        }
        public GenericRepository(LoginContext _db)
        {
            db = _db;
            dbSet = db.Set<T>();
            _date = DateTime.Now;

        }

        public void Add(T model)
        {
            model.ID = Guid.NewGuid();
            model.Stat = 1;
            model.recordStat = 1;
            model.lastUpdateDate = _date;
            model.HashType = "SHA1";
            dbSet.Add(model);
        }

        public void AddRange(List<T> list)
        {
            foreach (var item in list)
            {
                item.ID = Guid.NewGuid();
                item.Stat = 1;
                item.recordStat = 1;
                item.lastUpdateDate = _date;
                item.HashType = "SHA1";
            }
            dbSet.AddRange(list);

        }

        public bool Any()
        {
            return dbSet.Any();
        }

        public bool AnyWithQuery(Expression<Func<T, bool>> lambda)
        {
            return dbSet.Any(lambda);
        }

        public T Find(Guid id)
        {
            return dbSet.Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> lambda)
        {
            return dbSet.Where(x => x.Stat == 1 && x.recordStat == 1).FirstOrDefault(lambda);
        }

        public List<T> GetAll()
        {
            return dbSet.Where(x => x.Stat == 1 && x.recordStat == 1).ToList();
        }

        public List<T> GetListWithQuery(Expression<Func<T, bool>> lambda)
        {
            return dbSet.Where(x => x.Stat == 1 && x.recordStat == 1).Where(lambda).ToList();
        }

        public void Remove(Guid id)
        {
            var item = dbSet.Find(id);
            dbSet.Remove(item);
        }

        public void Update(T model)
        {
            model.lastUpdateDate = _date;
            var _model = dbSet.Find(model.ID);
            db.Entry(_model).CurrentValues.SetValues(model);

        }
    }
}
