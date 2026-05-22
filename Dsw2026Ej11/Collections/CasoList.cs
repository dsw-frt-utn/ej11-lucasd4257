using Dsw2026Ej11.Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    public List<Alumno> ListaAlumnos = [];

    public void Agregar(Alumno alumno)
    {
        ListaAlumnos.Add(alumno);
    }

    public List<Alumno> ListarAlumnos()
    {
        return ListaAlumnos;
    }

    public Alumno? BuscarAlumnoNombre(string nombre)
    {

        return ListaAlumnos.Find(n => n.Nombre == nombre);
    }

    public void EliminarAlumno(Alumno alumno)
    {
        ListaAlumnos.Remove(alumno);
        Console.WriteLine($"Alumno {alumno.Nombre} eliminado");
    }

    public void EliminarAlumnoPosicion(int index)
    {
        if (index >= 0 && index < ListaAlumnos.Count)
        {
            ListaAlumnos.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("No existe el indice");
        }
    }
    
}
