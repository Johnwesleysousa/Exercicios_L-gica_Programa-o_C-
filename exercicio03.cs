// Escreva um programa que leia dois números inteiros e informe qual deles é o maior.

using System;

class Exemplo03
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos descobrir qual número é maior!");
        Console.WriteLine("Digite um número");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite um segundo número");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero1 < numero2)
        {
            Console.WriteLine("O número " + numero2 + " é maior que o número " + numero1);
        }
        else 
        {
            Console.WriteLine("O número " + numero1 + " é maior que o número " + numero2);
        }
    }
}