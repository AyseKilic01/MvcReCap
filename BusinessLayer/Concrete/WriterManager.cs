using BusinessLayer.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class WriterManager : IGenericService<Writer>
    {
        GenericRepository<Writer> repository = new GenericRepository<Writer>();
        IWriterDAL _dal;
        public WriterManager(IWriterDAL dal)
        {
            _dal = dal;
        }

        public void Add(Writer prop)
        {
            _dal.Insert(prop);
        }

        public void Delete(Writer prop)
        {
            _dal.Delete(prop);
        }

        public List<Writer> GetAllBL()
        {
            return repository.List();
        }

        public List<Writer> GetAllBL(int id)
        {
            throw new NotImplementedException();
        }

        public Writer GetByID(int id)
        {
            return _dal.Get(x => x.WriterID == id);
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void Update(Writer prop)
        {
            _dal.Update(prop);
        }
    }
}
