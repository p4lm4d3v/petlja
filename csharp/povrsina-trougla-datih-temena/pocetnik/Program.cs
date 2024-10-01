using System;

public static class Program
{
  public static void Main(string[] args)
  {
    // Unosimo kordinate prve tačke, A
    double Ax = double.Parse(Console.ReadLine()!);
    double Ay = double.Parse(Console.ReadLine()!);

    // Unosimo kordinate druge tačke, B
    double Bx = double.Parse(Console.ReadLine()!);
    double By = double.Parse(Console.ReadLine()!);

    // Unosimo kordinate treće tačke, C
    double Cx = double.Parse(Console.ReadLine()!);
    double Cy = double.Parse(Console.ReadLine()!);

    // Koristeći formulu kao u zadatku izracunavamo stranice trgoula

    // Stranica a je rastojanje između tačaka B i C
    double a = Math.Sqrt((Bx - Cx) * (Bx - Cx) + (By - Cy) * (By - Cy));
    // Stranica b je rastojanje između tačaka A i C 
    double b = Math.Sqrt((Cx - Ax) * (Cx - Ax) + (Cy - Ay) * (Cy - Ay));
    // Stranica c je rastojanje između tačaka A i B 
    double c = Math.Sqrt((Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By));

    // Kako bi izračunali koristićemo formulu pod nazivom "Heronov Obrazac"

    // Heronov obrazac zahteva da prvo izračunamo obim trougla
    double O = a + b + c;
    // Pa onda i takozvani "poluobim", polovinu obima trougla
    double s = O / 2;

    // Uz pomoc poluobima možemo izračunati površinu našeg trougla 
    double P = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

    // Na kraju moramo ispisati površinu sa dozvoljenom greškom 10^-5 tj. formatiranom na pet decimala
    Console.WriteLine("{0:0.00000}", P);
  }
}