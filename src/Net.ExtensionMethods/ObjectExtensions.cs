using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.ExtensionMethods
{
    public static class ObjectExtensions
    {
        public static TTarget ConvertToType<TTarget>(this object source) where TTarget : class
        {
            var target = source as TTarget;

            return target;
        }


        public static TTarget ConvertToAnyType<TTarget>(this object source) 
        {
            var target = (TTarget)source ;

            return target;
        }
    }
}
