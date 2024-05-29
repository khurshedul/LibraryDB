using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        public List<T> Add(T entity, List<T> database)
        {
            database.Add(entity);
            return database;

        }
        public List<T> Delete(int id, List<T> database)
        {
           var emp= database.Find(s=>s.ID==id);
            database.Remove(emp);
            return database;

        }
        public T Get(int id, List<T> database)
        {
            return database.Where(s => s.ID == id).First();
        }
    }
}
