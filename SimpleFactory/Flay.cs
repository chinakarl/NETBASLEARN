using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public interface IFly
    {
        void Fly();
    }
    public class FlyTo
    {
        public IFly Fly(BirdType b)
        {
            IFly fly = null;
            switch (b)
            {
                case BirdType.Glede:
                    fly = new GledeFly();
                    break;
                case BirdType.Bird:
                    fly = new BirdFly();
                    break;
                default:
                    throw new Exception("12323");
            }
            return fly;
        }
    }
    public enum BirdType
    {
        Glede=1,
        Bird=2
    }
    public class GledeFly:IFly
    {
        public void Fly()
        {
            Console.WriteLine("老鹰在天空飞翔");
        }
        
    }
    public class BirdFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("小鸟在天空飞翔");
        }
    }
}
