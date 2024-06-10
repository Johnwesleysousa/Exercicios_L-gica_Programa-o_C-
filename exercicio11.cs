// Escreva um programa que leia um número e verifique se ele está no intervalo de 10 a 20 (inclusive). 

using System;

class Exemplo11
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos descobrir se um número está no intervalo entra 10 e 20!");
        Console.WriteLine("Digite um número:");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero >= 10 && numero <= 20) 
        { 
            Console.WriteLine("O número está no intervalo entre 10 e 20!");
        }
        else
        {
            Console.WriteLine("O número não está no intervalo entre 10 e 20!");
        }
    }
}