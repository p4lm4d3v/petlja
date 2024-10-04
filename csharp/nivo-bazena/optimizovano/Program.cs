using System;

public static class Program
{
  public static void Main(string[] args)
  {
    // Unosimo potrebne parametre

    // n -> litar vode po kvadratnom metru
    double n = double.Parse(Console.ReadLine());
    // a -> dužina bazena
    double a = double.Parse(Console.ReadLine());
    // b -> širina bazena
    double b = double.Parse(Console.ReadLine());
    // c -> dubina bazena
    double c = double.Parse(Console.ReadLine());

    // U standardom radu ovog zadatka mi bismo korisitili sledeću formulu razloženu na delove radi lakšeg rada i pregledsnosti:
    
    // h - povišenje nivoa vode
    // P - površina bazena
    // V - zapremina bazena
    
    // h = (V * 0.001) / P * 100
    // h = (n * P * 0.001) / P * 100
    // h = (n * a * b * 0.001) / (a * b) * 100
    
    // Ali kako vidimo u ovoj formuli se mogu skratiti a i b tj. površina, što će nam dati finalnu formulu
    // Ovim postupkom potpuno zanemarujemo parametre a i b, kao i c koje i onako već nije korišćeno
    
    // h = n * 0.001 * 100 
    // h = n * 0.1 <=> h = n / 10
    double h = n * 0.1;

    // Kako zadatak traži moramo ispisati povisenje formatirano na 2 decimale
    Console.WriteLine("{0:0.00}", h);
    Console.ReadKey();
  }
}