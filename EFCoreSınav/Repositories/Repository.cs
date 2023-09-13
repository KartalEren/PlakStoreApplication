using EFCoreSınav.Data;
using EFCoreSınav.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSınav.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private static PlakDBContext _db;

        public Repository()
        {
            if (_db == null)
            {
                _db = new PlakDBContext();
            }
        }

        public void Ekle(T item)
        {
            _db.Set<T>().Add(item);
            _db.SaveChanges();
        }

        public ICollection<T> FilterList(Expression<Func<T, bool>> filter = null)
        {
            return filter != null ? _db.Set<T>().Where(filter).ToList() : _db.Set<T>().ToList();
        }

        public int FindId(Expression<Func<T, bool>> filter)
        {
            return _db.Set<T>().FirstOrDefault(filter).ID;  
        }

        public void Guncelle(T item)
        {
            _db.Entry(item).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public T Sec(Expression<Func<T, bool>> filter)
        {
            return _db.Set<T>().FirstOrDefault(filter);
        }

        public void Sil(T item)
        {
            _db.Set<T>().Remove(item);
            _db.SaveChanges();
        }
    }
}
