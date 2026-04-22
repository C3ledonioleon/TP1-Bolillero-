using Xunit;
using Bolillero.Core.Entidades;

namespace BolilleroTests;

public class SacarBolillaTests
{
    private Bolillero.Core.Entidades.Bolillero _bolillero;

    public SacarBolillaTests()
    {
        _bolillero = new Bolillero.Core.Entidades.Bolillero(10, new Primero());
    }

    [Fact]
    public void SacarBolilla_DeberiaSerCero_YActualizarEstados()
    {
        int bolilla = _bolillero.SacarBolilla();

        Assert.Equal(0, bolilla);
        Assert.Equal(9, _bolillero.BolillasAdentro);
        Assert.Equal(1, _bolillero.BolillasAfuera);
    }
}