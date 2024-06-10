// Escreva um programa que leia três notas de um aluno e calcule a média. Informe se o aluno está aprovado (média >= 7), em recuperação (5 <= média < 7) ou reprovado (média < 5).

using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Http.Headers;

class Exemplo05
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos verificar se um aluno foi aprovado ou não!");
        Console.WriteLine("Digite um valor para a primeira nota:");
        float nota1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Digite um valor para a segunda nota:");
        float nota2 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Digite um valor para a terceira nota:");
        float nota3 = Convert.ToSingle(Console.ReadLine());

        float media = (nota1 + nota2 + nota3) / 3;

        if (media >= 7)
        {
            Console.WriteLine("O aluno foi aprovado com média " + $"{media:0.00}");
        }
        else if (media >= 5 && media < 7)
        {
            Console.WriteLine("O aluno está de recuperação com média " + $"{media:0.00}");
        }
        else
        {
            Console.WriteLine("O aluno foi Reprovado com média " + $"{media:0.00}");
        }
    }
}