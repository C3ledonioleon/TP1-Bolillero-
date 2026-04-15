using Xunit;
using System.Collections.Generic;

public class JugarGanaTests
{
    private Bolillero _bolillero;

    public JugarGanaTests()
    {
        _bolillero = new Bolillero(10, new Primero());
    }

    [Fact]
    public void Jugar_DeberiaGanar_ConSecuenciaCorrecta()
    {
        var jugada = new List<int> { 0, 1, 2, 3 };

        bool resultado = _bolillero.Jugar(jugada);

        Assert.True(resultado);
    }
}