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
    public class ContentManager : IGenericService<Content>
    {
        GenericRepository<Content> repository = new GenericRepository<Content>();
        IContentDAL _dal;
        public ContentManager(IContentDAL dal)
        {
            _dal = dal;
        }

        public void Add(Content prop)
        {
            _dal.Insert(prop);
        }

        public void Delete(Content prop)
        {
            _dal.Delete(prop);
        }

        public List<Content> GetAllBL()
        {
            return repository.List();
        }

        public List<Content> GetAllBL(int id)
        {
            throw new NotImplementedException();
        }

        public Content GetByID(int id)
        {
            return _dal.Get(x => x.ContentID == id);
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void Update(Content prop)
        {
            _dal.Update(prop);
        }
    }
}
