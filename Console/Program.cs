using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buileder;
using Director;
namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("***********************");
            {
                var builder = new BuilederClass();
                builder.BuilderPlane();
                builder.BuilderCar();
            }
            {
                var builder = new BuilederClass();
                var dir = new DirecterClass(builder);
                dir.GetResult();
            }
            Console.ReadLine();
        }
    }
}
