using CreationalDesignPattern_FactoryMethod.Abstraction;

namespace CreationalDesignPattern_FactoryMethod.Maritime;
internal class MaritimeTransport : ITransport
{
    public string Transport()
    {
        return $"Maritime Transport";
    }
}
