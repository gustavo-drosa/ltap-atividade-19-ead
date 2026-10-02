using System;

namespace BibliotecaVetor
{
    class Vetor
    {
        public static void lerVetor(int[] vetor)
        {
            Console.WriteLine("Entre com os dados do vetor:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Array[{i}]:");
                vetor[i] = int.Parse(Console.ReadLine());
            }// fim for 
        }
        public static void gerarVetor(int[] vetor)
        {
            Random aleatorio = new Random();
            for (int i = 0; i < vetor.Length; i++)
                vetor[i] = aleatorio.Next(1, 100);
        }
        public static void mostrarVetor(int[] vetor)
        {
            Console.WriteLine("Dados do Vetor:");
            for (int i = 0; i < vetor.Length; i++)
                Console.Write("|" + vetor[i]);
        }

    }
}