using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;

Console.WriteLine("sISTEMA DE GESTOR DE GIMNASIO");
//Crear usuario
Console.WriteLine("Ingresa el nombre del usuario");
var nombreUsuario = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la edad del usuario");
var edadUsuario = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ingresa el objetivo del usuario");
var objetivoUsuario = Console.ReadLine() ?? "";

var usuario = new Usuario(nombreUsuario,edadUsuario,objetivoUsuario);
//Crear entrenador
Console.WriteLine("Ingresa el nombre del entrendora");
var nombreEntrenador = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la especialidad del entrenador");
var especialidadEntrenador = Console.ReadLine() ?? "";

var entrenador = new Entrenador(nombreEntrenador, especialidadEntrenador);

//Crear rutina
Console.WriteLine("Ingresa el nombre de la rutina");
var nombreRutina = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la especialidad del entrenador");
var duracionRutina = int.Parse(Console.ReadLine() ?? "");

var rutina = new Rutina(nombreRutina, duracionRutina);
//Agregar ejercicios
Console.WriteLine("Cuantos ejercicios tendra la rutina");
int numEjercicios = int.Parse(Console.ReadLine() ?? "");

for (int i=1; i<=numEjercicios ; i++) 
{
    Console.WriteLine($"Ejercicio {i}");
    Console.WriteLine("Nombre del ejercicio");
    var nombreEjercicio = Console.ReadLine() ?? "";

    Console.WriteLine("Numero del ejercicio");
    int repeticionesEjercicio = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Series del ejercicio");
    int seriesEejercicio = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Descanso del ejercicio");
    int descansoEjercicio = int.Parse(Console.ReadLine() ?? "");
    var ejercicio = new Ejercicio(nombreEjercicio, repeticionesEjercicio,seriesEejercicio, descansoEjercicio);
    rutina.AgregarEjercicio(ejercicio);

}
//Asignar al usuario
var asignador = new AsignadorRutinas();
asignador.AsignarRutinaAUsuario(usuario, rutina);
asignador.AsignarUusaurioAEntrenador(usuario, entrenador);



//Muetsra el resumen
Console.WriteLine("Resumen de aginaciones: ");
Console.WriteLine($"Usuario {usuario.Nombre} rutina: {Usuario.RutinaAsignada.Nombre}");

foreach( var e in Usuario.RutinaAsignada.ObtenerEjercicios()) {
    Console.WriteLine(${ e.Nombre} | Series: { e.Series}x{ e.Repeticiones}| Descansos);
}
//Terminar 