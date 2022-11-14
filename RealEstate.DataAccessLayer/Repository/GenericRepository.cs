using RealEstate.DataAccessLayer.Abstract;
using RealEstate.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context context = new Context();

        DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Delete(T t)
        {
            _object.Remove(t);
            context.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetList()
        {
            return _object.ToList();
        }

        public void Insert(T t)
        {
            _object.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            _object.AddOrUpdate(t);
            context.SaveChanges();
        }
    }
}
