using System;

public static class Program
{
  class Tacka
  {
    public double x;
    public double y;

    public Tacka(double x, double y)
    {
      this.x = x;
      this.y = y;
    }

    public double Rastojanje(Tacka tacka)
    {
      return Math.Sqrt(
        Math.Pow(tacka.x - x, 2) +
        Math.Pow(tacka.y - y, 2)
      );
    }
  }

  public static void Main(string[] args)
  {
    double k = double.Parse(Console.ReadLine());
    double n = double.Parse(Console.ReadLine());

    Tacka kordinatniPocetak = new Tacka(0, 0);
    Tacka naXosi = new Tacka(-n / k, 0);
    Tacka naYosi = new Tacka(0, n);

    double a = kordinatniPocetak.Rastojanje(naXosi);
    double b = kordinatniPocetak.Rastojanje(naYosi);
    double c = naXosi.Rastojanje(naYosi);

    double O = a + b + c;
    double s = O / 2;
    double P = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

    Console.WriteLine("{0:0.00}", P);
    Console.WriteLine("{0:0.00}", O);
    Console.ReadKey();
  }
}