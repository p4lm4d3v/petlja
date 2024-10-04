using System;

public static class Program
{
  public static void Main(string[] args)
  {
    int n = int.Parse(Console.ReadLine());

    double[] cene = new double[n];
    for (int i = 0; i < n; i++)
      cene[i] = double.Parse(Console.ReadLine());

    double[] segmenti = new double[n];
    segmenti[0] = cene[0] / n;
    for (int i = 1; i < n; i++)
      segmenti[i] = (cene[i] - cene[i - 1]) / (n - i);

    double[] troskovi = new double[n];
    for (int i = 0; i < n; i++)
    {
      troskovi[i] = 0;
      for (int j = 0; j <= i; j++)
        troskovi[i] += segmenti[j];
    }

    for (int i = 0; i < n; i++)
      Console.WriteLine("{0:0.00}", troskovi[i]);

    Console.ReadKey();
  }
}