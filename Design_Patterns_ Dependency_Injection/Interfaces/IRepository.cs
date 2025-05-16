namespace testAppConsol
{
    internal partial class Program
    {
        public interface IRepository<T>
        {
            IEnumerable<T> GetAll();
            T GetById(int id);
            void Add(T entity);
            void Update(T entity);
            void Delete(int id);
        }
    }

}