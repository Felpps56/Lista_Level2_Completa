/*
 * Created by SharpDevelop.
 * User: FelppXs
 * Date: 16/02/2025
 * Time: 21:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Lista_2_Atividades
{
	
	public class ex11
	{
		public static void Main()
		{
		/*11. Escreva um programa em C# para exibir o cubo do número até a
			quantidade digitada pelo usuário.*/	
		
		 int numero = int.Parse(Console.ReadLine());
        
		Console.Write("Digite a quantidade de números para calcular o cubo: ");
       
        Console.WriteLine("O cubo dos primeiros {0} números naturais são:", numero);
        for (int i = 0; i <= numero; i++)
        {
            Console.WriteLine("Número: {0}, Cubo: {1}", i, i * i * i);
        }
			
			
			
			
			
			
			
			
			
			
			Console.ReadKey(true);
		}
	}
}
