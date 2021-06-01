using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T: class
    {
            List<T> GetAllBL();
            List<T> GetAllBL(int id);
            void Add(T prop);
            void Update(T prop);
            void Delete(T prop);
    }
}
