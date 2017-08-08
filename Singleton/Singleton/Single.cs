using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Singleton
{
    public class Single
    {
       
        public static string _lock = string.Empty;
        private Single()
        {
            Thread.Sleep(10);
            Console.WriteLine("当前线程ID为{0}", Thread.CurrentThread.ManagedThreadId);
        }
        private static Single _Single = null;
        public static Single CreateInstance()
        {
            if(_Single == null)
            {
                lock (_lock)
                {
                    if (_Single == null)
                    {
                        _Single = new Single();
                    }
                }
            }
            return _Single;
        }
        public void GetInfo()
        {
            Console.WriteLine("这是{0}的单例",this.GetType().Name);
        }
    }
    public class Single1
    {
        public  static readonly Single1 Instance = null;
        static Single1()
        {
            Thread.Sleep(10);
            Instance = new Single1();
            Console.WriteLine("当前线程ID为{0}", Thread.CurrentThread.ManagedThreadId);
        }
        
        public void GetInfo()
        {
            Console.WriteLine("这是{0}的单例", this.GetType().Name);
        }
    }
}
