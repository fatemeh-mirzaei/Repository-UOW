namespace Basket.Application.Common
{
    public interface IApplicationUnitOfWork : IDisposable
    {
        void Commit();
    }
}
