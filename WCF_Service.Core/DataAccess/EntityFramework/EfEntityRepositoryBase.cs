﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WCF_Service.Nrhwind;

namespace WCF_Service.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<T> : IEntityRepository<T> where T : class
    {
        
        private static NorthwindContext _context;

        public static NorthwindContext Context
        {
            get { return _context ?? new NorthwindContext(); }
            set { _context = value; }
        }

        public bool Add(T entity)
        {
            try
            {
                var result = Context.Entry(entity);
                result.State = EntityState.Added;
                Context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        
        }

        public bool Delete(T entity)
        {
            try
            {
                var result = Context.Entry(entity);
                result.State = EntityState.Deleted;
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
         
        }

        public List<T> GetList()
        {
            return Context.Set<T>().ToList();
        }

        public bool Update(T entity)
        {
            try
            {
                var result = Context.Entry(entity);
                result.State = EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
          
        }
    }
}
