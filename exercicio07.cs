// Escreva um programa que leia a idade de uma pessoa e informe se ela é uma criança (0-12 anos), adolescente (13-17 anos), adulto (18-59 anos) ou idoso (60 anos ou mais). 

using System;

class Exemplo07
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos descobrir se você é Criança, Adulto ou Idoso");
        Console.WriteLine("Quantos anos você tem?");
        int idade = Convert.ToInt32(Console.ReadLine());
        if (idade <= 0)
        {
            Console.WriteLine("Idade inválida!");
        }
        else if (idade > 0 && idade <= 12)
        {
            Console.WriteLine("Você é uma criança!");
        }
        else if (idade >= 7 && idade <= 17)
        {
            Console.WriteLine("Você é adolescente!");
        }
        else if (idade >= 18 && idade <= 59)
        {
            Console.WriteLine("Você é adulto!");
        }
        else 
        { 
            Console.WriteLine("Você é um idoso"); 
        }
    }
}