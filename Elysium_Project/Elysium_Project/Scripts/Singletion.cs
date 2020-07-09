using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elysium_Project.Scripts
{
    public class Singletion<T> where T: new()
    {
        private static T _T;
        public static T instance()
        {
            if(_T == null)
            {
                _T = new T();
            }
            return _T;
        }
        public virtual void init() { }
    }
}
