<h1>Strucutral design pattern - Flyweight</h1>
<h2>Cel</h2>

Pyłek to strukturalny wzorzec projektowy, który pozwala zmieścić większą ilość obiektów w danej przestrzeni pamięci RAM poprzez współdzielenie części ich opisu.

<h2>Rozwiązanie</h2>

![StructuralDesignPattern-Flyweight drawio](https://user-images.githubusercontent.com/17592328/214620736-33fb546e-5886-40cd-98d6-4e215b88c91b.svg)

Pyłek jest wzorcem, który warot stosować w sytuacji kiedy nasza aplikacja ma rzeczywiste problemy z pamięcią RAM podczas działania.
Wzorzec polega na stworzeniu fabryki pyłków, która przechowywuje już wykorzystane stany lub obiekty wspólne dla wielu obiektów docelowych. Może to być np model samochodu, a w przypadku gier np. Sprite, któy jest wspólny dla wielu jednostek wrogów.
Sama klasa pyłka przechowuje wspólny stan.

Natępnie klient posługuje się fabryką w celu stworzenia nowego obiektu docelowego.
Metoda kreacyjna fabryki sprawdza czy dany stan obiektu już istnieje, oraz jeżeli istnieje to zwraca referencje do już istniejącego zasobu. W przeciwnym razie wytwarza nowy pyłek i dodaje go do kolekcji, któej zadaniem jest agregowanie pyłków.

<h2>Przykład</h2>

Jako przykład może posłużyć gra komputerowa 2D, w której walczymy z różnymi przeciwnikami. Zakładając, że mamy 3 typy przeciwników: maga, łucznika i rycerza, można zakładać, że sprity w prostej grze będą takie same. Dlatego też zamaist wytwarzać kolejne nowe instancje w pamięci komputera, można wytworzyć taki sprite jako część stanu wspólną oraz za pomocą fabryki pyłków pobierać referencję do danego sprita, z kazdym nowym obiektem aka przeciwnikiem danego rodzaju.

<h2>Zastosowanie</h2>

-  Stosuj wzorzec Pyłek gdy twój program musi pracować z wielką ilością obiektów, które ledwo mieszczą się w dostępnej pamięci RAM.
- aplikacja musi tworzyć wielką ilość podobnych obiektów,
- powyższa sytuacja poważnie obciąża dostępną pamięć RAM urządzenia,
- obiekty zawierają wielokrotnie powtarzające się opisy stanów, dające się wyekstrahować i pozwoli się na współdzielenie ich pomiędzy wieloma obiektami.
