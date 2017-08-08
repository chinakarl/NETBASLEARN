using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryWu fw = new FactoryWu();
            fw.CreateGroupInstance().GroupShow();
            fw.CreateGeneralInstance().GeneralShow();
            Console.ReadLine();
        }
    }
}
