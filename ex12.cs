
using System;

namespace Lista_2_Atividades
{
	
	public class ex12
	{
		public static void Main()
		{
			/*12. Escreva um programa em C# para exibir a tabela de multiplicação de
					um determinado número inteiro.*/
			
			int numero = int.Parse(Console.ReadLine());
			
		 Console.Write("Digite um número para exibir a tabela de multiplicação: ");
        
        
        Console.WriteLine("Tabela de multiplicação do {0}:", numero);
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
        }	
			
			
			
			
			
			
			
			
			
			Console.ReadKey(true);
		}
	}
}
