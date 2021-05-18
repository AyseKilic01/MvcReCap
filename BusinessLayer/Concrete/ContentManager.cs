using DataAccess.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager
    {
        GenericRepository<Content> repository = new GenericRepository<Content>();

        public List<Content> GetAllBL()
        {
            return repository.List();
        }
    }
}
