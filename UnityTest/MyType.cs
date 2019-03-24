namespace UnityTest
{
    public class MyType : IMyType
    {
        public MyType()
        {
            Name = "A";
            Number = 1;
        }
        public string Name { get; set; }
        public int Number { get; set; }
    }
}
