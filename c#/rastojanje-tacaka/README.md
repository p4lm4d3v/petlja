# Rastojanje Tačaka

- Napiši program koji izračunava i ispisuje rastojanje između tačaka zadatih svojim koordinatama.

# Ulaz

- Sa standardnog ulaza unose se četiri realna broja, svaki u posebnom redu. Prva dva broja `Ax` i `Ay` predstavljaju koordinate tačke `A=(Ax,Ay)`, dok druga dva broja `Bx` i `By` predstavljaju koordinate tačke `B=(Bx,By)`.

# Izlaz

- Na standardni izlaz ispisati jedan realan broj koji predstavlja rastojanje između tačaka `A`
  i `B`, zaokružen na pet decimala.

# Primeri

- Primer 1

  - Ulaz:
    <br>`1`
    <br>`1`
    <br>`0`
    <br>`0`

  - Izlaz: `1.41421`

- Primer 2

  - Ulaz:
    <br>`4`
    <br>`3`
    <br>`0`
    <br>`0`

  - Izlaz: `5.00000`

- Primer 3

  - Ulaz:
    <br>`18`
    <br>`24`
    <br>`0`
    <br>`0`
  - Izlaz: `30.00000`

# Objašnjenje

- Prvobitno unosimo kordinate tačaka kojima računamo rastojanje. Pošto imamo četiri realna broja koji predstavljaju kordinate četiri puta ponavaljamo istu stvar: čitamo liniju iz konzole i šta pročitamo pretvaramo u tip podataka `double` i tako dobijamo naše četiri promenljive `Ax`, `Ay`, `Bx`, `By`.

- Primenom formule za izračunavanje rastojanja između dve tačke

  Formula

  ```
  rastoranje = √((Bx-Ax)²+(By-Ay)²)
  ```

  Kod (C#)

  ```cs
  double rastojanje = Math.Sqrt(Math.Pow(Bx - Ax) + Math.Pow(By - Ay));
  ```

  možemo vrlo lako i jednostavno samom zamenom brojeva dobiti rastojanje između tačaka koje nas i zanima.

- Kako bi kod bio pregledniji i lakši za razumevanje formulu možemo razdvojiti na delove.
  <br> Prvo možemo izračunati razlike kordinata:

  ```cs
  double razlikaX = Bx - Ax;
  double razlikaY = By - Ay;
  ```

  Potom izračunavamo kvadrate tih razlika:

  ```cs
  double kvadratRazlikeX = razlikaX * razlikaX;
  double kvadratRazlikeY = razlikaX * razlikaX;
  ```

  Na kraju koren zbira tih razlika je rastojanje:

  ```cs
  double rastojanje = Math.Sqrt(kvadratRazlikeX + kvadratRazlikeY);
  ```

- Na kraju kada smo izračunali rastojanje kao što zadatak traži moramo ga ispisati sa pet decimala.
