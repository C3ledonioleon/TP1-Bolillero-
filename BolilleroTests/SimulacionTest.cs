using Xunit;
using System.Collections.Generic;
using Bolillero.Core.Entidades;
using System.Threading.Tasks;

public class SimulacionTest
{
    [Fact]
    public void SimularSinHilosTest()
    {
        var bolillero = new Bolillero.Core.Entidades.Bolillero(10, new Primero());
        var jugada = new List<int> { 0, 1, 2 };
        int simulaciones = 1000;
        
        var simulacion = new Simulacion();
        long victorias = simulacion.SimularSinHilos(bolillero, jugada, simulaciones);
        
        // Aquí verificás que las victorias sean lo esperado
        Assert.True(victorias > 0);
    }

    [Fact]
    public void SimularConHilosTest()
    {
        var bolillero = new Bolillero.Core.Entidades.Bolillero(10, new Primero());
        var jugada = new List<int> { 0, 1, 2 };
        int simulaciones = 1000;
        int hilos = 4;
        
        var simulacion = new Simulacion();
        long victorias = simulacion.SimularConHilos(bolillero, jugada, simulaciones, hilos);
        
        // Verificás que las victorias sean consistentes
        Assert.True(victorias > 0);
    }
}