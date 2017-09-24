using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattem
{
    /// <summary>
    /// 帽子
    /// </summary>
    public class DressHat : DecoratorPerson
    {
        private Person _Person = null;
        public DressHat(Person person) :base(person)
        {
            this._Person = person;
        }
        public override void Show()
        {
            _Person.Show();
            Console.WriteLine("李宁纪念版帽子");
            //base.Show();
        }
    }
}
