using System;

public static class Program
{
  struct Tacka
  {
    public double x;
    public double y;

  }
  static double Rastojanje(Tacka A, Tacka B)
  {
    return Math.Sqrt((B.x - A.x) * (B.x - A.x) + (B.y - A.y) * (B.y - A.y));
  }

  static double HeronovObrazac(double a, double b, double c)
  {
    double O = a + b + c;
    double s = O / 2;
    return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
  }

  public static void Main(string[] args)
  {
    // Kreiramo 3 instance strukture "Tacka" čije ćemo polja, x i y
    // popuniti kordinatama tačaka zadatim redosledom, Ax, Ay, Bx...
    Tacka A = new Tacka();
    A.x = double.Parse(Console.ReadLine()!);
    A.y = double.Parse(Console.ReadLine()!);

    Tacka B = new Tacka();
    B.x = double.Parse(Console.ReadLine()!);
    B.y = double.Parse(Console.ReadLine()!);

    Tacka C = new Tacka();
    C.x = double.Parse(Console.ReadLine()!);
    C.y = double.Parse(Console.ReadLine()!);

    // Izračunavamo stranice a, b i c, koje su ustvari rastojanja između parova tačaka A, B i C
    // To uspevamo primenom funkcije "Rastojanje()" koja primenjuje formulu iz zadatke "Rastojanje Tačaka"
    double a = Rastojanje(A, B);
    double b = Rastojanje(A, C);
    double c = Rastojanje(B, C);

    // Površinu izračunavamo Heronovim Obrazcem putem funkcije "HeronovObrazac()"
    double P = HeronovObrazac(a, b, c);

    // Na kraju moramo ispisati površinu sa dozvoljenom greškom 10^-5 tj. formatiranom na pet decimala
    Console.WriteLine("{0:0.00000}", P);

  }
}