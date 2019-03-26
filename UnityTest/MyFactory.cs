using Unity;

namespace UnityTest
{
    public class MyFactory : IMyFactory
    {
        private readonly IUnityContainer _container;
        public MyFactory(IUnityContainer container)
        {
            _container = container;
        }
        public IMyType Create()
        {
            return _container.Resolve<IMyType>(); 
        }
        public IMyType Create(string name, int number)
        {
            var obj = _container.Resolve<IMyType>();
            obj.Name = name;
            obj.Number = number;
            return obj;
        }
    }
}
