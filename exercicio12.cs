// Escreva um programa que leia um número e verifique se ele é maior que 100. Se não for, informe o dobro desse número. 

using System;

class Exemplo12
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos descobrir se um número é maior que 100, se não for exibiremos o dobro dele!");
        Console.WriteLine("Digite um número:");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero > 100 )
        {
            Console.WriteLine("O número " + numero + " é maior que 100!");
        }
        else
        {
            Console.WriteLine("O dobro de " + numero + " é: " + (numero + numero));
        }
    }
}