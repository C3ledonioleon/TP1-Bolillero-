using Bolillero.Core.Interfaces;

namespace Bolillero.Core.Entidades
{
public class AzarRandom : IAzar
{
    private Random _random = new Random();

    public int ObtenerSiguiente(int max)
    {
        return _random.Next(0, max);
    }
}
}