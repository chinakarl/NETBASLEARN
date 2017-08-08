using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group;
using General;
namespace AbstractFactory
{
    class FactoryWu: AbstractFactory
    {
        public override Group.IGroup CreateGroupInstance() {
            return new GroupWu();
        }
        public override IGeneral CreateGeneralInstance()
        {
            return new GeneralWu();
        }
    }
}
