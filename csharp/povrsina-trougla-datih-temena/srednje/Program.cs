using System;

public static class Program
{
  static double ProcitajBroj()
  {
    return double.Parse(Console.ReadLine()!);
  }

  static double Rastojanje(double Ax, double Ay, double Bx, double By)
  {
    double rastojanje = Math.Sqrt((Bx - Ax) * (Bx - Ax) + (By - Ay) * (By - Ay));
    return rastojanje;
  }

  static double HeronovObrazac(double a, double b, double c)
  {
    double O = a + b + c;
    double s = O / 2;
    return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
  }

  public static void Main(string[] args)
  {
    // Unosimo kordinate tačaka A, B i C pomoću funkcije "ProcitajBroj()"
    double Ax = ProcitajBroj();
    double Ay = ProcitajBroj();

    double Bx = ProcitajBroj();
    double By = ProcitajBroj();

    double Cx = ProcitajBroj();
    double Cy = ProcitajBroj();

    // Izračunavamo stranice a, b i c, koje su ustvari rastojanja između parova tačaka A, B i C
    // To uspevamo primenom funkcije "Rastojanje()" koja primenjuje formulu iz zadatke "Rastojanje Tačaka"
    double a = Rastojanje(Ax, Ay, Bx, By);
    double b = Rastojanje(Ax, Ay, Cx, Cy);
    double c = Rastojanje(Bx, By, Cx, Cy);

    // Površinu izračunavamo Heronovim Obrazcem putem funkcije "HeronovObrazac()"
    double P = HeronovObrazac(a, b, c);

    // Na kraju moramo ispisati površinu sa dozvoljenom greškom 10^-5 tj. formatiranom na pet decimala
    Console.WriteLine("{0:0.00000}", P);
  }
}