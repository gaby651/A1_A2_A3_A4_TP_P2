using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGimnasio.Modelos {
    public class Entrenador {
        public string Nombre {  get; set; }
        public string Especialidad { get; set; }
        private List<Usuario> usuariosAsigandos;
        public Entrenador(string nombre, string especialidad) {
            Nombre=nombre;
            Especialidad=especialidad;
            usuariosAsigandos=new List<Usuario>();
        }
        public void AsignarUsuario(Usuario usuario) {
            usuariosAsigandos.Add(usuario);
        }
        public List<Usuario> ObtenerUsuario() 
        {
            return usuariosAsigandos;
        }

    }
}
