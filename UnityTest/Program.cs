using System;
using Unity;

namespace UnityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<IMyType, MyType>();
            container.RegisterType<IMyFactory, MyFactory>();
            var factory = container.Resolve<IMyFactory>();
            var a = factory.Create();
            Console.WriteLine($"Name: {a.Name}, Numberr: {a.Number}");
            var b = factory.Create("B", 2);
            Console.WriteLine($"Name: {b.Name}, Numberr: {b.Number}");
        }
    }
}
