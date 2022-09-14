using DataAccess.Context;
using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ConcreteRepository
{
    public class BaseRepository<T> where T : class, IBaseEntity
    {
        private readonly KaloriTakipDBContext _kaloriTakipDBContext; // crud işlemleri için gerekli

        private DbSet<T> _table;
        public BaseRepository(KaloriTakipDBContext kaloriTakipDBContext)
        {
            _kaloriTakipDBContext = kaloriTakipDBContext;
            _table = _kaloriTakipDBContext.Set<T>();
        }

        public int Save()
        {
            return _kaloriTakipDBContext.SaveChanges();
        }

        public bool Update(T entity)
        {
            _kaloriTakipDBContext.Entry<T>(entity).State = EntityState.Modified;
            return Save() > 0;
        }

        public bool Delete(T entity)
        {
            entity.Status = Status.Deleted;

            return Update(entity);

        }

        public bool Add(T entity)
        {
            _table.Add(entity);
            return Save() > 0;

        }

        public bool AddRange(List<T> entites)
        {
            _table.AddRange(entites);
            return Save() > 0;
        }





    }
}
