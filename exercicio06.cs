//  Escreva um programa que leia um ano e verifique se ele é bissexto. Um ano é bissexto se for divisível por 4, mas não por 100, exceto se for divisível por 400. 

using System;

class Exemplo06
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos descobrir se um ano é bissexto ou não!");
        int ano = Convert.ToInt32(Console.ReadLine());
        if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
        {
            Console.WriteLine("O ano " + ano + " é bissexto!");
        }
        else
        {
            Console.WriteLine("O ano " + ano + " não é bissexto!");
        }
    }
}