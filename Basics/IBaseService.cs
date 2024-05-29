namespace Basics
{
    public interface IBaseService<T>
    {
        List<T> Add(T entity, List<T> entities);
        List<T> Delete(int id, List<T> entities);
        T Get(int id, List<T> entities);
    }
}