using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using EntityLayer.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfWriterDAL : GenericRepository<Writer>, IWriterDAL
    {
    }
}
