using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao gerador de apostas");

        int[] numeros = new int[6];
        Random random = new Random();
        //Gera um numero aleatorio

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = random.Next(1, 99);
        }
        //Gera um numero aleatorio para cada espaco no array numeros

        Console.WriteLine("Seus numeros da sorte sao:");

        foreach (int numero in numeros)
        //Percorre o array 1 por 1
        {
            Console.WriteLine(numero);
        }
    }
}
