
using Tarea2;

class Program
{
    static void Main(string[] args)
    {
        Matriz matriz = new Matriz();
        matriz.CapturarValores();
        Console.WriteLine("Matriz ingresada: ");
        matriz.ImprimirMatriz();
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

/*En este ejemplo, se crea una clase "Matriz" que tiene dos 
 * métodos: "CapturarValores()" y "ImprimirMatriz()".
 * El primer método captura los valores en la matriz y los valida, mientras que el segundo imprime la matriz.
 * En el método main se crea un objeto de la clase Matriz y se llaman a los metodos capturar y imprimir.

En lugar de usar el método "int.Parse()" para convertir el valor ingresado a un número de tip */




