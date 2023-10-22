namespace Basket.Domain
{
    public interface IGenericRepository<TEntity> where TEntity : class, IBaseEntity
    {
        IQueryable<TEntity> GetAll { get; }
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);

    }
}
