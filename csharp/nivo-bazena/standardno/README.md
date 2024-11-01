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

- Potom proizvodom širine - `b` i dužine - `a` dobijamo površinu našeg bazena - `P`. Proizvod površine bazena - `P` i `n` nam daje zapreminu - `V` našeg bazena tj. ukupnu količinu vode u bazenu izraženu u litrima.

- Kako bi dalje nastavili moramo pretvoriti zapreminu iz litara u metre kubne (m³):

```
1l = 1dm³, 1dm³ = 0.001m³
1l = 0.001m³
1000l = 1m³
```

- Kako bi dalje izračunali povišenje nivoa vode - `h` u bazenu celokupnu zapreminu - `V` delimo sa površinom bazena - `P`, faktički se može reći da iz trodelne zapremine izdvajemo visinu - `h`, treći deo zapremine. Naš rezultat je sada povišenje nivoa vode, ali u metrima. Kako je `1m = 100cm`, množimo količnik `V` i `P` sa 100, i dobijamo našu finalnu vrednost visine - `h`;

- Na kraju kao što nam zadataka nalaže moramo ispisati visinu u konzolu formatiranu na 2 decimale.
