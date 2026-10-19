using SistemaGimnasio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGimnasio.Tests {
    public class EntrenadorTests {
        [Fact]
        public void AsignarUsuario_DebeAgregarUsaurioALista() {
            //Arrange
            var usuario = new Usuario("Gael", 20, "Definir");
            var usuario2 = new Usuario("Gael", 20, "Definir");
            var entrenador = new Entrenador("Pepe", "Licuados proteicos");
            //Act
            entrenador.AsignarUsuario(usuario);
            entrenador.AsignarUsuario(usuario2);

            //Assert
            Assert.NotEmpty(entrenador.ObtenerUsuario());
            Assert.Contains(usuario2, entrenador.ObtenerUsuario());
        }
    }
}
