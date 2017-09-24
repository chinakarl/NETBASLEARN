using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattem
{
    public class Person
    {
        private string _Name = string.Empty;
        public Person() { }
        public Person(string personName) {
            this._Name = personName;
        }
        public virtual void Show()
        {
            Console.WriteLine("{0}打扮:",_Name);
        }
    }
}
