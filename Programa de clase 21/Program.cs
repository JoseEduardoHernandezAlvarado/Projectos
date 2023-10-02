using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_de_clase_21
{
    public class FuncionesP
    {
        public int F(int x)
        {
            return x + x + 2 * x + 4;
        }
        public Double Calcula(int minimo, int maximo)
        {
            Double sumatoria = 0;
            for (int valor = minimo; valor <= maximo; valor++)
                sumatoria += F(valor);
            return sumatoria;
        }
        public void Escandalo(int minimo, int maximo)
        {
            for (int valor = minimo; valor < maximo; valor++)
                Console.Beep(10 * valor, 100);
            for (int valor = maximo; valor > minimo; valor++)
                Console.Beep(10 * valor, 100);

        }
        public void CapturaPr()
        {
            int minimo;
            int maximo;
            Double resultado;
            Console.WriteLine("\nIndica el valor minimo: ");
            minimo = int.Parse(Console.ReadLine());
            Console.WriteLine("Indica el valor maximo: ");
            maximo = int.Parse(Console.ReadLine());
            resultado = Calcula(minimo, maximo);
            Console.WriteLine("la sumatoria de la funcion es :{0}", resultado);

        }
        public void menu()
        {
            char opc;

            do
            {
                Console.WriteLine("1. Calcular funcion");
                Console.WriteLine("2. Escandalo");
                Console.WriteLine("3. Salida");
                opc = Console.ReadKey().KeyChar;
                switch (opc)
                {
                    case '1':
                        CapturaPr();
                        break;
                    case '2':
                        Escandalo(100, 1000);
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            } while (opc != '3');

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FuncionesP llamar = new FuncionesP();
            llamar.menu();
            Console.ReadKey();
        }
    }
}
