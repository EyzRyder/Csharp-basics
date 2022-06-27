using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDs01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estrutura Codicional");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 10)
            {
                Console.WriteLine("Variavel " + x + " é maior que 10");
            }
            else
            {
                Console.WriteLine("Variavel " + x + " é menor que 10");
            }

            Console.WriteLine("Digite o mes numerico");
            int y = Convert.ToInt32(Console.ReadLine());

            switch (y)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembr");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break;
                default:
                    Console.WriteLine("Não exite isso mano!!");
                    break;

            }
            Console.WriteLine("Digite um numero para fazr tabuada");
            int z = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(z + " x " + i + " = " + (z * i));
            }

            Console.WriteLine("pyramid");
            int j;
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }


            int zx = 1;
            for (int i = 1; i < 4; i++)
            {
                for (int iz = 1; iz <= 10; iz++)
                {
                    Console.WriteLine($"{zx + i} x {iz} = {(zx + i) * iz}");
                }
                Console.Write("\n");
            }

            for (int i = 1; i < 4; i++)
            {

                Console.WriteLine($"{zx + i} x {i} = {(zx + i) * i}");
                Console.Write("\n");

                Console.ReadLine();
            }
        }
    }
}
