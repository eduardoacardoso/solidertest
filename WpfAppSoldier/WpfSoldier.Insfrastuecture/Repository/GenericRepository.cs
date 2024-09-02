using Microsoft.EntityFrameworkCore;
using WpfSoldier.Application.Interface;
using WpfSoldier.Infrastructure.DataContext;


namespace WpfSoldier.Infrastructure.Repository
{
    public class GenericRepository<T> : IDisposable, IGenericRepository<T> where T : class
    {
        private SoldierDataContext db = null;
        private DbSet<T> table = null;

        public IQueryable<T> GetAll()
        {

            IQueryable<T> query = table;
            return query;
        }

        public IQueryable<T> GetAll(int pageNumber, int pageSize)
        {
            IQueryable<T> query = table;
            return query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }


        public GenericRepository(SoldierDataContext db)
        {
            this.db = db;
            table = db.Set<T>();
        }

        public IEnumerable<T> SelectAll(int pageNumber, int pageSize)
        {
            return table.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }


        public IEnumerable<T> SelectAll()
        {
            return table.ToList();
        }

        public async Task<IEnumerable<T>> SelectAllAsync()
        {
            return await table.ToListAsync();
        }

        public T SelectByID(object id)
        {
            return table.Find(id);
        }

        public async Task<T> SelectByIDAsync(object id)
        {
            return await table.FindAsync(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }


        public void Update(T obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await db.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}