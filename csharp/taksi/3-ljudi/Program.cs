using System;

public static class Program
{
  public static void Main(string[] args)
  {
    // Unosimo cene na taksimetru kada su redom izlazili prvi, drugi i treći putnik

    // c1 - cena na taksimetru kada je izašao prvi putnik
    double c1 = double.Parse(Console.ReadLine());
    // c2 - cena na taksimetru kada je izašao drugi putnik
    double c2 = double.Parse(Console.ReadLine());
    // c3 - cena na taksimetru kada je izašao treći putnik
    double c3 = double.Parse(Console.ReadLine());

    // Dalje izračunavamo koliko je ko trebao da plati kada je izašao iz taksija

    // Kada je prvi izašao morao je da plati 1/3 od celokupne cene do tada, ostala dvojica plaćaju takođe po 1/3
    double t1 = c1 / 3;
    // Kada je drugi izašao morao je da plati onu 1/3 i još na to od ostalog računa kada se isplati vrednost do prvog izlaza
    // mora da plati 1/2 od toga što je preostalo posle prvog izlaza
    double t2 = c1 / 3 + (c2 - c1) / 2;
    // Treći putnik plaća isto 1/3 od pre prvog izlaza, plaća 1/2 od toga što je preostalo posle prvgo izlaska, 
    // što je podelio sa drugim putnikom, i takođe plaća šta je ostalo od računa pošto je on jedini ostao u taksiju
    double t3 = c1 / 3 + (c2 - c1) / 2 + (c3 - c2);

    // Kako zadatak nalaže moramo ispisati te vrednosti u konzolu formatirane na 2 decimale
    Console.WriteLine("{0:0.00}", t1);
    Console.WriteLine("{0:0.00}", t2);
    Console.WriteLine("{0:0.00}", t3);

    Console.ReadKey();
  }
}