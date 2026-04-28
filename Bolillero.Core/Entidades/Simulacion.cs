using System;
using System.Collections.Generic;
using System.Threading;
using Bolillero.Core.Entidades;

namespace Bolillero.Core.Entidades
{
    public class Simulacion
    {
        public long SimularSinHilos(
            Bolillero bolillero,
            List<int> jugada,
            int cantidadSimulaciones)
        {
            long aciertos = 0;

            for (int i = 0; i < cantidadSimulaciones; i++)
            {
                Bolillero copia = (Bolillero)bolillero.Clone();

                if (copia.Jugar(jugada))
                    aciertos++;
            }

            return aciertos;
        }

        public long SimularConHilos(
            Bolillero bolillero,
            List<int> jugada,
            int cantidadSimulaciones,
            int cantidadHilos)
        {
            long totalAciertos = 0;

            int basePorHilo = cantidadSimulaciones / cantidadHilos;
            int resto = cantidadSimulaciones % cantidadHilos;

            Thread[] hilos = new Thread[cantidadHilos];

            for (int i = 0; i < cantidadHilos; i++)
            {
                int simulaciones = basePorHilo + (i < resto ? 1 : 0);

                hilos[i] = new Thread(() =>
                {
                    long parcial = 0;

                    Bolillero copia = (Bolillero)bolillero.Clone();

                    for (int j = 0; j < simulaciones; j++)
                    {
                        copia.ReingresarBolillas();

                        if (copia.Jugar(jugada))
                            parcial++;
                    }

                    Interlocked.Add(ref totalAciertos, parcial);
                });
            }

            foreach (Thread hilo in hilos)
                hilo.Start();

            foreach (Thread hilo in hilos)
                hilo.Join();

            return totalAciertos;
        }
    }
}