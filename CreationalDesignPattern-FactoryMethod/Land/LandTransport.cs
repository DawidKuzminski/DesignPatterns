using CreationalDesignPattern_FactoryMethod.Abstraction;
namespace CreationalDesignPattern_FactoryMethod.Land;
internal class LandTransport : ITransport
{
    public string Transport()
    {
        return "Land Transport";
    }
}
