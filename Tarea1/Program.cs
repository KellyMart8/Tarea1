using System;
using Tarea1;

class Program
{
    Class1 c = new Class1();
    static void Main(string[] args)
    {
        double[] ST = new double[100]; //Vector para almacenar los subtotales
        double IVA = 0.15; //IVA del 15%
        int cF;
        bool isValid;


        do
        {
            Console.WriteLine("Ingrese la cantidad de facturas a calcular: ");
            isValid = int.TryParse(Console.ReadLine(), out cF);
            if (!isValid)
            {
                Console.WriteLine("Error: El valor ingresado debe ser un número.");
            }
            else if (cF < 1 || cF > 100)
            {
                Console.WriteLine("Error: La cantidad de facturas debe estar entre 1 y 100.");
                isValid = false;
            }
        } while (!isValid);

        //Captura de subtotales
        for (int i = 0; i < cF; i++)
        {
            Console.Write("Ingrese el subtotal de la factura " + (i + 1) + ": ");
            isValid = double.TryParse(Console.ReadLine(), out ST[i]);

            //Validación del subtotal ingresado
            while (!isValid || ST[i] < 1 || ST[i] > 25000)
            {
                if (!isValid)
                {
                    Console.WriteLine("Error: El valor ingresado debe ser un número.");
                }
                else if (ST[i] < 1 || ST[i] > 25000)
                {
                    Console.WriteLine("Error: El subtotal debe estar entre 1 y 25000 dólares.");
                }
                Console.Write("Ingrese el subtotal de la factura " + (i + 1) + ": ");
                isValid = double.TryParse(Console.ReadLine(), out ST[i]);
            }
        }

        //Cálculo y muestra del IVA correspondiente a cada subtotal
        for (int i = 0; i < ST.Length; i++)
        {
            double IVA_factura = ST[i] * IVA;
            Console.WriteLine("IVA de la factura " + (i + 1) + ": " + IVA_factura + " dólares");
        }

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}


/*La aplicación utiliza un ciclo "for" para capturar 
    los subtotales y otro para calcular e imprimir el IVA correspondiente a cada subtotal.
    También se valida que el subtotal ingresado esté dentro del rango
    especificado (entre 1 y 25000 dólares). */

/*En lugar de usar el método "double.Parse()" para convertir el valor ingresado
 * a un número de tipo double, se utiliza "double.TryParse()", el cual intenta convertir el valor ingresado 
 * y devuelve "true" si la conversión es exitosa o "false" en caso contrario. 
 * En caso de que la conversión sea fallida se indica al usuario que debe ingresar un valor numérico. */


