using Xunit;
using Bolillero.Core.Entidades;


public class BolilleroTest
{
    // Objeto que se va a probar
    private Bolillero.Core.Entidades.Bolillero _bolillero;
    
    // Constructor: se ejecuta antes de cada test
    public BolilleroTest()
    {    
        // Se crea un bolillero con 10 bolillas (0 al 9)
        // y con la clase Primero, que siempre saca la primera bolilla
        _bolillero = new Bolillero.Core.Entidades.Bolillero(10, new Primero());
    }

    [Fact]
    public void SacarBolilla()
    {
        // Se saca una bolilla del bolillero
        int bolilla = _bolillero.SacarBolilla();

        // Verifica resultado y cantidades internas
        Assert.Equal(0, bolilla);
        Assert.Equal(9, _bolillero.BolillasAdentro);
        Assert.Equal(1, _bolillero.BolillasAfuera);
    }

    [Fact]
    public void ReIngresar()
    {
         // Se saca una bolilla y luego se reingresan todas las bolillas
        _bolillero.SacarBolilla();
        _bolillero.ReingresarBolillas();

        // Deben quedar nuevamente 10 bolillas adentro y 0 afuera
        Assert.Equal(10, _bolillero.BolillasAdentro);
        Assert.Equal(0, _bolillero.BolillasAfuera);
    }

    [Fact]
    public void JugarGana()
    {
        // Como la clase Primero siempre saca:
        // 0,1,2,3...
        bool gano = _bolillero.Jugar(new List<int> { 0, 1, 2, 3 });
         // Se espera que gane
        Assert.True(gano);
    }

    [Fact]
    public void JugarPierde()
    {
        // La primera bolilla será 0, no 4
        bool gano = _bolillero.Jugar(new List<int> { 4, 2, 1 });
    // Se espera que pierda
        Assert.False(gano);
    }

    [Fact]
    public void GanarNVeces()
    {
        // Juega una vez con la secuencia correcta {0,1} y gana
        int ganadas = _bolillero.JugarNVeces(
            new List<int> { 0, 1 }, 1);
        // Verifica que ganó 1 vez
        Assert.Equal(1, ganadas);
    }
}