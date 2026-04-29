using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Bolillero.Core.Interfaces;

namespace Bolillero.Core.Entidades
{
public class AzarRandom : IAzar
{
    private Random _random = new Random();

    // Devuelve un número aleatorio entre 0 y el máximo indicado
    public int ObtenerSiguiente(int max)
    {
        return _random.Next(0, max);
    }
}
}