using DataAccess.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager
    {
        GenericRepository<Contact> repository = new GenericRepository<Contact>();

        public List<Contact> GetAllBL()
        {
            return repository.List();
        }
    }
}
