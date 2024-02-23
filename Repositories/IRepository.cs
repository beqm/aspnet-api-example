namespace Repositories
{
    public interface IRepository<T>
    {
        T? Get(Guid id);
        T Insert(T item);
        T? Update(Guid id, T item);
        void Delete(Guid id);
        IEnumerable<T> GetAll();
    }
}