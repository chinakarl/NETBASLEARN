using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 0; i < 10; i++)
            {
                new Action(() =>
                {
                    Single singleton = Single.CreateInstance();
                    Single1.Instance.GetInfo();
                    singleton.GetInfo();
                }).BeginInvoke(null,null);
            }
            Console.ReadLine();
        }
    }
}
