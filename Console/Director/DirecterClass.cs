using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarEngine;
namespace Director
{
    public class DirecterClass
    {
        private AbstarctBuilder _AbstarctBuilder = null;
        public DirecterClass(AbstarctBuilder builder)
        {
            this._AbstarctBuilder = builder;
        }
        public void GetResult()
        {
            this._AbstarctBuilder.BuilderPlane();
            this._AbstarctBuilder.BuilderCar();
        }
    }
}
