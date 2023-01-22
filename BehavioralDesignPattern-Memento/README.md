<h1>Behavioral design pattern - Memento</h1>
<h2>Cel</h2>
Pamiątka to behavioralny wzorzec projektowy, którego zadaniem jest zapisywanie i przywracanie wcześniejszego stanu obiektu bez ujawniania jego implementacji.

<h2>Rozwiązanie</h2>

![BehavioralDesignPattern-Memento drawio](https://user-images.githubusercontent.com/17592328/213932272-0477be86-a5df-44a2-a7b6-97c1a5d62925.svg)

Pamiątka polega na stworzeniu obiektu pamiątki konkretnego obiektu, który implementuje wspólny interfejs, posiadający metody dotyczące pobierania przechowywanych danych.
Obiekt konkretnej pamiątki implementuje wspomniany interfejs oraz przechowuje stan danego obiektu, pola itp. Implementauje się w nim również dodatkowe rzeczy, takie jak chociażby czas utworzenia pamiątki.

Dozorca nadzoruje danym Inicjatorem oraz jego stanem. Dozorca pełni rolę warstwy zarządzania stanem Inicjatora.

<h2>Przykład</h2>
Jako przykład może posłużć jakikolwiek edytor tektu. Posiadają one zapamiętane stany edycji tekstu oraz pozwalają użytkownikowi cofać wykonane czynności.

<h2>Zastosowanie</h2>
- Stosuj wzorzec Pamiątka gdy chcesz tworzyć migawki stanu obiektu i móc przywracać poprzedni jego stan.
- Stosuj ten wzorzec gdy bezpośredni dostęp do pól/getterów/setterów obiektu psuje hermetyzację.
