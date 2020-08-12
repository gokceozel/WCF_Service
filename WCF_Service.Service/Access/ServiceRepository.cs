using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Web;
using WCF_Service.Core.DataAccess.EntityFramework;
using WCF_Service.Dto.DtoModels;
using WCF_Service.Extensions;

namespace WCF_Service.Service.Access
{
    public class ServiceRepository<Rep, Entity, DTO> : IServiceRepository<DTO> 
        where DTO : class
        where Entity:class
        where Rep: EfEntityRepositoryBase<Entity>
    {
        private Rep _repository;

        public Rep Repository
        {
            get {
                return _repository ?? Activator.CreateInstance<Rep>();
                }
            set { _repository = value; }
        }

     
        public bool Add(DTO entity)
        {
            return Repository.Add(entity.Changer<Entity>());
            
        }
        
        public bool Delete(DTO entity)
        {
            return Repository.Delete(entity.Changer<Entity>());
        }

        public List<DTO> GetList()
        {
            return Repository.GetList().Select(x=>x.Changer<DTO>()).ToList();
        }
       
        public bool Update(DTO entity)
        {
            return Repository.Update(entity.Changer<Entity>());

        }
    }
}