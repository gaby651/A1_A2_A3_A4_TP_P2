using Xunit;
using SistemaGimnasio.Tests;
using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Tests {
    public class RutinaTests {
        [Fact]
    public void AgregarEjercicio_DebeAgregarALista() {
            //Arrange
            var rutina = new Rutina("YOPUEDO", 120);
            var ejercicio1 = new Ejercicio("levanta", 15, 5, 90);
            var ejercicio2 = new Ejercicio("levanta", 15, 5, 90);

            //Act
            rutina.AgregarEjercicio(ejercicio1);
            rutina.AgregarEjercicio(ejercicio2);
            //Asert
            Assert.NotEmpty(rutina.ObtenerEjercicios());
            Assert.Equal(rutina.ObtenerEjercicios()[0].Nombre, "Levanta");

        }
    }
}
