using System;

namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Valor impar fornecido pelo usuario:
            Console.Write("Digite um numero impar: ");
            int tamanhoDoDiamante = int.Parse(Console.ReadLine());
            
            int quantidadeIncialEspacos = (tamanhoDoDiamante - 1) / 2;

            int quantidadeDeX = 1;

            int quantidadeDeLinhas = (tamanhoDoDiamante - 1) / 2;

            //parte de cima do diamante:
            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                for (int i = 0; i < quantidadeIncialEspacos; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < quantidadeDeX; i++)
                {
                    Console.Write("x");
                }
                
                quantidadeIncialEspacos--;
                quantidadeDeX += 2;
                Console.WriteLine();
            }      
            //parte de meio: 
            for (int coluna = 0; coluna < tamanhoDoDiamante; coluna++)
            {
                Console.Write("");
            }
            
            //parte de baixo:
            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                for (int i = 0; i < quantidadeIncialEspacos; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < quantidadeDeX; i++)
                {
                    Console.Write("x");
                }

                quantidadeIncialEspacos++;
                quantidadeDeX -= 2;
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
        
        

    }
}
