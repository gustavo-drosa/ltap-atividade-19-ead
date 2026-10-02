using System;
using BibliotecaMatriz;

class ExercicioMatriz
{

  static double calcularPercentualDesmatamento(int[,] matriz)
  {
    int areaTotal = matriz.GetLength(0) * matriz.GetLength(1);
    double areaDesmatada = 0.0;

    for (int i = 0; i < matriz.GetLength(0); i++)
      for (int j = 0; j < matriz.GetLength(1); j++)
        if (matriz[i, j] == 0)
          areaDesmatada++;

    double percentualDesmatamento = areaDesmatada / areaTotal * 100;

    return percentualDesmatamento;
  }

  static void analisarAumento(int[,] matrizAnterior, int[,] matrizAtual)
  {
    double percentualDesmatamentoAnterior = calcularPercentualDesmatamento(matrizAnterior);
    double percentualDesmatamentoAtual = calcularPercentualDesmatamento(matrizAtual);

    double diferenca = percentualDesmatamentoAtual - percentualDesmatamentoAnterior;

    if (diferenca < 0)
    {
      Console.WriteLine($"Houve Redução no Desmatamento – Anterior {percentualDesmatamentoAnterior:F2}% -> Atual {percentualDesmatamentoAtual:F2}%");
    }
    else if (diferenca > 0)
    {
      Console.WriteLine($"Houve Aumento no Desmatamento – Anterior {percentualDesmatamentoAnterior:F2}% -> Atual {percentualDesmatamentoAtual:F2}%");
    }
    else
    {
      Console.WriteLine($"Não Houve Mudanças no Desmatamento – Anterior {percentualDesmatamentoAnterior:F2}% -> Atual {percentualDesmatamentoAtual:F2}%");
    }

  }
  static void Main()
  {
    string caminhoAntigo = "dados_matriz_6meses_atras.csv";
    string caminhoAtual = "dados_matriz_atual.csv";

    int[,] matrizAnterior = Matriz.carregarMatriz(caminhoAntigo);
    int[,] matrizAtual = Matriz.carregarMatriz(caminhoAtual);

    Console.Clear();

    Console.WriteLine("Matriz Antiga: -------------");
    Matriz.mostrarMatriz(matrizAnterior);

    Console.WriteLine("\nMatriz Atual: -------------");
    Matriz.mostrarMatriz(matrizAtual);

    double percentualDesmatamentoAnterior = calcularPercentualDesmatamento(matrizAnterior);
    Console.WriteLine(
      "\nPercentual de ocorrências na matriz 6 meses atrás:\n" +
      $"Área Desmatada (Código 0): {percentualDesmatamentoAnterior:F2}%"
      );

    double percentualDesmatamentoAtual = calcularPercentualDesmatamento(matrizAtual);
    Console.WriteLine(
          "Percentual de ocorrências na matriz atual:\n" +
          $"Área Desmatada (Código 0): {percentualDesmatamentoAtual:F2}%\n"
          );

    analisarAumento(matrizAnterior, matrizAtual);

    Console.ReadKey();




  }
}