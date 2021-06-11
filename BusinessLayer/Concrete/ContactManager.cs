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
    public class ContactManager : IGenericService<Contact>
    {
        GenericRepository<Contact> repository = new GenericRepository<Contact>();
        IContactDAL _dal;
        public ContactManager(IContactDAL dal)
        {
            _dal = dal;
        }

        public void Add(Contact prop)
        {
            _dal.Insert(prop);
        }

        public void Delete(Contact prop)
        {
            _dal.Delete(prop);
        }

        public List<Contact> GetAllBL()
        {
            return repository.List();
        }

        public List<Contact> GetAllBL(int id)
        {
            throw new NotImplementedException();
        }

        public Contact GetByID(int id)
        {
            return _dal.Get(x=>x.ContactID == id);
        }

        public void Update(Contact prop)
        {
            _dal.Update(prop);
        }
    }
}
