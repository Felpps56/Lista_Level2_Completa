
using System;

namespace Lista_2_Atividades
{
	
	public class ex19
	{
		public static void Main()
			
			/*19. Escreva um programa em C# para exibir a tabuada de multiplicação
				verticalmente de 1 a n.*/
		{
			Console.Write("Digite um número para exibir a tabuada até ele: ");
        	int n = int.Parse(Console.ReadLine());

        	Console.WriteLine("\nTabuada de 1 até " + n + ":");
        
        	for (int i = 1; i <= n; i++) 
        {
            Console.WriteLine("\nTabuada do " + i + ":");
            for (int j = 1; j <= 10; j++) 
            {
            Console.WriteLine(i + " x " + j + " = " + (i * j));	
            }
            
        }
			
			Console.ReadKey(true);
		}
	}
}
