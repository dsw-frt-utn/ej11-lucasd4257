namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;
using System.Linq;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    public static Libro? GetPrimero(List<Libro> libros)
    {
        return libros.FirstOrDefault();
    }

    public static Libro? GetUltimo(List<Libro> libros)
    {
        return libros.LastOrDefault();
    }

    public static decimal? GetTotalPrecios(List<Libro> libros)
    {
        return libros.Sum(n => n.Precio);
    }

    public static decimal? GetPromedioPrecios(List<Libro> libros)
    {
        return libros.Average(n => n.Precio);
    }

    public static List<Libro>? GetListById(List<Libro> libros)
    {
        return libros.Where(n => n.Id > 15).ToList();
    }

    public static List<string>? GetLibros(List<Libro> libros)
    {
        return libros.Select(n => $"precio: {n.Precio:C2} ; titulo: {n.Titulo}").ToList();
    }

    public static Libro? GetMayorPrecio(List<Libro> libros)
    {
        return libros.MaxBy(p => p.Precio);
    }

    public static Libro? GetMenorPrecio(List<Libro> libros)
    {
        return libros.MinBy(p => p.Precio);
    }

    public static List<Libro>? GetMayorPromedio(List<Libro> libros)
    {
        var promedio = libros.Average(p => p.Precio);
        return libros.Where(n => n.Precio > promedio).ToList();
    }

    public static List<Libro>? GetOrdenadoDescendente(List<Libro> libros)
    {
        return libros.OrderByDescending(n => n.Titulo).ToList();
    }
}
