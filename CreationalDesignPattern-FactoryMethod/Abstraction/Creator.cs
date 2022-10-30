namespace CreationalDesignPattern_FactoryMethod.Abstraction
{
    internal abstract class Creator
    {
        public abstract ITransport FactoryMethod();

        public string CreateTransport()
        {
            var transport = FactoryMethod();
            return $"Created transport: {transport.Transport()}";
        }
    }
}
