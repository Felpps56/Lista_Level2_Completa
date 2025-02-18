
using System;

namespace Lista_2_Atividades
{
	
	public class ex18
	{
		public static void Main()
		{
		/*18. Escreva um programa em C# para criar um padrão como triângulo de
			ângulo reto com números iguais que repetirá um número em cada linha.
			O padrão é o seguinte:
			1
			22
			333
			4444*/

		Console.WriteLine("Escreva um número:");
		int numero = int.Parse(Console.ReadLine());		
        Console.WriteLine("Padrão como triângulo de ângulo reto:");
        for (int i = 1; i <= numero; i++) 
        {
            for (int j = 1; j <= i; j++) 
            Console.Write(i); 
            }
            Console.WriteLine();		
			
			
			
			
			Console.ReadKey(true);
		}
	}
}
