using Basket.Application.Common;

namespace Basket.Infrastructure.Persistence.UnitOfWork
{
    public class ApplicationUnitOfWork : IApplicationUnitOfWork
    {
        public readonly ApplicationDBContext _dbContext;

        public ApplicationUnitOfWork(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;

        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
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
