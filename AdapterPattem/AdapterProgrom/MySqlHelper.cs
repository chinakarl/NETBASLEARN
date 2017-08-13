using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProgrom
{
    public class MySqlHelper:IHelper
    {
        public void Add<T>()
        {
            Console.WriteLine("this method  in {0}", this.GetType().Name);
        }
        public void Delete<T>()
        {
            Console.WriteLine("this method  in {0}", this.GetType().Name);
        }
        public void Update<T>()
        {
            Console.WriteLine("this method  in {0}", this.GetType().Name);
        }
        public void Query<T>()
        {
            Console.WriteLine("this method  in {0}", this.GetType().Name);
        }
    }
}
