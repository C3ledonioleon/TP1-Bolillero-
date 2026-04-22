using Xunit;
using System.Collections.Generic;
using Bolillero.Core.Entidades;

namespace BolilleroTests;

public class JugarGanaTests
{
    private Bolillero.Core.Entidades.Bolillero _bolillero;

    public JugarGanaTests()
    {
        _bolillero = new Bolillero.Core.Entidades.Bolillero(10, new Primero());
    }

    [Fact]
    public void Jugar_DeberiaGanar_ConSecuenciaCorrecta()
    {
        var jugada = new List<int> { 0, 1, 2, 3 };

        bool resultado = _bolillero.Jugar(jugada);

        Assert.True(resultado);
    }
}