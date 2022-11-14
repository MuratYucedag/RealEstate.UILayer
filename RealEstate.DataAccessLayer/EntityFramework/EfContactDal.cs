using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.DataAccessLayer.Abstract;
using RealEstate.DataAccessLayer.Repository;
using RealEstate.EntityLayer.Concrete;

namespace RealEstate.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
    }
}
