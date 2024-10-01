# [Površina Trougla Datih Temena](https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka/povrsina_trougla_datih_temena)

- Napiši program koji izračunava površinu trougla ako su poznate koordinate njegovih temena.

# Ulaz

- Sa standardnog ulaza unosi se 6 realnih brojeva (svaki u zasebnom redu). Prva dva predstavljaju `x`
  i `y` koordinatu temena `A`, druga dva `x` i `y` koordinatu temena `B` i poslednja dva predstavljaju `x` i `y` koordinatu temena `C`.

# Izlaz

- Potrebna dužina trake (realan broj zaokružen na dve decimale).

# Primeri

- Primer 1

  - Ulaz:
    <br> `0`
    <br> `0`
    <br> `0`
    <br> `1`
    <br> `1`
    <br> `0`
  - Izlaz: `0.50000`

- Primer 2

  - Ulaz:
    <br> `0`
    <br> `6`
    <br> `0`
    <br> `0`
    <br> `6`
    <br> `0`
  - Izlaz: `18.00000`

- Primer 3

  - Ulaz:
    <br> `-3`
    <br> `0`
    <br> `0`
    <br> `4`
    <br> `3`
    <br> `0`
  - Izlaz: `12.00000`

# Objašnjenje

- Prvo unosimo kordinate tačaka `A`, `B` i `C`, tako što ćemo 3 puta učitati po 2 linije iz konzole i pročitano pretvoriti u realan broj tipa podataka `double`.

- Pre nego iskoristimo našu formulu moramo pripremiti obim trougla i tzv. "`poluobim`" trougla kako bi formula funkcionisala. Takođe su nam neophodne stranice tog trougla koje ćemo izračunati koristeći formulu za rastojanje između tačaka primenjenu u zadataku ["Rastojanje Tačaka"](https://github.com/p4lm4d3v/petlja/tree/main/csharp/rastojanje-tacaka). Tu formulu primenjujemo 3 puta kako bi dobili sve 3 stranice `a`, `b` i `c`.

- Dalje ćemo koristeći ["Heronov Obrazac"](https://sh.wikipedia.org/wiki/Heronova_formula), našu formulu, u kojoj koristimo poluobim kako bi došli do krajnjeg rezultata, površine našeg trougla.

- Zadatak nam traži da ispišemo našu površinu sa "`maksimalnom greškom računanja`" jednakom 10^-5, što je ništa drugo do formatiranje broja na 5 decimala.
