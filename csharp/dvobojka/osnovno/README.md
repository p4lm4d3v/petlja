# [Dvobojka](https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka2/dvobojka)

- Napiši program koji organizuje elemente niza tako da prvo idu svi parni elementi, a zatim neparni, pri čemu međusobni redosled parnih i neparnih elemenata nije bitan.

# Ulaz

- U prvoj liniji standardnog ulaza uneti prirodan broj n - broj elemenata niza, a u narednoj linija uneti n prirodnih brojevava.

# Izlaz

- Na stanardni izlaz ispisati elemente niza uređene na traženi način, razdvojene sa po jednim razmakom.

# Primeri

- Primer 1

  - Ulaz:
    <br>`10`
    <br>`2 5 3 6 1 8 9 10 11 4`

  - Izlaz: `2 6 8 10 4 5 3 1 9 11`

- Primer 2

  - Ulaz:
    <br>`7`
    <br>`10 20 3 40 5 60 7`

  - Izlaz: `10 20 40 60 3 5 7`

- Primer 3

  - Ulaz:
    <br>`5`
    <br>`7 8 9 2 3`

  - Izlaz:`8 2 7 9 3`

- Primer 4

  - Ulaz:
    <br>`9`
    <br>`15 25 35 45 2 55 65 75 85`

  - Izlaz: `2 15 25 35 45 55 65 75 85`

# Objašnjenje

- Prvo unosimo broj elemenata. Potom definišemo niz prirodnih brojeva.

- Potom čitamo jedan red iz konzole, pročitani string delimo na niz stringova prema karakteru razmaka.

- Parsujući svaki od string elemenata niza, i zadavajući svaki i-ti element na i-tu poziciju u prvobitnom nizu brojeva, pravilno učitavamo sve elemente.

- Definišemo dve liste koje ćemo dalje koristiti kako bi razdvojili parne i neparne brojeve.

- Iteriramo kroz prvobitni niz brojeva i proverom parnosti elementa ga stavljamo ili u listu parnih ili u listu neparnih.

- Definišemo još jednu listu, koja će biti rezultujuća lista, tj. rešenje našeg zadatka.

- Iteriramo kroz listu parnih, pa potom kroz listu neparnih sve vreme dodavajući elemente listi u rezultujuću listu. Prvo dodajemo parne pa neparne, u dva odvojena iteraciona kruga.

- Na kraju iteracijom kroz rezultujući niz ispisujemo brojeve u jednom redu konzole sa jednim razmakom posle svakog elementa.
