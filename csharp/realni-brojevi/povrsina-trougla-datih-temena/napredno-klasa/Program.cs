using System;

public static class Program
{
  class Tacka
  {
    public double x;
    public double y;

    public Tacka(double x, double y)
    {
      this.x = double.Parse(Console.ReadLine()!);
      this.y = double.Parse(Console.ReadLine()!); ;
    }

    public double Rastojanje(Tacka B)
    {
      return Math.Sqrt((B.x - this.x) * (B.x - this.x) + (B.y - this.y) * (B.y - this.y));
    }
  }

  class Trougao
  {
    double a;
    double b;
    double c;

    public Trougao(double a, double b, double c)
    {
      this.a = a;
      this.b = b;
      this.c = c;
    }

    double Povrsina()
    {
      double O = this.a + this.b + this.c;
      double s = O / 2;
      return Math.Sqrt(s * (s - this.a) * (s - this.b) * (s - this.c));
    }
  }

  public static void Main(string[] args)
  {
    // Kreiramo 3 objekta, instanci klase "Tacka"
    // Njihove kordinate su popunjen putem konstruktora klase, koji automatski 
    // čita po 2 linije konzole i pretvara ih u realni broj tipa podataka double
    Tacka A = new Tacka();
    Tacka B = new Tacka();
    Tacka C = new Tacka();

    // Pravimo objekat trougao, instancu klase "Trougao", koja sadrži tri stranice
    // koje izračunavamo pomoću funkcije "Rastojanje()" unutar klase "Tacka"
    Trougao trougao = new Trougao(
      A.Rastojanje(B),
      A.Rastojanje(C),
      B.Rastojanje(C)
    );

    // Površinu izračunavamo Heronovim Obrazcem putem funkcije "Povrina()" koja je deo objekta trougao
    double P = trougao.Povrsina();

    // Na kraju moramo ispisati površinu sa dozvoljenom greškom 10^-5 tj. formatiranom na pet decimala
    Console.WriteLine("{0:0.00000}", P);

  }
}