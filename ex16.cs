
using System;

namespace Lista_2_Atividades
{
	
	public class ex16
	{
		public static void Main()
		{
		/*16. Escreva um programa em C# para calcular o fatorial de um determinado
			número.*/
		
		 int numero = 0;
		 
        Console.Write("Digite um número: ");
        
        numero = int.Parse(Console.ReadLine());
        int fatorial = 1;
        
        Console.WriteLine("Calculando o fatorial de {0}:", numero);
        for (int i = 1; i <= numero; i++)
        {
            fatorial *= i;
        }
        
        Console.WriteLine("O fatorial de {0} é: {1}", numero, fatorial);
		
			
			
			
			
			
			
			Console.ReadKey(true);
		}
	}
}
