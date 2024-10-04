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

    // Izračunavamo površinu bazena kao proizvod dužine i širine a i b
    double P = a * b;

    // Izračunavamo zapreminu koju zauzima voda proizvodom površine bazena i litara po kvadratnom metru bazena 
    double zapremina = n * P;
    // Pošto je zapremina u litrima moramo je pretvoriti u metre kubne (m³)
    // 1l = 1dm³
    // 1l = 0.001m³ 
    // 1000l = 1m³
    zapremina /= 1_000;

    // Izračunavamo povišenje nivoa vode u bazenu posle oluje, tako što celokupnu zapreminu delimo sa povrsinom,
    // tj. izdvajamo visinu dodate vode što je naše povišenje vode 
    // Pošto je povišenje u metrima, moramo ga pretvoriti u centimetre kako zadatak nalaže
    // 1m = 100cm 
    double povisenje = zapremina / P * 100;

    // Kako zadatak traži moramo ispisati povisenje formatirano na 2 decimale
    Console.WriteLine("{0:0.00}", povisenje);
    Console.ReadKey();
  }
}