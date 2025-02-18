
using System;

namespace Lista_2_Atividades
{
	
	public class ex20
	{
		public static void Main()
		{
		/*20. Escreva um programa C# para encontrar a soma do primeiro e do
			último dígito de qualquer número.*/
			
			 Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        int ultimoDigito = numero % 10; 
        int primeiroDigito = numero; 

        while (primeiroDigito >= 10) 
        {
            primeiroDigito /= 10;
        }

        int soma = primeiroDigito + ultimoDigito; 

        Console.WriteLine("O primeiro dígito é: " + primeiroDigito);
        Console.WriteLine("O último dígito é: " + ultimoDigito);
        Console.WriteLine("A soma do primeiro e do último dígito é: " + soma);
	
			
			
			
			
			Console.ReadKey(true);
		}
	}
}
