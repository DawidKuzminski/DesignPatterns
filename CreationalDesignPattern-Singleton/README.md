<h1>Kreacyjny wzorzec projektowy - Singleton</h1>

<h2>Cel</h2>
Singleton jest kreacyjnym wzorcem projektowym, którego celem jest ograniczenie tworzenia obiektów danej klasy do jednej instancji oraz zapewnienie globalnego dostepu do stworzonego obiektu. Czasami przystosowuję się jego implementację do przypadku wprowadzenia pewnej maksymalnej ilości obiektów danego typu.
Uważany jest za antywzorzec ze względu, że jego podstawowe założenia - ograniczenie tworzenia obiektów oraz dostęp do wytworzonej instancji - łamią zasadę pojedyńczej odpowiedzialności.

<h2>Rozwiązanie</h2>
Dwa główne etapy wzorca Singleton to:

- Ograniczenie dostępu do domyślnego konstruktora poprzez uczynienie go prywatnym. Uniemożliwi to wytowrzenie nowej instancji poprzez słowo klcuzowe new
- Stworzenie statycznej metody kreacyjnej, która pełni rolę konstruktora obiektu oraz zapewnie warswtę bezpieczeństwa, której zadaniem jest pilnowanie aby np. dwa wątki nie próbowały wytworzyć instancji w tym samym czasie.
<h2>Diagram UML</h2>

![Singleton](../Images/Singleton.drawio.svg)

Przedstawiony diagram pokazuje relację między klientem, a klasą implementującą wzorzec kreacyjny Singleton. Klient wywołuje metodę GetInstance(), która sprawdza czy instancja została już wytoworzona. W razie braku istniejącej instancji jest ona wytwarzana. Na koniec metoda zwraca intancję do klienta.

<h2>Przykład</h2>
Klient posiada serwis, który w trakcie działania korzysta z jednej konfiguracji dla swoich komponentów.

Część aplikacji odpowiedzialna za inicjalizację serwisu, powinna wytworzyć instancję klasy oraz ją zbudować w prefereowany sposób. Na przykład przeczytać dane z konfiguracyjnego pliku json, a następnie zdeserializować go do klasy konfiguracji.

Każda kolejna część serwisu, która będzie chciała się odnieść do konfiguracji pobierze tą samą instancję konfiguracji poprzez Configuration.GetInstance();
