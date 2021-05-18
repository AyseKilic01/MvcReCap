﻿using DataAccess.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class HeadingManager
    {
        GenericRepository<Heading> repository = new GenericRepository<Heading>();

        public List<Heading> GetAllBL()
        {
            return repository.List();
        }
    }
}
