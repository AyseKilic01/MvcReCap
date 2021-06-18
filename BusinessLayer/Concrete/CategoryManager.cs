using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
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
   public class CategoryManager : IGenericService<Category>
    {
        //GenericRepository<Category> repository = new GenericRepository<Category>();
        //böl parçala yönet
        ICategoryDAL _dal;

        public CategoryManager(ICategoryDAL dal)
        {
            _dal = dal;
        }

        public List<Category> GetAllBL(Category p)
        {
            return _dal.List();
        }
        public List<Category> GetAllBL()
        {
            return _dal.List();
        }
        public void Add(Category p)
        {
            
            _dal.Insert(p);
        }

        public List<Category> GetAllBL(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category prop)
        {
            _dal.Update(prop);
        }

        public void Delete(Category prop)
        {
            _dal.Delete(prop);
        }

        public Category GetByID(int id)
        {
            return _dal.Get(x => x.CategoryID == id);
        }
    }
}
