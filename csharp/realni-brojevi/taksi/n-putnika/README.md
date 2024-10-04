# [Taksi](https://www.petlja.org/sr-Latn-RS/biblioteka/r/Zbirka/taksi)

- U taksi su istovremeno ušlo `n` putnika, ali su izlazili jedan po jedan. Dogovorili su se da u plaćanju svakog dela vožnje podjednako učestvuju putnici koji su u tom delu vožnje bili u taksiju. Ako se zna stanje na taksimetru u dinarima kada je izašao svako od njih, koliko treba da plati koji putnik?

# Ulaz

Sa standardnog ulaza se učitavaju celi broj `n` koji predstavlja broj putnika. Potom u `n` broj linija po jedan realan broj koji predstavlja stanje na taksimetru u momentu izlaska n-tog putnika.

Pri tome važi `c1 < c2 < c3...`.

# Izlaz

Na standardni izlaz ispisati n realnih brojeva zaokruženih na dve decimale (u svakom redu po jedan), koji redom predstavljaju troškove putovanja n putnika.

#### Obrazloženje po primeru 1

- Cenu prvog dela vožnje plaćaju sva tri putnika podjednako, tj. za taj deo svaki plaća po 400 dinara.

- Cenu drugog dela vožnje (1500 − 1200 = 300 dinara) dele drugi i treći putnik po pola, tj. po 150 dinara.

- Cenu trećeg dela vožnje (2000 − 1500 = 500 dinara) plaća treći putnik sam.

# Primeri

- Primer 1

  - Ulaz:
    <br> `3`
    <br> `1200.0`
    <br> `1500.0`
    <br> `2000.0`
  - Izlaz:
    <br> `400.00`
    <br> `550.00`
    <br> `1050.00`

- Primer 2

  - Ulaz:
    <br> `10`
    <br> `1`
    <br> `2`
    <br> `3`
    <br> `4`
    <br> `5`
    <br> `6`
    <br> `7`
    <br> `8`
    <br> `9`
    <br> `10`
  - Izlaz:
    <br> `0.10`
    <br> `0.21`
    <br> `0.34`
    <br> `0.48`
    <br> `0.65`
    <br> `0.85`
    <br> `1.10`
    <br> `1.43`
    <br> `1.93`
    <br> `2.93`

- Primer 3

  - Ulaz:
    <br> `10`
    <br> `1`
    <br> `2`
    <br> `4`
    <br> `8`
    <br> `16`
    <br> `32`
    <br> `64`
    <br> `128`
    <br> `512`
    <br> `1024`
  - Izlaz:
    <br> `0.10`
    <br> `0.21`
    <br> `0.46`
    <br> `1.03`
    <br> `2.37`
    <br> `5.57`
    <br> `13.57`
    <br> `34.90`
    <br> `226.90`
    <br> `738.90`

# Objašnjenje

- Prvo unosimo broj `n` koji predstavalja broj putnika u taksiju. Zatim pravimo niz dužine `n` koji će nam držati cene tj. stanja na taksimetru pri izlasku svakog putnika. Potom iteriramo `n` puta čitajući po jednu liniju iz konzole i pretvarajući je u realan broj koji zapisujemo na i-to mesto u nizu.

- Potom pravimo niz `segmenti` koji će nam držati segmentne vrednosti za svaku poziciju niza. Uzevši primer formule za cenu koju plaća treći putnik segmenti su nam sabirci iz te formule:

```cs
double t3 = c1 / 3 + (c2 - c1) / 2 + (c3 - c2); // cene koju treći putnik mora da plati

"c1  / 3"       // prvi segment
"(c2 - c1) / 2" // drugi segment
"(c3 - c2) / 1" // treći segment
```

- Dalje moramo izračunati vrednosti koliko koji putnik treba da plati. Pre toga prvo napravimo niz dužine `n`, `troškovi` koji čuva troškove svakog putnika. Svaki putnik plaća cene od početka puta pa do izlaska iz taksija. Pošto mi imamo segmente spremne za ceo put samo je potrebno da od početne pozicije sa indeksom 0 idemo do pozicije gde je putnik izašao i sabiramo segmente na tim pozicijama i dodajemo ih na poziciju u nizu `troskovi` trenutnog putnika. Pre sabiranja se zadaje vrednost nula na trenutnoj poziciji putnika u nizu `troskovi` pošto je pri inicijalizaciji vrednost `null`, pa ne možemo sabirati sa time.

- Kada se ceo račun sračuna i svi su lepo podelili pare, mi taj rezultat moramo ispisati u konzolu formatiran na 2 decimal u `n` konsekutivnih redova tako što iteriramo kroz niz `troskovi` i ispisujemo vrednost na trenutnoj poziciji u red konzole.
