using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Service.Extensions
{
    public static class Extension
    {
        public static T Changer<T> (this object source)
        {
            T hedef = Activator.CreateInstance<T>();
            Type kaynak = source.GetType();

            PropertyInfo[] kaynakProps = kaynak.GetProperties();
            foreach (var pi in kaynakProps)
            {
                object value = pi.GetValue(source);
                pi.SetValue(hedef, value);

            }
            return hedef;
        }
    }
}
