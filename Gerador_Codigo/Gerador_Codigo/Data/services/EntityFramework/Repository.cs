using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_Codigo.Data.Services 
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected readonly DbContext Db;
        internal DbSet<TEntity> DbSet;

        public Repository(DbContext db)
        {
            Db = db;
            this.DbSet = Db.Set<TEntity>();
        }

        public async Task<TEntity> FindAsync(int id) => await DbSet.FindAsync(id);

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter = null, string includeProperties = null, bool isTracking = false)
        {
            IQueryable<TEntity> query = DbSet;
            if (filter != null) query = query.Where(filter);


            if (includeProperties != null)
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries))
                    query = query.Include(includeProperty);

            if (!isTracking) query = query.AsNoTracking();

            return await query.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
           string includeProperties = null, bool isTracking = false)
        {
            IQueryable<TEntity> query = DbSet;
            if (filter != null) query = query.Where(filter);

            if (includeProperties != null)
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries))
                    query = query.Include(includeProperty);

            if (orderBy != null)
                return orderBy(query);

            if (!isTracking) query = query.AsNoTracking();
            return await query.ToListAsync();
        }

        public virtual async Task RemoveAsync(TEntity entity)
        {
            Db.Remove(entity);
            await SaveChangesAsync();
        }

        public async Task AddAsync(TEntity entity)
        {
            await DbSet.AddAsync(entity);
            await SaveChangesAsync();
        }
        public async Task UpdateAsync(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChangesAsync();
        }

        public async Task SaveAsync() => await Db.SaveChangesAsync();

        public async Task<int> SaveChangesAsync() => await Db.SaveChangesAsync();

        public void Dispose() => Db?.Dispose();
    }
}

