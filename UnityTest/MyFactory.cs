namespace UnityTest
{
    public class MyFactory : IMyFactory
    {
        private readonly IMyType _myobject;
        public MyFactory(IMyType myobject)
        {
            _myobject = myobject;
        }
        public IMyType Create()
        {
            return _myobject; 
        }
        public IMyType Create(string name, int number)
        {
            _myobject.Name = name;
            _myobject.Number = number;
            return Create();
        }
    }
}
