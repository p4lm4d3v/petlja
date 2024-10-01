# Stoljnjak

Napisati program kojim se izračunava potrebna dužina trake za porub stolnjaka kružnog oblika čija je površina P.

# Ulaz

- U liniji standardnog ulaza se nalazi realna vrednost P.

# Izlaz

- Potrebna dužina trake (realan broj zaokružen na dve decimale).

# Primeri

- Primer 1

  - Ulaz: `7853.982`
  - Izlaz: `314.16`

- Primer 2

  - Ulaz: `31415.9265`
  - Izlaz: `628.32`

- Primer 3

  - Ulaz: `4300.8403`
  - Izlaz: `232.48`

# Objašnjenje

- Prvo unosimo površinu stoljnjaka tako što ćemo pročitati liniju iz konzole i to što pročitamo pretvoriti u realan broj tipa podataka **_double_**. Tu vrednost ćemo zapisati u promenljivu pod imenom **_P_** (površina).

- Dalje ćemo čistom matematikom doći do poluprečnika, tako što ćemo ga izvesti iz formule za površinu kruga.

- Izvođenje:
  <br> <strong><em> P = r² + π </em></strong> (formula za površinu kruga)
  <br> r² + π = P
  <br> r² = P / π
  <br> <strong><em> r = √(P / π) </em></strong> (izvedena formula za poluprečnik)

- Sad možemo da izračunamo ono što nam zadatak traži, a to je obim našeg stoljnjaka, tj. dužina trake kojom ćemo prekriti rub našeg stola što je ista stvar. Uz pomoć formule za obim kruga i poluprečnika koji smo izveli ranije možemo izračunati dužinu trake.

- Na kraju pošto nam zadatak traži da ispišemo obim ispisujemo ga ali u formatu sa dve decimale kako je i rečeno.
