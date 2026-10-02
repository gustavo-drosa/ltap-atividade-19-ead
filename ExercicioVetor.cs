using System;
using BibliotecaVetor;

class ExercicioVetor
{

  static double calcularMedia(int[] roubos)
  {
    double soma = 0.0;
    int numBairros = roubos.Length;

    for (int i = 0; i < numBairros; i++)
    {
      soma += roubos[i];
    }

    double media = soma / numBairros;

    return media;
  }

  static void exibirTop3BairrosViolentos(string[] bairros, int[] roubos)
  {
    int[] valores = { roubos[0], roubos[0], roubos[0] };
    int[] indices = { 0, 0, 0 };

    for (int i = 0; i < roubos.Length; i++)
    {
      if (valores[0] < roubos[i])
      {
        valores[2] = valores[1];
        indices[2] = indices[1];
        valores[1] = valores[0];
        indices[1] = indices[0];
        valores[0] = roubos[i];
        indices[0] = i;
      }
      else if (valores[1] < roubos[i])
      {
        valores[2] = valores[1];
        indices[2] = indices[1];
        valores[1] = roubos[i];
        indices[1] = i;
      }
      else if (valores[2] < roubos[i])
      {
        valores[2] = roubos[i];
        indices[2] = i;
      }
    }

    for (int i = 0; i < 3; i++)
    {
      Console.WriteLine($"{i + 1}º Lugar: {bairros[indices[i]]} (Índice {indices[i]}) - {valores[i]} Roubos");
    }

  }

  static void Main()
  {
    String[] bairros = { "Centro", "Moema", "Pinheiros", "Itaquera", "Tatuapé", "Santo Amaro", "Vila Mariana", "Lapa", "Capão Redondo", "Santana" };

    int[] roubos = new int[bairros.Length];

    Vetor.gerarVetor(roubos);

    Console.Clear();

    Vetor.mostrarVetor(roubos);

    Console.WriteLine("\n\n=== ANÁLISE DE SEGURANÇA PÚBLICA - BAIRROS DE SP ===");

    double mediaRoubos = calcularMedia(roubos);
    Console.WriteLine($"Média de Roubos por bairro: {mediaRoubos:F2} ocorrências");

    Console.WriteLine("--- TOP 3 BAIRROS MAIS VIOLENTOS --- ");
    exibirTop3BairrosViolentos(bairros, roubos);

    Console.ReadKey();








  }

}