using EFCoreSınav.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSınav.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Ekle(T item);
        void Sil(T item);
        void Guncelle(T item);
        T Sec(Expression<Func<T, bool>> filter);
        int FindId(Expression<Func<T, bool>> filter);
        ICollection<T> FilterList(Expression<Func<T, bool>> filter = null);
    }
}
