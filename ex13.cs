
using System;

namespace Lista_2_Atividades
{
	
	public class ex13
	{
		public static void Main()
		{
		/*13. Escreva um programa em C# para exibir os n termos do número natural
			ímpar e sua soma.*/
		
			int numero = int.Parse(Console.ReadLine());
			int soma = 0, contador = 0, impar = 1;
			
			 Console.Write("Digite números ímpares: ");
        				
        
        	Console.WriteLine("Os primeiros {0} números ímpares são:", numero);
        				while (contador < numero)
        {
            Console.Write(impar + " ");
            			soma += impar;
            			impar += 2;
            			contador++;
        }
        
        	Console.WriteLine("\nA soma dos {0} primeiros números ímpares é: {1}", numero, soma);		
			
			
			
			
			
			
			
			
			Console.ReadKey(true);
		}
	}
}
