namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region declarar variables
            int contador, acumulador, mayor = 0, menor = 0;
            int cantidad, num;
            #endregion

            #region inicializar contador y acumulador
            contador = 0;
            acumulador = 0;
            #endregion

            #region Solicitar cantidad de ingresos
            Console.WriteLine("ingrese la cantidad de numeros a entrar");
            cantidad = Convert.ToInt32(Console.ReadLine());
            // otra manera
            /* string linea = Console.ReadLine();
            cantidad = Convert.ToInt32(linea); */
            #endregion

            #region iterar ingresos
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("ingrese el numero " + (i + 1));
                num = Convert.ToInt32(Console.ReadLine());

                if (num != 0)
                {
                    contador++;
                }
                acumulador += num;
                if (num > mayor || i == 0)
                {
                    mayor = num;
                }

                if (num < menor || i == 0)
                {
                    menor = num;
                }
            }
            #endregion

            #region verificar si hubo ingresos
            if (contador != 0)
            {
                double prom = 1d*acumulador / contador;
                #region mostrar resultados
                Console.WriteLine("el promedio de los numeros es: " + prom);
                Console.WriteLine("el mayor numero es: " + mayor);
                Console.WriteLine("el menor numero es: " + menor);
                #endregion
            }

            else
            {
                Console.WriteLine("no se ingresaron valores");
            }
            #endregion

            
            
        }
    }
}
