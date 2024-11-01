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
    string[] brojeviString = Console.ReadLine()!.Split(' ');
    // Učitavamo brojeve parsovanjem svakog elementa 
    // iz niza [brojeviString] i zadavanjem u niz [brojevi]
    for (int i = 0; i < n; i++)
      brojevi[i] = int.Parse(brojeviString[i]);

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
    List<int> rezultat = new List<int>();
    // Istu listu popunjavamo tako što ćemo u nju
    // prvo dodati parne pa neparne elemente
    for (int i = 0; i < parni.Count; i++)
      rezultat.Add(parni[i]);
    for (int i = 0; i < neparni.Count; i++)
      rezultat.Add(neparni[i]);

    // Ispisujemo elemente u istom redu samo razdvojeni razmakom
    for (int i = 0; i < n; i++)
      Console.Write(rezultat[i] + " ");
  }
}

