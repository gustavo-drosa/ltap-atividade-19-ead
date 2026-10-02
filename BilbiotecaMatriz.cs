using System;

namespace BibliotecaMatriz
{
    class Matriz
    {
        public static int[,] carregarMatriz(string caminhoArquivo)
        {
            string[] linhas = File.ReadAllLines(caminhoArquivo);
            int numLinhas = linhas.Length;
            int numColunas = linhas[0].Split(',').Length;

            int[,] matriz = new int[numLinhas, numColunas];

            for (int i = 0; i < numLinhas; i++)
            {
                string[] valores = linhas[i].Split(',');
                for (int j = 0; j < numColunas; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }
            return matriz;
        }
        public static void gerarMatriz(int[,] matriz)
        {
            Random random = new Random();
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matriz[i, j] = random.Next(0, 100);
                }
            }
        }
        public static void lerMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);
            //lendo a matriz
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"[{i},{j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }// fim for j
            }// fim for i
        }// fim funcao ler

        // mostraMatriz
        public static void mostrarMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);
            // mostrar a matriz
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"|{matriz[i, j],3}");
                }// fim j
                Console.WriteLine();// quebra a linha
            }// fim i
        }

    }
}