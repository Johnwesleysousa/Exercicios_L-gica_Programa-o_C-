//  Escreva um programa que leia um número inteiro e informe se ele é par ou ímpar. 

﻿using System;

class Exemplo01
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos descobrir se o número é Par ou Ímpar!");
        Console.WriteLine("Digite um número:");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número " + numero + " é Par!");
        }
        else
        {
            Console.WriteLine("O número " + numero + " é Ímpar!");
        }
    }
}