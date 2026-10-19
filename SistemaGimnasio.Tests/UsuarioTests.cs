using SistemaGimnasio.Tests;
using SistemaGimnasio.Modelos;


namespace SistemaGimnasio.Tests {
    public class UsuarioTests {
        [Fact]//Fact para que se realice la prueba
        public void AsignarRutina_DebeAsignarCorrectamente() 
        {
        //Arrange
            var usuario = new Usuario("Gael", 20, "Definir");
            var rutina = new Rutina("Yo puedo",120);
            //Act
            usuario.AsignarRutina(rutina);

            //Assert
            Assert.Equal("Yo puedo", usuario.RutinaAsignada.Nombre);
        }
    }
}