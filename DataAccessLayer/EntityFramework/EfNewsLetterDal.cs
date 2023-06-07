﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete.Home;

namespace DataAccessLayer.EntityFramework
{
   public class EfNewsletterDal : GenericRepository<Newsletter>, INewsLetterDal
    {
    }
}
