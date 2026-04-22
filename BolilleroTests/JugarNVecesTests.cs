using Xunit;
using System.Collections.Generic;
using Bolillero.Core.Entidades;

namespace BolilleroTests;

public class JugarNVecesTests
{
    private Bolillero.Core.Entidades.Bolillero _bolillero;

    public JugarNVecesTests()
    {
        _bolillero = new Bolillero.Core.Entidades.Bolillero(10, new Primero());
    }

    [Fact]
    public void JugarNVeces_DeberiaGanarUnaVez()
    {
        var jugada = new List<int> { 0, 1 };

        int ganadas = _bolillero.JugarNVeces(jugada, 1);

        Assert.Equal(1, ganadas);
    }
}