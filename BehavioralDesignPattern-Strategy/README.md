<h1>Behavioral design pattern - Strategy</h1>
<h2>Cel</h2>
Strategia to behavioralny wzorzec projektowy, którego celem jest zdefiniowanie rodziny algorytmów, które są wymienne względem obiektu, który wykonuje działania na abstrakcji danej rodziny.

<h2>Rozwiązanie</h2>
Wzorzec polega na określeniu wspólnego interfejsu dla rodziny algorytmów.
Następnie interfejs jest wstrzykiwany do obiektu, który działa na rodzinie strategii. 
Pozwala to na dynamiczne zmienianie algorytmu w trakcie działania programu.
Ponad to obiekt działąjacy na algorytmie nie wie jaki dokładnie algorytm został wybrany.
Za wybranie algorytmu odpowiada klient, który wstrzykuje algorytm poprzez konstruktor lub publiczny setter właściwości.

![BehavioralDesignPattern-Strategy drawio](https://user-images.githubusercontent.com/17592328/212481333-28acbe04-cc9c-4c83-a694-b03199907bc0.svg)

<h2>Przykład</h2>
Jako przykład może posłużyć aplikacja do wyznaczania trasy, taka jak Google Maps.
Aplikacja wybiera algorytm wyliczania scieżki w zależności od opcji jaką użytkownik wybierze w interfejsie graficzym użytkownika.
Tak więc to klient -> zlecający działanie wybiera algorytm, który jest wstrzykiwany do obiektu, który zajmuje stworzeniem trasy.

<h2>Zastosowanie</h2>
- Kiedy istnieje potrzeba korzystania z róznych wariantów jednego algorytmu w obrębie obiektu i zyskać możliwość zmiany algorytmu w trakcie działania programu.
- Warto z niego korzystać kiedy w programi istnieje wiele podobnych klas, różniących się jedynie sposobem wykonywania jakiś zadań.
- Strategia pozwala odizolować logikę biznesową klasy od szczegółów implementacyjnych.
