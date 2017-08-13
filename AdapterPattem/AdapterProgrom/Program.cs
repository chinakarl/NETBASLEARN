using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProgrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************");
            { 
                SqlHelper sql = new SqlHelper();
                sql.Add<string>();
                MySqlHelper sql1 = new MySqlHelper();
                sql1.Add<string>();
                Adapter ad = new Adapter();
                ad.Add<string>();
            }
            Console.ReadLine();
        }
    }
}
