<h1>Creational design pattern - Singleton</h1>

<h2>Cel</h2>
Singleton jest kreacyjnym wzorcem projektowym, którego celem jest ograniczenie tworzenia obiektów danej klasy do jednej instancji oraz zapewnienie globalnego dostepu do stworzonego obiektu. Czasami przystosowuję się jego implementację do przypadku wprowadzenia pewnej maksymalnej ilości obiektów danego typu.
Uważany jest za antywzorzec ze względu, że jego podstawowe założenia - ograniczenie tworzenia obiektów oraz dostęp do wytworzonej instancji - łamią zasadę pojedyńczej odpowiedzialności.

<h2>Rozwiązanie</h2>
Dwa główne etapy wzorca Singleton to:

- Ograniczenie dostępu do domyślnego konstruktora poprzez uczynienie go prywatnym. Uniemożliwi to wytowrzenie nowej instancji poprzez słowo klcuzowe new
- Stworzenie statycznej metody kreacyjnej, która pełni rolę konstruktora obiektu oraz zapewnie warswtę bezpieczeństwa, której zadaniem jest pilnowanie aby np. dwa wątki nie próbowały wytworzyć instancji w tym samym czasie.

<h2>Struktura</h2>
![Singleton-uml drawio](https://user-images.githubusercontent.com/17592328/200942295-cd5341ae-c8a8-4b46-afec-b18273a16abe.svg)
