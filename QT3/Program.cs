/*-------------------------------------------------------------------
@Lista: 04 - Funções
Questão 3: Cálculo de Dano Crítico
• Contextualização: Em combates, o jogador pode realizar ataques críticos que causam
danos adicionais. O dano causado depende do ataque base, do multiplicador crítico e
da arma utilizada.
• Comando: Crie um programa que receba o valor do ataque base, o multiplicador crítico
(1.5x, 2x, 3x) e o tipo de arma (Espada, Arco, Cajado). Crie uma função que calcule o
dano crítico da seguinte forma:
• Espada: +10 pontos ao dano total.
• Arco: +5 pontos ao dano total.
• Cajado: +15 pontos ao dano total.
• Exiba o dano total causado pelo ataque crítico.
@Autor: Lucas Amaral Gonçalves
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Clear();
        string? tipoArm;
        double ataqueBase, multiCrit;

        Console.WriteLine("escreva quanto foi o ataque base: ");
        double.TryParse(Console.ReadLine(), out ataqueBase);

        Console.WriteLine("escreva o seu multiplicador: ");
        double.TryParse(Console.ReadLine(), out multiCrit);

        Console.WriteLine("escreva o tipo de arma usando números (espada, arco ou cajado): ");
        tipoArm = Console.ReadLine();


        double total = Some(ataqueBase, multiCrit, tipoArm);
        Console.ReadLine();

        Console.WriteLine("o seu ataque foi de: " + total);

        Console.WriteLine("\nPressione ENTER para fechar.");
        Console.ReadLine();
    }
    static double Some(double ataqueBase, double multiCrit, string tipoArm)
    {

        double total = 0;
        if (tipoArm == "espada")
        {
            total = (multiCrit * ataqueBase) + 10;
        }

        if (tipoArm == "arco")
        {
            total = (multiCrit * ataqueBase) + 5;
        }

        if (tipoArm == "cajado")
        {
            total = (multiCrit * ataqueBase) + 15;
        }
        return total;


    }


}