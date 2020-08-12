﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_Service.Dto.DtoModels;
using WCF_Service.Service.Access;

namespace WCF_Service.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IKategoriService" in both code and config file together.
   
    public interface IKategoriService :IServiceRepository<CategoryDTO>
    {
      
    }
}
