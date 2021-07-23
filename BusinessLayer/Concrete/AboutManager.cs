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
    public class AboutManager : IGenericService<About>
    {
        //GenericRepository<About> repository = new GenericRepository<About>();
        IAboutDAL _dal;

        public AboutManager(IAboutDAL dal)
        {
            _dal = dal;
        }

        public void Add(About prop)
        {
            throw new NotImplementedException();
        }

        public void Delete(About prop)
        {
            throw new NotImplementedException();
        }

        public List<About> GetAllBL()
        {
            return _dal.List();
        }

        public List<About> GetAllBL(int id)
        {
            throw new NotImplementedException();
        }

        public About GetByID(int id)
        {
            return _dal.Get(x => x.AboutID == id);
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void Update(About prop)
        {
            throw new NotImplementedException();
        }
    }
}
