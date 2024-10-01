using System;

public static class Program
{


  public static void Main(string[] args)
  {
    // Unosimo povrsinu stoljnjaka kao realana broj
    double P = double.Parse(Console.ReadLine());

    // Iz formule za povrsinu stoljnjaka -> P = r²π
    // izdvajamo poluprecnik -> r = √(P/π)
    double r = Math.Sqrt(P / Math.PI);

    // Izracunamo obim kruga formulom (O = 2rπ)
    double O = 2 * r * Math.PI;

    // Ispisujemo izracunati obim formatiran na 2 decimale
    Console.WriteLine("{0:0.00}", O);
  }
}
