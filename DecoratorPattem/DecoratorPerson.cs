using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattem
{
    /// <summary>
    /// 装饰器
    /// </summary>
    public class DecoratorPerson:Person
    {
        public Person _Person = null;
        public DecoratorPerson(Person person)
        {
            this._Person = person;
        }
        public override void Show()
        {
            if(_Person!=null)
            base.Show();
        }
    }
}
