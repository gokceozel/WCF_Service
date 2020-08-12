using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Web;
using WCF_Service.Core.DataAccess.EntityFramework;
using WCF_Service.Dto.DtoModels;

namespace WCF_Service.Service.Access
{
    public class ServiceRepository<Rep, Entity, DTO> : IServiceRepository<DTO> 
        where DTO : class, new()
        where Entity:class,new()
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
           
            throw new NotImplementedException();
        }
        
        public bool Delete(DTO entity)
        {
            throw new NotImplementedException();
        }
        
        public DTO Get(Expression<Func<DTO, bool>> filter)
        {
            throw new NotImplementedException();
        }
   
        public List<DTO> GetList(Expression<Func<DTO, bool>> filter = null)
        {
            ProductDTO d = new ProductDTO();
            throw new NotImplementedException();
        }
       
        public bool Update(DTO entity)
        {
            throw new NotImplementedException();
        }
    }
}