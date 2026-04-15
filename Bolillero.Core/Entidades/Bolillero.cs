using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bolillero.Core.Interfaces;

namespace Bolillero.Core.Entidades
{
public class Bolillero
{
    private List<int> _bolillasAdentro;
    private List<int> _bolillasAfuera;
    private IAzar _azar;

    public Bolillero(int cantidad, IAzar azar)
    {
        _azar = azar;
        _bolillasAdentro = new List<int>();
        _bolillasAfuera = new List<int>();

        for (int i = 0; i < cantidad; i++)
        {
            _bolillasAdentro.Add(i);
        }
    }

    public int SacarBolilla()
    {
        int indice = _azar.ObtenerSiguiente(_bolillasAdentro.Count);
        int bolilla = _bolillasAdentro[indice];

        _bolillasAdentro.RemoveAt(indice);
        _bolillasAfuera.Add(bolilla);

        return bolilla;
    }

    public void ReingresarBolillas()
    {
        _bolillasAdentro.AddRange(_bolillasAfuera);
        _bolillasAfuera.Clear();
    }

    public bool Jugar(List<int> jugada)
    {
        foreach (var numero in jugada)
        {
            int bolilla = SacarBolilla();
            if (bolilla != numero)
            {
                return false;
            }
        }
        return true;
    }

    public int JugarNVeces(List<int> jugada, int veces)
    {
        int ganadas = 0;

        for (int i = 0; i < veces; i++)
        {
            if (Jugar(jugada))
                ganadas++;

            ReingresarBolillas();
        }

        return ganadas;
    }

    // Métodos para test
    public int BolillasAdentro => _bolillasAdentro.Count;
    public int BolillasAfuera => _bolillasAfuera.Count;
}
}