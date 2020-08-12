using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_Service.Core.Process;
using WCF_Service.Dto.DtoModels;
using WCF_Service.Nrhwind;
using WCF_Service.Service.Access;

namespace WCF_Service.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    
    public class ProductService : ServiceRepository<ProductManager,Product,ProductDTO>
    {
      




    }
}
