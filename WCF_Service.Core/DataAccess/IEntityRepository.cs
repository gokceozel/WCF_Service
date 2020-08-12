using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Service.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class
    {
        List<T> GetList();
   
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
