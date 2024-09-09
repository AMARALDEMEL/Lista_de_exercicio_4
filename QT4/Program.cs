/*-------------------------------------------------------------------
@Lista: 04 - Funções
Questão 4: Sistema de Resgate em Labirinto
• Contextualização: Em um jogo de exploração, o jogador precisa resgatar aliados perdidos em um labirinto. O sucesso do resgate depende da quantidade de energia, da distância até o aliado e do nível de ameaça no caminho.
• Comando: Crie um programa que receba a energia do jogador, a distância até o aliado (em metros) e o nível de ameaça (baixo, médio, alto). Crie uma função que determine se o resgate é possível com base nas seguintes condições:
• Energia maior que 50: Resgate bem-sucedido.
• Distância menor que 20 metros: +10 de energia.
• Nível de ameaça:
o Baixo: Sem penalidade.
o Médio: -10 de energia.
o Alto: -20 de energia.
• Exiba se o resgate foi bem-sucedido ou falhou.
@Autor: Lucas Amaral Gonçalves
@Data: 09/09/2024
---------------------------------------------------------------------*/
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Clear();
        string? ameaca;
        int ener, aliado;

        Console.WriteLine("qual o nível de ameaça? (baixo, medio, alto): ");
        ameaca = Console.ReadLine();

        Console.WriteLine("qual a sua energia inicial?: ");
        int.TryParse(Console.ReadLine(), out ener);

        Console.WriteLine("qual sua distância até o aliado?: ");
        int.TryParse(Console.ReadLine(), out aliado);

        int total = Some(aliado, ener, ameaca);
        Console.ReadLine();

        Console.WriteLine("o seu ataque foi de: " + total);

        Console.WriteLine("\nPressione ENTER para fechar.");
        Console.ReadLine();
    }
    static int Some(int aliado, int ener, string? ameaca)
    {

        int total = 0;
        if (ameaca == "baixo")
        {
            if (aliado < 20)
            {
                total = ener + 10;
                if (total > 50)
                {
                    Console.WriteLine("Resgate bem sucedido");
                }
                else
                {
                    Console.WriteLine("Resgate falhou");
                }
            }
            else
            {
                if (ener > 50)
                {
                    Console.WriteLine("Resgate bem sucedido");
                }
                else
                {
                    Console.WriteLine("Resgate falhou");
                }
            }
        }

        else if (ameaca == "medio")
        {
            ener -= 10;
            if (aliado < 20)
            {
                total = ener + 10;
                if (total > 50)
                {
                    Console.WriteLine("Resgate bem sucedido");
                }
                else
                {
                    Console.WriteLine("Resgate Falhou");
                }
            }
            else
            {
                if (ener > 50)
                {
                    Console.WriteLine("Resgate bem sucedido");
                }
                else
                {
                    Console.WriteLine("Resgate falhou");
                }
            }
        }
        else if (ameaca == "alto")
        {
            ener -= 20;
            if (aliado < 20)
            {
                total = ener + 10;
                if (total > 50)
                {
                    Console.WriteLine("Resgate bem sucedido");
                }
                else
                {
                    Console.WriteLine("Resgate Falhou");
                }
            }
            else 
            {
                   if(ener > 50)
                {
                Console.WriteLine("Resgate bem sucedido");
                }
                else 
                {
                    Console.WriteLine("Resgate falhou");
                }
            }
        }
        return total;
    }
}