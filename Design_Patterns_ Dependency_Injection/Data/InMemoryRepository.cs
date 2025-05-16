namespace testAppConsol
{
    internal partial class Program
    {
        public class InMemoryRepository<T> : IRepository<T> where T : BaseEntity
        {

            private readonly List<T> _items = new();

            private static InMemoryRepository<T>? _instance;
            public static InMemoryRepository<T> Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new InMemoryRepository<T>();
                    }
                    return _instance;

                }
            }
            private InMemoryRepository()
            {

            }


            public InMemoryRepository(List<T> list)
            {

                _items = list;
            }

            public IEnumerable<T> GetAll()
            {
                return _items;
            }

            public void Add(T entity)
            {
                _items.Add(entity);
            }
            public T GetById(int id)
            {

                foreach (var item in _items)
                {
                    if (item.Id == id)
                        return item;


                }
                return default!;
            }

            public void Delete(int id)
            {
                foreach (var item in _items)
                {
                    if (item.Id == id)
                        _items.Remove(item);

                }
            }


            public void Update(T entity)
            {
                for (int i = 0; i < _items.Count; i++)
                {
                    if (_items[i].Id == entity.Id)
                    {
                        _items[i].UpdatedAt = DateTime.Now;
                        _items[i] = entity;
                        break;
                    }



                }
            }
        }
    }

}