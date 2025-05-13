    public interface IRepository<TEntity, TKey>//з цього файлу чомусь не було видно файл з інтерфейсом тому ...
    {
        void Add(TKey id, TEntity entity);
        TEntity Get(TKey id);
        IEnumerable<TEntity> GetAll();
        void Remove(TKey id);
    }
public class InMemoryRepository<TEntity,TKey>: IRepository<TEntity,TKey>
{
    private Dictionary<TKey,TEntity> _peopleList = new Dictionary<TKey,TEntity>();
    public void Add(TKey id, TEntity entity)
    {
         _peopleList.Add(id, entity);
    }
    public TEntity Get(TKey id)
        {
            return _peopleList[id];
        } 
    public IEnumerable<TEntity> GetAll()
        {
            return _peopleList.Values;
        }
    public void Remove(TKey id)
        {
            if(_peopleList.ContainsKey(id))
            {
            Console.WriteLine($"People wit Id {id} was removed");
            _peopleList.Remove(id);
            }
            else
            {
                Console.WriteLine("There are not exist People with this Id");
            }

        }
}