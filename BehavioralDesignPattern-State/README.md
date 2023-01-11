<h1>Behavioral design pattern - State</h1>
<h2>Cel</h2>
Stan to behavioralny wzorzec projektowy pozwalający na zmianę zachowania obiektu, poprzez zmianę jego wewnętrzengo stanu.
Uzależnia sposób działania obiektu od stanu w jakim aktualnie się znajduję.
Jest on powiazany z koncepcją Automatu skończonego: https://pl.wikipedia.org/wiki/Automat_sko%C5%84czony


<h2>Rozwiązanie</h2>
Wzorzec polega na stworzeniu klas dla każdego ze stanów oraz dodanie warstwy - obiektu przechowującego aktualny stan zwanego kontekstem.

![BehavioralDesignPattern-State drawio](https://user-images.githubusercontent.com/17592328/211864558-b9ebae7b-0224-492a-89d8-49bf6fc090f7.svg)

Klasa kontekstu StateContext przechowuje aktualny stan State _currentContext oraz implementuje wszyskiemetody dostępne przez klasę bazową lub interfejs State.
Głównym zadaniem kontekstu jest przechowywanie stanu, więc implementacja metod zazwyczaj polega na wywołąniu metod danego stanu.

Dane stany w swojej implementacji odpowienio ragują na działanie i w razie potrzeby zmieniają stan, poprzez wywołanie kontekstu i metody ChangeState().

<h2>Przykład</h2>
Przykładem może być implementacja maszyny ATM aka bankomatu. Bankomat można przedstawić jako maszyne stanów, która przechodzi między nimi w zależności od akcji użytkownika.
Na przykład użytkownik, nie może przejść w stan wprowadz PIN, wyciągnij kartę, wypłać pieniądze, jeżeli nie przejdzie przez operację włożenia karty na stanie NoCard.

<h2>Zastosowanie</h2>
- Używany kiedy mamy do czynienia z obiektem, któego zachowanie zależne jest od jego stanu, a liczba możliwych stanów jest znaczna.
- Pozwala poradzić sobie z dużą ilością kodu, który się powtarza w wielu stanach i przejściach między stanami w automatach skończonych.
