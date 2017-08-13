using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProgrom
{
    public class Adapter:RedisHelper,IHelper
    {
        public void Add<T>()
        {
            base.AddRedis<T>();
        }
        public void Delete<T>()
        {
            base.DeleteRedis<T>();
        }
        public void Update<T>()
        {
            base.UpdateRedis<T>();
        }
        public void Query<T>()
        {
            base.QueryRedis<T>();
        }
    }
}
