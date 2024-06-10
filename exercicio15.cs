// Escreva um programa que leia o peso e a altura de uma pessoa, calcule o IMC e informe a categoria: 

// Abaixo do peso: IMC < 18.5 

// Peso normal: 18.5 <= IMC < 24.9 

// Sobrepeso: 25 <= IMC < 29.9 

// Obesidade grau I: 30 <= IMC < 34.9 

// Obesidade grau II: 35 <= IMC < 39.9 

// Obesidade grau III: IMC >= 40 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o peso (em kg):");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a altura (em metros):");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine($"Seu IMC é: {imc}");

        if (imc < 18.5)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (imc < 24.9)
        {
            Console.WriteLine("Peso normal");
        }
        else if (imc < 29.9)
        {
            Console.WriteLine("Sobrepeso");
        }
        else if (imc < 34.9)
        {
            Console.WriteLine("Obesidade grau I");
        }
        else if (imc < 39.9)
        {
            Console.WriteLine("Obesidade grau II");
        }
        else
        {
            Console.WriteLine("Obesidade grau III");
        }
    }
}
