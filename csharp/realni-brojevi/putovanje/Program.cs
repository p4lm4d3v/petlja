using System;

public static class Program
{
  public static void Main(string[] args)
  {
    // Unosimo brzinu u kilometrima po satu (km/h) i predjeni put u kilometrima (km)
    double v = double.Parse(Console.ReadLine());
    double s = double.Parse(Console.ReadLine());

    // Iz formule za brzinu: v = s / t, izvodimo formulu za vreme, t = s / v
    // Jednostavnom primenom te formule i zamenom vrednosti dobijamo željeni rezultat
    double t = s / v;

    // Kako zadatak nalaže ispisujemo t u konzolu formatiran na 2 decimale
    Console.WriteLine("{0:0.00}", t);
    Console.ReadKey();
  }
}