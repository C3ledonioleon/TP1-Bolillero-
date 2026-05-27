using Bolillero.Core.Entidades;

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

    [Fact]
    public async Task SimularConHilosAsyncTest()
    {
        var bolillero = new Bolillero.Core.Entidades.Bolillero(10, new Primero());
        var simulacion = new Simulacion();

        long resultado = await simulacion.SimularConHilosAsync(bolillero,new List<int> { 0, 1 },1,1);
        Assert.Equal(1, resultado);
    }
   [Fact]
        public async Task SimularParallelAsync_DeberiaRetornarUnAcierto()
        {
            var bolillero = new Bolillero.Core.Entidades.Bolillero(10, new Primero());
            var simulacion = new Simulacion();
            var jugada = new List<int> { 0, 1 };

            long resultado =
                await simulacion.SimularParallelAsync(bolillero,jugada,1);
                
            Assert.Equal(1, resultado);
        }
}

