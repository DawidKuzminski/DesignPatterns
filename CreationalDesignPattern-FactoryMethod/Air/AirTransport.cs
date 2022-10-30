using CreationalDesignPattern_FactoryMethod.Abstraction;

namespace CreationalDesignPattern_FactoryMethod.Air;

internal class AirTransport : ITransport
{
    public string Transport()
    {
        return "Air Transport";
    }
}
