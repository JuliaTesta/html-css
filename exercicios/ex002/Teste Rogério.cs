using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Selecione a operação: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int operacao = Convert.ToInt32(Console.ReadLine());
            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    resultado = numero1 + numero2;
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    resultado = numero1 / numero2;
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

            Console.WriteLine("O resultado é: " + resultado);
        }
    }
}