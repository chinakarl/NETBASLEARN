using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattem
{
    /// <summary>
    /// 鞋子
    /// </summary>
    public class DressShoe:DecoratorPerson
    {
        private Person _Person = null;
        public DressShoe(Person person) :base(person)
        {
            _Person = person;
        }
        public override void Show()
        {
            _Person.Show();
            Console.WriteLine("鳄鱼皮鞋");

            //base.Show();
        }
    }
}
