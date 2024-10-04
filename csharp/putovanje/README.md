# [Putovanje](https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka/putovanje)

- Porodica je krenula autom na letovanje. Automobilom treba da pređu `s` kilometara krećući se ravnomernom brzinom od `v` kilometara na sat. Napisati program kojim se određuje za koliko će sati preći put.

# Ulaz

- U prvoj liniji standardnog ulaza se nalazi realna vrednost `v`, a u sledećoj liniji realna vrednost `s` koje redom predstavljaju brzinu izraženu u kilumetrima na sat i planirani pređeni put u kilometrima.

# Izlaz

- Jedan realan broj zaokružen na dve decimale koji predstavlja potrebno vreme u satima.

# Primeri

- Primer 1

  - Ulaz:
    <br> `60`
    <br> `1050`
  - Izlaz: `17.50`

- Primer 2

  - Ulaz:
    <br> `80`
    <br> `1200`
  - Izlaz: `15`

- Primer 3

  - Ulaz:
    <br> `75`
    <br> `900`
  - Izlaz: `12`

# Objašnjenje

- Prvo unosimo potrebne parametre brzinu automobila - `v` i planirani pređeni put `s`, tako što će mo pročitati po liniju iz konzole i pretvoriti u realana broj tipa `double`.

- Iz formule za brzinu: `v = s / t`, izvodimo formulu za vreme, `t = s / v`. Jednostavnom primenom te formule i zamenom vrednosti dobijamo željeni rezultat, vreme vožnje - `t`.

- Kako zadatak nalaže moramo ispisati `t` u konzolu formatiran na 2 decimale.
