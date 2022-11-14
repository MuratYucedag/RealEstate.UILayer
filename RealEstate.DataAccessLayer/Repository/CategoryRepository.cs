using RealEstate.DataAccessLayer.Abstract;
using RealEstate.DataAccessLayer.Concrete;
using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.DataAccessLayer.Repository
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;
        public void Delete(Category t)
        {
            _object.Remove(t);
            c.SaveChanges();
        }

        public Category GetByID(int id)
        {
            return _object.Find(id);
        }

        public List<Category> GetList()
        {
            return _object.ToList();
        }

        public void Insert(Category t)
        {
            _object.Add(t);
            c.SaveChanges();
        }

        public void Update(Category t)
        {
            c.SaveChanges();
        }
    }
}
