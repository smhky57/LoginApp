using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Bussiness.Manager
{
    public interface IRepository<T>
    {
        void Add(T model);
        void Update(T model);
        void Remove(Guid id);
        T Find(Guid id);
        T FirstOrDefault(Expression<Func<T, bool>> lambda);
        List<T> GetAll();
        List<T> GetListWithQuery(Expression<Func<T, bool>> lambda);
        bool Any();
        bool AnyWithQuery(Expression<Func<T, bool>> lambda);
        void AddRange(List<T> list);


    }
}
