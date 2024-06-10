// Escreva um programa que leia três lados de um triângulo e verifique se eles formam um triângulo válido. Para isso, a soma de dois lados deve ser sempre maior que o terceiro lado. 

using System;

class Exemplo04
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos verificar os lados de um triângulo para verificar se ele é um triângulo válido");
        Console.WriteLine("Digite um valor para o primeiro lado:");
        int lado1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite um valor para o segundo lado:");
        int lado2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite um valor para o terceiro lado:");
        int lado3 = Convert.ToInt32(Console.ReadLine());
        if ((lado1 + lado2) > lado3) 
        { 
            Console.WriteLine("O triângulo é válido!");
        }
        else if ((lado2 + lado3) > lado1) 
        {
            Console.WriteLine("O triângulo é válido!");
        }
        else if ((lado1 + lado3) > lado2)
        {
            Console.WriteLine("O triângulo é válido!");
        }
        else
        {
            Console.WriteLine("O triângulo é inválido!");
        }
    }
}