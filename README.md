<h1 align="center">E.T. Nº12 D.E. 1º "Libertador Gral. José de San Martín"</h1>
<p align="center">
  <img src="https://et12.edu.ar/imgs/et12.svg">
</p>

## Computación 2026

**Asignatura**: Programación / Computación

**Nombre TP**: Simulación de Bolillero

**Apellido y nombre Alumno**: Celedonio Leon Flores

**Curso**: *6°7*

# 🎯 Simulación de Bolillero

Este proyecto consiste en el desarrollo de un sistema que simula el funcionamiento de un bolillero. El mismo contiene bolillas numeradas desde 0 hasta N y permite extraerlas de forma controlada mediante un mecanismo de azar.

El sistema permite realizar jugadas, representadas como listas de números, verificando si coinciden en orden con las bolillas extraídas. Además, incluye la posibilidad de ejecutar múltiples intentos de una jugada y contabilizar cuántas veces se acierta.

Para el manejo del azar, se implementa una interfaz (`IAzar`) que permite desacoplar la lógica y facilitar las pruebas unitarias mediante implementaciones como `Primero`, que devuelve siempre el mismo valor.

El proyecto incluye pruebas unitarias que validan:

* Extracción de bolillas
* Reingreso de bolillas
* Jugadas ganadas y perdidas
* Ejecución de múltiples jugadas

---

## Comenzando 🚀

Clonar el repositorio github, desde Github Desktop o ejecutar en la terminal o CMD:

```
git clone https://github.com/ET12DE1Computacion/simpleTemplateCSharp
```

### Pre-requisitos 📋

* .NET 6.0.5 (SDK .NET 6.0.300) - [Descargar](https://dotnet.microsoft.com/download/dotnet/6.0)

## Despliegue 📦

Para ejecutar el proyecto:

1. Abrir la solución en Visual Studio o Visual Studio Code
2. Restaurar dependencias:

```
dotnet restore
```

3. Compilar:

```
dotnet build
```

4. Ejecutar los tests:

```
dotnet test
```

No se requieren configuraciones adicionales.

## Construido con 🛠️

*Menciona las herramientas y versiones que utilizaste para crear tu proyecto*

* [Visual Studio Code](https://code.visualstudio.com/#alt-downloads) - Editor de código.
* C#
* .NET
* xUnit (framework de testing)

## 📦 Paquetes utilizados (NuGet)
* xUnit → https://www.nuget.org/packages/xunit
* Microsoft.NET.Test.Sdk → https://www.nuget.org/packages/Microsoft.NET.Test.Sdk

## Versionado 📌

Usamos [SemVer](http://semver.org/) para el versionado. Para todas las versiones disponibles, mira los [tags en este repositorio](https://github.com/ET12DE1Computacion/simpleTemplateCSharp/tags).

## Autores ✒️

*Menciona a todos aquellos que ayudaron a levantar el proyecto desde sus inicios*

* **Celedonio Leon Flores** - *Desarrollo* - [Celedonioleonflores] (https://github.com/C3ledonioleon)

## Licencia 📄

Este proyecto está bajo la Licencia (Tu Licencia) - mira el archivo [LICENSE.md](LICENSE.md) para detalles.
