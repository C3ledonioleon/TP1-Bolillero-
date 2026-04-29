using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Bolillero.Core.Interfaces;

namespace Bolillero.Core.Entidades
{
    public class Bolillero : ICloneable
    {
        public List<int> Adentro { get; set; } = new List<int>();
        public List<int> Afuera { get; set; } = new List<int>();
        public IAzar Azar { get; set; }

        public Bolillero(int cantidad, IAzar azar)
        {
            Azar = azar;
            Adentro = new List<int>();
            Afuera = new List<int>();

            for (int i = 0; i < cantidad; i++)
            {
                Adentro.Add(i);
            }
        }

        private Bolillero(List<int> adentro, List<int> afuera, IAzar azar)
        {
            Adentro = new List<int>(adentro);
            Afuera = new List<int>(afuera);
            Azar = azar;
        }

        public object Clone()
        {
            // Creamos un nuevo bolillero copiando las listas
            return new Bolillero(
                new List<int>(Adentro),  // Copia de la lista adentro
                new List<int>(Afuera),   // Copia de la lista afuera
                Azar       // Usamos la misma instancia del azar (controlado)
            );
        }


        public int SacarBolilla()
        {
            int indice = Azar.ObtenerSiguiente(Adentro.Count);
            int bolilla = Adentro[indice];

            Adentro.RemoveAt(indice);
            Afuera.Add(bolilla);

            return bolilla;
        }

        public void ReingresarBolillas()
        {
            Adentro.AddRange(Afuera);
            Afuera.Clear();
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

        public int BolillasAdentro => Adentro.Count;
        public int BolillasAfuera => Afuera.Count;
    }
}