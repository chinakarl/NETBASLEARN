using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group;
using General;
namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract Group.IGroup CreateGroupInstance();
        public abstract IGeneral CreateGeneralInstance();
    }
}
