using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    public Dictionary<int, Alumno> Diccionario = [];

    public void Agregar(int legajo, Alumno alumno)
    {
        Diccionario.Add(legajo, alumno);
    }

    public Alumno? BuscarPorClave(int clave)
    {
        if (Diccionario.TryGetValue(clave, out Alumno? alumno))
        {
            return alumno;
        }
        return null;
    }
    
    public Dictionary<int, Alumno>? GetDiccionario()
    {
        return Diccionario;
    }

    public void EliminarAlumno(int legajo)
    {
        var nombre = BuscarPorClave(legajo).Nombre;
        Diccionario.Remove(legajo);
        Console.WriteLine($"alumno {nombre} eliminado");
    }

}
