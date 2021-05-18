using DataAccess.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager
    {
        GenericRepository<About> repository = new GenericRepository<About>();

        public List<About> GetAllBL()
        {
            return repository.List();
        }
    }
}
