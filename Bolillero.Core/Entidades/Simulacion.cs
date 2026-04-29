using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Bolillero.Core.Entidades;

namespace Bolillero.Core.Entidades{

public class Simulacion
{
    public long SimularSinHilos(Bolillero bolillero, List<int> jugada, int cantidad)
    {
        return bolillero.JugarNVeces(jugada, cantidad);
    }

    public long SimularConHilos(Bolillero bolillero, List<int> jugada, int simulaciones, int hilos)
    {
        long total = 0;
        List<Task<long>> tareas = new List<Task<long>>();

        int porHilo = simulaciones / hilos;

        for (int i = 0; i < hilos; i++)
        {
            var copia = (Bolillero)bolillero.Clone();
            //"Convertimos el resultado a long para asegurar consistencia en el tipo y evitar conflictos al sumar las tareas."
            tareas.Add(Task.Run(() =>
            {
                return (long)copia.JugarNVeces(jugada, porHilo);
            }));
        }

        Task.WaitAll(tareas.ToArray());

        foreach (var t in tareas)
        {
            total += t.Result;
        }

        return total;
    }
}
}