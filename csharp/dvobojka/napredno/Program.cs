using System;

public static class Program
{
  public static void Main(string[] args)
  {
    // Unosimo broj elemenata niza
    int n = int.Parse(Console.ReadLine()!);
    // Definišemo niz brojeva dužine n
    int[] brojevi = new int[n];

    // Čitamo liniju iz konzole i delimo na niz stringova po karakteru razmaka
    // Učitavamo brojeve parsovanjem svakog elementa 
    // iz niza [brojeviString] i zadavanjem u niz [brojevi]
    brojevi = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    // Definišemo liste u kojima ćemo čuvati parne i neparne brojeve odvojeno
    List<int> parni = new List<int>();
    List<int> neparni = new List<int>();

    // Prolazeći kroz svaki element niza [brojevi]
    // dodajemo element u njegovu listu u odnosu na njegovu parnost
    for (int i = 0; i < n; i++)
      if (brojevi[i] % 2 == 0)
        parni.Add(brojevi[i]);
      else
        neparni.Add(brojevi[i]);

    // Definišemo listu koja će biti naš rezultat
    // Istu listu popunjavamo tako što ćemo u nju
    // prvo dodati parne pa neparne elemente 
    // iz njihovih listi koristeći "spread" operator
    List<int> rezultat = [.. parni, .. neparni];

    // Ispisujemo elemente u istom redu samo razdvojeni razmakom
    Console.WriteLine(string.Join(" ", rezultat));
  }
}

