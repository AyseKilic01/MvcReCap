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
   public class HeadingManager : IGenericService<Heading>
    {
        GenericRepository<Heading> repository = new GenericRepository<Heading>();
        IHeadingDAL _dal;
        public HeadingManager(IHeadingDAL dal)
        {
            _dal = dal;
        }

        public void Add(Heading prop)
        {
            _dal.Insert(prop);
        }

        public void Delete(Heading prop)
        {
            _dal.Delete(prop);
        }

        public List<Heading> GetAllBL()
        {
            return repository.List();
        }

        public List<Heading> GetAllBL(int id)
        {
            throw new NotImplementedException();
        }

        public Heading GetByID(int id)
        {
            return _dal.Get(x => x.HeadingID == id);
        }

        public void Update(Heading prop)
        {
            _dal.Update(prop);
        }
    }
}
