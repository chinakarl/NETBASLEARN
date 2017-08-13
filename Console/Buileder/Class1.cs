using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarEngine;
namespace Buileder
{
    public class BuilederClass:AbstarctBuilder
    {
        public override void BuilderPlane()
        {
            Console.WriteLine("Builder Plane");
        }
        public override void BuilderCar()
        {
            Console.WriteLine("Builder Car");
        }
    }
}
