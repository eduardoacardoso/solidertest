using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSoldier.Application.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(int pageNumber, int pageSize);
        Task<IEnumerable<T>> SelectAllAsync();
        IEnumerable<T> SelectAll();
        IEnumerable<T> SelectAll(int pageNumber, int pageSize);
        T SelectByID(object id);
        Task<T> SelectByIDAsync(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
        Task SaveAsync();
        void Dispose();
    }
}
