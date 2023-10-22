using Basket.Domain;
using Microsoft.EntityFrameworkCore;

namespace Basket.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IBaseEntity
    {
        private readonly ApplicationDBContext _dbContext;
        private DbSet<TEntity> _dbSet => _dbContext.Set<TEntity>();
        public IQueryable<TEntity> GetAll => _dbSet;

        public GenericRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity GetById(int id)
        {
            var entity = _dbSet.Find(id);

            if (entity == null)
                throw new NotImplementedException();

            return entity;
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }


        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
