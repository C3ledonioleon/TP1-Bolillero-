using Xunit;
using System.Collections.Generic;
using Bolillero.Core.Entidades;

namespace BolilleroTests;

public class JugarPierdeTests
{
    private Bolillero.Core.Entidades.Bolillero _bolillero;

    public JugarPierdeTests()
    {
        _bolillero = new Bolillero.Core.Entidades.Bolillero(10, new Primero());
    }

    [Fact]
    public void Jugar_DeberiaPerder_ConSecuenciaIncorrecta()
    {
        var jugada = new List<int> { 4, 2, 1 };

        bool resultado = _bolillero.Jugar(jugada);

        Assert.False(resultado);
    }
}