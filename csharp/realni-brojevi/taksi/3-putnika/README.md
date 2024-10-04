# [Taksi](https://www.petlja.org/sr-Latn-RS/biblioteka/r/Zbirka/taksi)

- U taksi su istovremeno ušla tri putnika, ali su izlazili jedan po jedan. Dogovorili su se da u plaćanju svakog dela vožnje podjednako učestvuju putnici koji su u tom delu vožnje bili u taksiju. Ako se zna stanje na taksimetru u dinarima kada je izašao svako od njih, koliko treba da plati putnik koji je izašao prvi, koliko drugi, a koliko treći?

# Ulaz

Sa standardnog ulaza se učitavaju tri realna broja, u svakom redu po jedan, u sledećem redosledu:
<br> `c1` - stanje na taksimetru u momentu izlaska prvog putnika,
<br> `c2` - stanje na taksimetru u momentu izlaska drugog putnika,
<br> `c3` - stanje na taksimetru u momentu izlaska trećeg putnika.

Pri tome važi `c1 < c2 < c3`.

# Izlaz

Na standardni izlaz ispisati tri realna broja zaokružena na dve decimale (u svakom redu po jedan), koji redom predstavljaju troškove putovanja prvog, drugog i trećeg putnika.

#### Obrazloženje po primeru 1

- Cenu prvog dela vožnje plaćaju sva tri putnika podjednako, tj. za taj deo svaki plaća po 400 dinara.

- Cenu drugog dela vožnje (1500 − 1200 = 300 dinara) dele drugi i treći putnik po pola, tj. po 150 dinara.

- Cenu trećeg dela vožnje (2000 − 1500 = 500 dinara) plaća treći putnik sam.

# Primeri

- Primer 1

  - Ulaz:
    <br> `1200.0`
    <br> `1500.0`
    <br> `2000.0`
  - Izlaz:
    <br> `400.00`
    <br> `550.00`
    <br> `1050.00`

- Primer 2

  - Ulaz:
    <br> `1000.0`
    <br> `1400.0`
    <br> `1800.0`
  - Izlaz:
    <br> `333.33`
    <br> `533.33`
    <br> `933.33`

- Primer 3

  - Ulaz:
    <br> `1200.0`
    <br> `1600.0`
    <br> `2000.0`
  - Izlaz:
    <br> `400.00`
    <br> `600.00`
    <br> `1000.00`

# Objašnjenje

- Prvo unosimo cene koje su bile na taksimetru kada su redom izlazili prvi, drugi i treći putnik. Unosimo ih čitanjem po liniju iz konzole i pretvaramo u realan broj tipa `double` i zapisujemo u promenljive `c1`, `c2`, `c3`.

- Dalje izračunavamo koliko je ko trebao da plati prilikom izlaženja iz taksija.

- Kada je prvi izašao do tada stečenu vrednost na taksimetru sva trojica dele na pola stime prvi putnik plaća jednu trećinu prve cene sa taksimetra.

```cs
double t1 = c1 / 3; // cene koju prvi putnik mora da plati
```

- Kada je drugi izašao morao je da plati jednu trećinu one prve cene koju je platio i prvi i na tu cenu takođe plaća pola cene koja je ostala kada se isplati prva cena na taksimetru. Stime kada se isplati cena `c1` sa taksimetra tj. oduzme od cene `c2`, polovinu te preostale cene zajedno sa jednom trećinom prve cene plaća drugi putnik.

```cs
double t2 = c1 / 3 + (c2 - c1) / 2; // cena koju drugi putnik mora da plati
```

- Kada je treći izašao iz taksija morao je plati ono što je preostalo i što nisu platili putnici pre njega. To znači da treći plaća jednu trećinu prve cene, jednu polovinu ono što ostane od druge cene kada se isplati prva, kao i ceo ostatak cene koji ostane kada se isplati cela druga cena.

```cs
double t3 = c1 / 3 + (c2 - c1) / 2 + (c3 - c2); // cene koju treći putnik mora da plati
```

- Kada se ceo račun sračun i svi su lepo podelili pare, mi taj rezultat moramo ispisati u konzolu formatiran na 2 decimal u 3 konsekutivna reda.
