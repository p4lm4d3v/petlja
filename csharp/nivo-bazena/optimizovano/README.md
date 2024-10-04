# [Nivo Bazena](https://petlja.org/sr-Latn-RS/biblioteka/r/problemi/Zbirka-stara/nivo_bazena)

- Tokom oluje palo je n litara vode po kvadratnom metru. Napisati program kojim se određuje za koliko centimetara se podigao nivo vode u otvorenom bazenu datih dimenzija, ako znamo da se voda nije prelila preko bazena.

# Ulaz

- U prvoj liniji standarndog ulaza nalazi se realan broj `n` koji predstavlja količinu kiše koja je pala po kvadratnom metru izraženu u litrima. U sledeće tri linije nalaze se realni brojevi `a`, `b`, `c` koji predstavljaju dimenzije bazena izražene u metrima i to redom dužinu, širinu i dubinu.

# Izlaz

- Na standarnom izlazu prikazati jedan realan broj na dve decimale koji predstavlja za koliko centimetara se podigao nivo vode u bazenu.

# Primeri

- Primer 1

  - Ulaz:
    <br> `75.5`
    <br> `4`
    <br> `7`
    <br> `1.7`
  - Izlaz: `7.55`

- Primer 2

  - Ulaz:
    <br> `50.0`
    <br> `5`
    <br> `5`
    <br> `2.0`
  - Izlaz: `5.00`

- Primer 3

  - Ulaz:
    <br> `150.0`
    <br> `6`
    <br> `8`
    <br> `2.5`
  - Izlaz: `15.00`

# Objašnjenje

- Prvo unosimo parametre:
  <br> `n` - litara vode po metru kvadratnom (m²),
  <br> `a` - dužina bazena u metrima kvadratnim (m²),
  <br> `b` - širina bazena u metrima kvadratnim (m²),
  <br> `c` - dubina bazena u metrima kvadratnim (m²),
  <br> tako što ćemo za svaki od parametara pročitati po jednu liniju iz konzole i pretvoriti je u realan broj tipa `double`.

- U standardom radu ovog zadatka mi bismo korisitili sledeću formulu razloženu na delove radi lakšeg rada i pregledsnosti:

```
h - povišenje nivoa vode
P - površina bazena
V - zapremina bazena
```

```
h = (V * 0.001) / P * 100
h = (n * P * 0.001) / P * 100
h = (n * a * b * 0.001) / (a * b) * 100
```

- Ali kako vidimo u ovoj formuli se mogu skratiti `a` i `b` tj. površina - `P`, što će nam dati finalnu formulu.

- Ovim postupkom potpuno zanemarujemo parametre `a` i `b`, kao i `c` koje i onako već nije korišćeno.

```
h = n _ 0.001 _ 100
h = n \* 0.1 <=> h = n / 10
```

- Jednostavnom primenom ove novonastale i pojednostavljenje formule samim deljenjem `n` sa 10 dobijamo naš finalni rezultat `h`.

- Na kraju kao što nam zadataka nalaže moramo ispisati `h` u konzolu formatiran na 2 decimale.
