<h1>Creational design pattern - Prototype</h1>
<h2>Cel</h2>
Prototyp to kreacyjny wzorzec projektowy, kóry umożliwia kopiowanie istniejących już obiektów bez towrzenia zależności pomiędzy kodem programu, a klasami obiektów.

<h2>Rozwiązanie</h2>
Wzorzec deleguje proces klonowania obiektom, które mają zostać sklonowane.
Zazwyczaj wykorzystanie wzorca sprowadza się to stworzenia pojedyńczej metody Clone(), której zadaniem jest sklonowanie obiektu.
Można wyróżnić dwa rodzaje klonowanie:
 - klonowanie płytkie - shallow copy
 - klonowanie głębokie - deep copy

Różnica między nimi polega na tym, że klonowanie płytkie kopiuje informacje typu wartościowego, natomiast informacje referencyjne przepisuje - przepisuje tą samą referencje do kopiowanego obiektu.
W pewnych określonych sytuacjach, może to być porządane zachwanie, aczkolwiek najczęściej wykorzystywane jest kopiowanie głębokie.
W tym typie kopiowania inforamcje referencyjne są tworzone na nowo oraz wytwarzana jest ich kopia.

Aby wykonać kopiowanie płytkie w .NET można wykorzsytać metodę dostępną na każdym obiekcie: MemberwiseClone().
Aby wykonać kopiowanie głębokie należy dodatkowo ręcznie wytworzyć nowe obiekty dla inforamcji referencyjnych - przetrzymywanych w obiektach.
Jak można sobie wyobrazić w wypadku złożonych klas i metod może to sprawić spore problemy oraz skomplikować kod.
Dlatego dobrym wyjściem z takiej sytuacji jest użycie serizalizacji do formatu JSON oraz następnie deserializacja do obiektu. 
Dzieki temu zostanie wytworzona pełna kopia obiektu bazowego, wraz ze wszyskimi zależnościami w głąb.

<h2>Przykład</h2>
Jako przykład można sobie wyobrazić prostą grę komputerową typu Diablo, LoL, Anno lub jakiś RPG, gdzie występuje wiele tych samych jednostek.
Jednostka zwana jako wilk najprawdopodobniej będzie miała takie same parametry bazowe dla każdej jednostki, dlatego też można wytworzyć jeden taki obiekt, 
a następnie odpowiednoi go klonować, dzięki czemu będą powstawały nowe niezależne instancje, które będą niezależnie reagować na np. otrzymywane obrażenia.
  
