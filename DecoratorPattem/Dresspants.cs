using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattem
{
    /// <summary>
    /// 裤子
    /// </summary>
    public class Dresspants: DecoratorPerson
    {
        private Person _Person = null;
        public Dresspants(Person person) :base(person)
        {
            this._Person = person;
        }
        public override void Show()
        {
            _Person.Show();
            Console.WriteLine("牛仔短裤");

            //base.Show();
        }
    }
}
