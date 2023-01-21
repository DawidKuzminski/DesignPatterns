<h1>Behavioral design pattern - Iterator</h1>
<h2>Cel</h2>
Iterator to behavioralny wzorzec projektowy umożliwiający sekwnecyjne przechodzenie po elementach kolekcji bez konieczności eksponowania jego formy.
Iterator przydaje się podczas pracy na skomplikowanych kolekcjach na przykład drzewiastych lub jeżeli wiemy, że użytkownik będzie potrzebować zawsze różnych algorytmów przeszukiwania kolekcji.

<h2>Rozwiązanie</h2>

![BehavioralDesignPattern-Iterator drawio](https://user-images.githubusercontent.com/17592328/213869757-dc7e7cd4-7887-455f-8a15-eaeb6408b5a0.svg)


W C# w celu stowrzenia iteratora lub iteratorów należy wytworzyć abstrakcyjną klasę Iterator, która implementuje interfejs IEnumerator oraz klasę IteratorAggregate, która implementuje IEnumerable.
Pierwszy z obiektów służy do tworzenia iteratorów, drugi natomiast jest rozszerzeniem dla agregatu czyli kolekcji.

Iterator posiada metody definiujące poruszanie się po kolekcji. IteratorAggregate jako że implementuje IEnumerable, to jego głównym zadaniem jest wystawienie metody do zwracania Iteratora.

<h2>Przykład</h2>

<h2>Zastosowanie</h2>
