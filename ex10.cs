/*
 * Created by SharpDevelop.
 * User: FelppXs
 * Date: 15/02/2025
 * Time: 18:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Lista_2_Atividades
{
	
	public class ex10
	
	{
		public static void Main()
		{
		/*10. Escreva um programa em C# para ler 10 números do teclado e
			encontrar sua soma e média.*/
		
			int numero = int.Parse(Console.ReadLine());
			int soma = 0;
			
        Console.Write("Digite o valor de numero: ");
        
        
        Console.WriteLine("Os primeiros {0} números naturais são:", numero);
        for (int i = 0; i <= numero; i++)
        {
            Console.WriteLine(i + " ");
            soma += i;
        }
        
        double media = (double)soma / (numero + 1);
        
        Console.WriteLine("\nA soma dos {0} primeiros números naturais é: {1}", numero, soma);
        Console.WriteLine("A média dos {0} primeiros números naturais é: {1}", numero, media);
        {
           
        }
     
			
			
			
			
			
			Console.ReadKey(true);
		}
	}
}
