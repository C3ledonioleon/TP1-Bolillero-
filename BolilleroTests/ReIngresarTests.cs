using Xunit;
using Bolillero.Core.Entidades;

namespace BolilleroTests;

public class ReIngresarTests
{
    private Bolillero.Core.Entidades.Bolillero _bolillero;

    public ReIngresarTests()
    {
        _bolillero = new Bolillero.Core.Entidades.Bolillero(10, new Primero());
    }

    [Fact]
    public void ReIngresar_DeberiaVolverATenerTodasLasBolillas()
    {
        _bolillero.SacarBolilla();
        _bolillero.ReingresarBolillas();

        Assert.Equal(10, _bolillero.BolillasAdentro);
        Assert.Equal(0, _bolillero.BolillasAfuera);
    }
}