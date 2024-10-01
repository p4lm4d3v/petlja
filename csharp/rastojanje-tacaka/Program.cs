using System;

public static class Program
{
  public static void Main(string[] args)
  {
    // Unosimo kordinate tacke A(Ax, Ay)
    double Ax = double.Parse(Console.ReadLine()!);
    double Ay = double.Parse(Console.ReadLine()!);

    // Unosimo kordinate tacke B(Bx, By)
    double Bx = double.Parse(Console.ReadLine()!);
    double By = double.Parse(Console.ReadLine()!);

    // Prateći formulu za rastojanje izmedju dve tačke koja je izvedena iz Pitagorine teoreme
    // d = √((x2-x1)²+(y2-y1)²)

    // Prvo izračunavamo razlike x i y kordinata tačaka A i B
    double razlikaX = Bx - Ax;
    double razlikaY = By - Ay;

    // Dalje izračunavamo kvadrate tih razlika integrisanom funkcijom za stepenovanje
    // Ovo možemo postići i jednostavnim množenjem:
    // kvadratRazlikeX = razlikaX * razlikaX
    // kvadratRazlikeY = razlikaY * razlikaY
    double kvadratRazlikeX = Math.Pow(razlikaX, 2);
    double kvadratRazlikeY = Math.Pow(razlikaY, 2);

    // Na kraju rastojanje izmedju A i B je jednako korenu zbira kvadrata rastojanja kordinata tačaka A i B
    double rastojanje = Math.Sqrt(kvadratRazlikeX + kvadratRazlikeY);

    // Kao što je traženo u zadatku ispisujemo rastojanje formatirano na pet decimala
    Console.WriteLine("{0:0.00000}", rastojanje);
  }
}