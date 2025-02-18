/*
 * Created by SharpDevelop.
 * User: FelppXs
 * Date: 15/02/2025
 * Time: 15:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Lista_2_Atividades
{
	
	public class ex9
	{
		public static void Main()
		{
		/*9. Escreva um programa em C# para exibir n termos de números naturais e
			sua soma.*/
		
		int n = int.Parse(Console.ReadLine());
		int soma = 0;
		
		Console.Write("Digite o valor de n: ");	
		
		
		Console.WriteLine("Os primeiros {0} números naturais são:", n);
		for (int i = 0; i <= n; i++){
			Console.WriteLine(i + " ");
				soma += i;
			
			Console.WriteLine("\n A soma dos {0} primeiros números naturais é: {1}", n, soma);
         
		




			Console.ReadKey(true);
		}	
			
			
			
			
			
			
		
			
			
		
			
			
			
			
			
			
			
			
			
			
			
			Console.ReadKey(true);
		}
	}
}
