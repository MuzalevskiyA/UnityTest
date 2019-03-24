namespace UnityTest
{
    public interface IMyFactory
    {
        IMyType Create();
        IMyType Create(string name, int number);
    }
}
