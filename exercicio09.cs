// Escreva um programa que leia o código de um produto e informe a sua categoria: 

// 1 a 10: Alimento não-perecível 

// 11 a 20: Alimento perecível 

// 21 a 30: Vestuário 

// 31 a 40: Eletrônicos 

// Outros: Código inválido 

using System;

class Exemplo09
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos identificar a categoria de um produto!");
        Console.WriteLine("Digite o código de um produto");
        int codProduto = Convert.ToInt32(Console.ReadLine());
        if (codProduto >= 1 && codProduto <= 10) 
        {
            Console.WriteLine("Alimento não perecível");
        }
        else if (codProduto >= 11 && codProduto <= 20)
        {
            Console.WriteLine("Alimento perecível");
        }
        else if(codProduto >= 21 && codProduto <= 30)
        {
            Console.WriteLine("Vestuário");
        }
        else if(codProduto >= 31 && codProduto <= 40)
        {
            Console.WriteLine("Eletrônicos");
        }
        else
        {
            Console.WriteLine("Código inválido! Numeração valida somente ao Numero: 40 ");
        }
    }
}