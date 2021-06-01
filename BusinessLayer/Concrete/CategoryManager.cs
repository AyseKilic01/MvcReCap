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
   public class CategoryManager
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
        public void CategoryAdd(Category p)
        {
            _dal.Insert(p);
        }
    }
}
