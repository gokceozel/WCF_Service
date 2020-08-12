using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Service.Service.Access
{
 
   public interface IServiceRepository<DTO> where DTO:class
    {
  
        List<DTO> GetList(Expression<Func<DTO, bool>> filter = null);

       
        DTO Get(Expression<Func<DTO, bool>> filter);
        
        bool Add(DTO entity);

        bool Update(DTO entity);

       
        bool Delete(DTO entity);

    }
}
