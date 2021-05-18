using DataAccess.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class WriterManager
    {
        GenericRepository<Writer> repository = new GenericRepository<Writer>();

        public List<Writer> GetAllBL()
        {
            return repository.List();
        }
    }
}
