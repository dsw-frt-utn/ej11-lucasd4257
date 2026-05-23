using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using static System.Net.Mime.MediaTypeNames;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var alumno1 = new Alumno(1, "Jorge", 7);
        var alumno2 = new Alumno(2, "Juan", 4);
        var alumno3 = new Alumno(3, "Pedro", 10);

        var listaAlumnos = new CasoList();

        listaAlumnos.Agregar(alumno1);
        listaAlumnos.Agregar(alumno2);
        listaAlumnos.Agregar(alumno3);

        Ejemplos.ListarALumnosConsola(listaAlumnos.ListaAlumnos);

        Console.WriteLine("");

        Console.WriteLine(listaAlumnos.BuscarAlumnoNombre("Juan"));

        Console.WriteLine("");

        if (listaAlumnos.BuscarAlumnoNombre("Julian") == null)
        {
            Console.WriteLine("No existe");
        }
        else
        {
            Console.WriteLine(listaAlumnos.BuscarAlumnoNombre("Julian"));
        }

        Console.WriteLine("");

        listaAlumnos.EliminarAlumno(alumno2);

        Console.WriteLine("");

        Ejemplos.ListarALumnosConsola(listaAlumnos.ListaAlumnos);

        Console.WriteLine("");

        listaAlumnos.EliminarAlumnoPosicion(0);

        Ejemplos.ListarALumnosConsola(listaAlumnos.ListaAlumnos);

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var alumno1 = new Alumno(1, "Jorge", 7);
        var alumno2 = new Alumno(2, "Juan", 4);
        var alumno3 = new Alumno(3, "Pedro", 10);

        var listaAlumnosD = new CasoDictionary();

        listaAlumnosD.Agregar(alumno1.Id, alumno1);
        listaAlumnosD.Agregar(alumno2.Id, alumno2);
        listaAlumnosD.Agregar(alumno3.Id, alumno3);

        Ejemplos.ListarALumnosDiccionarioConsola(listaAlumnosD.GetDiccionario());

        Console.WriteLine("");

        Console.WriteLine($"alumno encontrado: id: {listaAlumnosD.BuscarPorClave(1).Id}, nombre: {listaAlumnosD.BuscarPorClave(1).Nombre}, promedio: {listaAlumnosD.BuscarPorClave(1).Promedio}");

        Console.WriteLine("");

        if (listaAlumnosD.BuscarPorClave(4) == null)
        {
            Console.WriteLine("No existe");
        }
        else
        {
            Console.WriteLine(listaAlumnosD.BuscarPorClave(4));
        }

        Console.WriteLine("");

        listaAlumnosD.EliminarAlumno(1);

        Console.WriteLine("");

        Ejemplos.ListarALumnosDiccionarioConsola(listaAlumnosD.GetDiccionario());

        Console.WriteLine("");

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var listaLibros = Libro.CrearLista();

        Ejemplos.ListarLibro(CasoLinq.GetPrimero(listaLibros));

        Console.WriteLine("");

        Ejemplos.ListarLibro(CasoLinq.GetUltimo(listaLibros));

        Console.WriteLine("");

        Console.WriteLine(CasoLinq.GetTotalPrecios(listaLibros));

        Console.WriteLine("");

        Console.WriteLine($"{CasoLinq.GetPromedioPrecios(listaLibros):F2}");

        Console.WriteLine("");

        Ejemplos.ListarLibrosConsola(CasoLinq.GetListById(listaLibros));

        Console.WriteLine("");

        foreach (var libro in CasoLinq.GetLibros(listaLibros))
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("");

        Ejemplos.ListarLibro(CasoLinq.GetMayorPrecio(listaLibros));

        Console.WriteLine("");

        Ejemplos.ListarLibro(CasoLinq.GetMenorPrecio(listaLibros));

        Console.WriteLine("");

        Ejemplos.ListarLibrosConsola(CasoLinq.GetMayorPromedio(listaLibros));

        Console.WriteLine("");

        Ejemplos.ListarLibrosConsola(CasoLinq.GetOrdenadoDescendente(listaLibros));


    }

    private static void ListarLibrosConsola(List<Libro> libros)
    {
        foreach (var libro in libros)
        {
            Console.WriteLine($"id: {libro.Id}, titulo: {libro.Titulo}, precio: {libro.Precio}"); 
        }
    }

    private static void ListarLibro(Libro libro)
    { 
           Console.WriteLine($"id: {libro.Id}, titulo: {libro.Titulo}, precio: {libro.Precio}");
        
    }

    private static void ListarALumnosConsola(List<Alumno> alumnos)
    {
        foreach (var alumno in alumnos)
        {
            Console.WriteLine($"id: {alumno.Id}, nombre: {alumno.Nombre}, promedio: {alumno.Promedio}"); 
        }
    }

    private static void ListarALumnosDiccionarioConsola(Dictionary<int, Alumno> alumnos)
    {
   
        foreach (var alumno in alumnos)
        {
            Console.WriteLine($" key: {alumno.Key}, Alumno: {alumno.Value.Nombre}");
        }
    }

}
