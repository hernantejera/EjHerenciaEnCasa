namespace EjHerenciaEnCasa
{  //En una aplicación de gestión de una biblioteca, se requiere modelar diferentes tipos de libros
   //que se prestan a los usuarios. Se tienen los siguientes requisitos:

    // Todos los libros tienen un título, un autor y un año de publicación.
    // <Algunos libros son libros físicos y tienen un número de páginas.
    // Otros libros son libros electrónicos y tienen un tamaño en kilobytes (KB).
    // Tu tarea es:

    // Definir la clase base "Libro" con los atributos y métodos comunes.
    // Crear la clase derivada "LibroFisico" que herede de "Libro" e incluya el atributo adicional para el número
    // de páginas.
    // Implementar la clase derivada "LibroElectronico" que herede de "Libro" y añada el atributo adicional
    // para el tamaño en kilobytes.
    // Probar tu implementación creando instancias de cada clase y mostrando su información.
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro()
            {
                Tapa = 1,
                Indice = 1,
                Paginas = 100,
                ContraTapa = 1,
            };
            LibroElectronico libroElectronico = new LibroElectronico()
            {
               TamanioEnkilobytes = 18,
            };

            Console.WriteLine($"El libro fisico tiene {libro.Tapa} tapa , tiene {libro.Indice} indice , " +
                $"tiene {libro.Paginas} paginas y {libro.ContraTapa} contra tapa .");
            Console.WriteLine($"El libro electronico tiene {libroElectronico.TamanioEnkilobytes} kilobytes ");
        }
    }
}