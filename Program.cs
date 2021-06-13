using System;

namespace calculadora_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;
            string operacao;

            Console.WriteLine("Digite um número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a operação da conta: Soma, Subtração, Multiplicação ou Divisão? ");
            operacao = Console.ReadLine();

            Console.WriteLine("Digite um outro número: ");
            numero2 = int.Parse(Console.ReadLine());

            var res = new OperacoesMatematicas();

            switch (operacao)
            {
                case "Soma":
                 resultado = res.Soma(numero1, numero2);
                 Console.WriteLine("O resultado é: " + resultado);
                 break;

                case "Subtração":
                 resultado = res.Subtracao(numero1, numero2);
                 Console.WriteLine("O resultado é: " + resultado);
                 break;

                case "Multiplicação":
                 resultado = res.Multiplicacao(numero1, numero2);
                 Console.WriteLine("O resultado é: " + resultado);
                 break;

                case "Divisão":
                 resultado = res.Divisao(numero1, numero2);
                 Console.WriteLine("O resultado é: " + resultado);
                 break;

                default:
                    Console.WriteLine("Ocorreu um erro.");
                    break;
            }

            Console.ReadKey();
            
        }

      
    }
}
