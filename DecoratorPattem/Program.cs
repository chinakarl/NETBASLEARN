using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattem
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("翟海翔");
            DecoratorPerson decoratorP = new DecoratorPerson(person);
            Console.WriteLine("打扮第一种方式:");
           
            DressShoe ds = new DressShoe(person);
            ds.Show();
            Dresspants dp = new Dresspants(person);
            dp.Show();
            DressHat dh = new DressHat(person);
            dh.Show();
          
            Console.WriteLine("打扮第二种方式:");
            DressHat dh1 = new DressHat(person);
            dh1.Show();
            DressShoe ds2 = new DressShoe(person);
            ds2.Show();
            Dresspants dp3= new Dresspants(person);
            dp3.Show();
            Console.ReadKey();
        }
    }
}
