using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProgrom
{
    public class RedisHelper
    {
        public void AddRedis<T>()
        {
            Console.WriteLine("this method  in {0}", this.GetType().Name);
        }
        public void DeleteRedis<T>()
        {
            Console.WriteLine("this method  in {0}", this.GetType().Name);
        }
        public void UpdateRedis<T>()
        {
            Console.WriteLine("this method  in {0}", this.GetType().Name);
        }
        public void QueryRedis<T>()
        {
            Console.WriteLine("this method  in {0}", this.GetType().Name);
        }
    }
}
