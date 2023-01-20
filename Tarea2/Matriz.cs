using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Matriz
    {
        private int[,] valores = new int[3, 3]; //Matriz para almacenar los valores

        public void CapturarValores()
        {
            bool isValid;

            //Captura de valores en la matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Ingrese un valor para la posición [" + i + "," + j + "]: ");
                    isValid = int.TryParse(Console.ReadLine(), out valores[i, j]);

                    //Validación del valor ingresado
                    while (!isValid || valores[i, j] < 1 || valores[i, j] > 10)
                    {
                        if (!isValid)
                        {
                            Console.WriteLine("Error: El valor ingresado debe ser un número entero.");
                        }
                        else if (valores[i, j] < 1 || valores[i, j] > 10)
                        {
                            Console.WriteLine("Error: El valor debe estar entre 1 y 10.");
                        }
                        Console.Write("Ingrese un valor para la posición [" + i + "," + j + "]: ");
                        isValid = int.TryParse(Console.ReadLine(), out valores[i, j]);
                    }
                }
            }
        }

        public void ImprimirMatriz()
        {
            //Impresión de la matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(valores[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
