using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Service.Service.Access
{
   [ServiceContract]
   public interface IServiceRepository<DTO> where DTO:class,new()
    {
        [OperationContract]
        List<DTO> GetList(Expression<Func<DTO, bool>> filter = null);
        [OperationContract]
        DTO Get(Expression<Func<DTO, bool>> filter);
        [OperationContract]
        bool Add(DTO entity);
        [OperationContract]
        bool Update(DTO entity);
        [OperationContract]
        bool Delete(DTO entity);
    }
}
