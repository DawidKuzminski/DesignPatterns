<h1>Behavioral design pattern - Mediator</h1>
<h2>Cel</h2>
Mediator to behavioralny wzorzec projektowy, którego zadaniem jest zredukowanie liczby zależności pomiędzy różnymi obiektami. 
Organicza komunikację między obiektami i wymusza na nich komunikację poprzez centralny punkt jakim jest obiekt mediatora.

<h2>Rozwiązanie</h2>
Mediator proponuje rozwiązanie, w którym rolę za komunikację między obiektami przyjmuje jeden obiekt - Mediator. Jego zadaniem jest otrzymywanie informacji oraz odpowiednie ich przekierowanie.

![BehavioralDesignPattern-Mediator drawio](https://user-images.githubusercontent.com/17592328/212114637-9e6fed03-790f-4c9f-acde-deee0fbc531a.svg)

Mediator to klasa, która posiada referencje do wszyskich obiektów, które mogą się przez niego komunikować.
Klasa bazowa komponentów, posiada referencję do Mediatora oraz jest w stanie go ustawić. Mediator za to posiada referencje do wszyskich komponentów.
W momencie wywołania funkcjonalnośći przez komponent, informuje on mediator o akcji. Następnie mediator na podstawie dostarczonych informacji odpowiednio przekierowuje żądanie do warstwy biznesowej.

<h2>Przykład</h2>
Jako przykład może posłużyć wzorzec MVC, w którym kontroler jest mediatorem między widokiem, a warstwą biznesową.

<h2>Zastosowanie</h2>
- Stosowany jeżeli ziana jakiś klas jest trudna z powodu ścisłego sprzęgnięcia z innymi klasami.
- Jeżeli tworoznych jest wiele komponentów, tylko po to, aby użyć ponownie jakieś zachowanie.
