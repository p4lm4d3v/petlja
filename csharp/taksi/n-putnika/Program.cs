using System;

public static class Program
{
  public static void Main(string[] args)
  {
    // Unosimo broj putnika u taksiju
    int n = int.Parse(Console.ReadLine());

    // Pravimo niz koji će čuvati cene tj. stanje na taksimetru pri izlasku putnika
    // Popunjavamo ga unosom po linije iz konzole i pretvaranja u realan broj
    double[] cene = new double[n];
    for (int i = 0; i < n; i++)
      cene[i] = double.Parse(Console.ReadLine());

    // Pravimo niz segmenti koji cuva segmente za izračuvanje troška putnika
    double[] segmenti = new double[n];
    // Pre-izračunavamo prvi element radi lakše kasnijeg računanja segmenata
    segmenti[0] = cene[0] / n;
    // Iterativno izračuvanje segmenata po formuli izvedenoj iz jednostavnijih primera 
    for (int i = 1; i < n; i++)
      segmenti[i] = (cene[i] - cene[i - 1]) / (n - i);

    // Pravimo niz koji čuva trošak svakog putnika po naosob
    double[] troskovi = new double[n];
    // Popunjavamo ga iterativno sabiranjem segmenata od početka pa do pozicije na kojoj je putnik
    // sa prethodnom nultom inicijalizacijom zbog starte inicijalizovane vrednosti elemenata niza na "null"
    for (int i = 0; i < n; i++)
    {
      troskovi[i] = 0;
      for (int j = 0; j <= i; j++)
        troskovi[i] += segmenti[j];
    }

    // Kako zadataka nalaže ispisujemo elemente niza troškovi sa formatoiranjem na 2 decimale
    for (int i = 0; i < n; i++)
      Console.WriteLine("{0:0.00}", troskovi[i]);

    Console.ReadKey();
  }
}