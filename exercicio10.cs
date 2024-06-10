// Escreva um programa que leia dois números e uma operação (adição, subtração, multiplicação ou divisão) e realize a operação correspondente. 

using System;

class Exemplo10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos fazer uma operação com dois números!");
        Console.WriteLine("Digite o primeiro número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escolha a operação matemática: ( + , - , * , /) ");
        string? operacao = (Console.ReadLine());

        if (operacao == "+")
        {
            int soma = numero1 + numero2;
            Console.WriteLine("A soma dos dois números é:" + soma);
        }
        else if (operacao == "-")
        {
            int subtracao = numero1 - numero2;
            Console.WriteLine("A subtração dos dois números é:" + subtracao);
        }
        else if (operacao == "*")
        {
            int multiplicacao = numero1 * numero2;
            Console.WriteLine("A multiplicação dos dois números é:" + multiplicacao);
        }
        else if (operacao == "/")
        {
            int divisao = numero1 / numero2;
            Console.WriteLine("A divisão dos dois números é:" + divisao);
        }
        else
        {
            Console.WriteLine("");
        }
    }
}