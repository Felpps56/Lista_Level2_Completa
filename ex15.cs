
using System;

namespace Lista_2_Atividades
{
	
	public class ex15
	{
		public static void Main()
		{
		/*15. Escreva um programa C# para encontrar a soma de números pares
			entre 1 e n.*/
		
			int n = int.Parse(Console.ReadLine());
       		int soma = 0;
        
			Console.Write("Digite o valor de n: ");    
        
        Console.WriteLine("Os números pares entre 1 e {0} são:", n);
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
                soma += i;
            }
        }
        
        Console.WriteLine("\nA soma dos números pares entre 1 e {0} é: {1}", n, soma);		
			
			
			
			
			
			
			
			
			
			
			
			
			
			Console.ReadKey(true);
		}
	}
}
