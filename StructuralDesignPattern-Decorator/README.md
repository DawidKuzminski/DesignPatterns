<h1>Structural design pattern - Decorator</h1>
<h2>Cel</h2>
Dekorator to strukturalny wzorzec projektowy, którego zadaniem jest umożliwienie rozszerzenia zachwowania istniejących już funkcjonalności poprzez opakowanie ich w specjalnych obiektach -> dekoratorach.

<h2>Rozwiązanie</h2>
Kiedy w czasie życia aplikacji dochodzi do sytuacji, kiedy należy rozszerzyć jakąś funkcjonalność lub jej część, pierwsze co przychodzi to stworzenie klasy bazowej,
po której nowa roższeżona funkcjonalność będzie dziedziczyć. Nie jest to jednak zawsze dobry pomysł ponieważ:
- Dziedziczenie jest statyczne, nie da się poprzez nie zmienić zachowania obiektu, w trakcie działania aplikacji. Można tylko zastąpić cały obiekt innym, bazującym na klasie bazowej.
- W więkoszści języków obiektowych podklasy mogą posiadać tylko jednego rodzica.

Sposobem na uniknięcie ograniczeń dziedziczenia jest wykorzystanie mechanizmów Agregacji lub kompozycji.
Agregacja: obiekt A zawiera obiekty B; B może istnieć bez A.
Kompozycja: obiekt A składa się z obiektów B; A zarządza cyklem życia B; B nie może istnieć samodzielnie.

Dzięki tym sposobom można rozszerzyć zachowanie obiektu, z którym istnieje połączenie na inne, zmieniając jednocześnie zachowanie kontenera w trakcie działania programu.
![StructuralDesignPattern-Decorator drawio](https://user-images.githubusercontent.com/17592328/211163326-c7fa82c1-d3ba-410c-8b20-3b712173b75d.svg)


Dynamiczne rozszerzenie lub zmiana zachowania jest możliwa dzięki temu, że główna klasa Dekoratora - DecoratorBase - implementuje lub dziedziczy po tym samym interfejsie/klasie bazowej
co obiekt, który chcemy rozszerzyć/zmienić - AlreadyExistingNotification. Dlatego z punktu widzenia klienta abstrakcja, na której pracuje pozostała bez zmian. 
Konkretne dekoratory dziedziczące po DecoratorBase w konstruktorze przyjmują referencję obiektu który został już wytowrzony, a który implementuje interfejs, który jest implementowany również przez DecoratorBase.
Następnie w przesłonieniu metody, którą chcemy rozszerzyć lub zmienić implementujemy swoje rozwiązanie oraz wykorzysujemy metodę którą chcemy rozszerzyć w odpowiednim miejscu.
Możemy również zrezygnować z wykrozystania z metody obiektu, który przyszedł w konstruktorze. Wtedy funkcjonalność zostanie w pełni zastąpiona.

<h2>Przykład</h2>
Firma posiada system informowania użytkowników o wydażeniach i promocjach poprzez wiadomość email. Wraz z zwiększeniem się liczby klientów, firma chce umożliwić im śledzenia nowości poprzez większą ilość komunikatorów. Postanowaiła dodać Messengera, SMS oraz czat na Discord.
Firma posiada rozwiązanie oparte o dobre praktyki programownia, tak więc główna klasa powiadamiania przez email implementuje interfejs INotification. 
Dzięki temu, można w łatwy sposób dopisać lub rozszerzyć funkcjonalność aktualnego rozwiązania dzięki wzorcowi dekorator.
Dzięki oparciu kodu klienta o abstrakcję, możona ją w szybko podmienić, bez potrzeby przeładowania zestawu klienta.
  
