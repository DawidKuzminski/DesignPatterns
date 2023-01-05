<h1>Creational design pattern - Builder</h1>
<h2>Cel</h2>
Budowniczy to kreacyjny wzorzec projektowy, który umożliwia tworzenie dużych skomplikowanych obiektów etapami. Moment wytworzenia obiektu jest odroczony do danej,
potrzebnej chwili.
Dzięki temu wzorcowi nie powstają skomplikowane konstruktory z domyślnmi wartościami.

<h2>Rozwiązanie</h2>
Kreacyjny wzorzec projektowy budowniczy polega stworzeniu dodatkowej warstwy abstrakcji, którą są budowniczowie. 
Budowniczowie posiadają w swojej implementacji zbiór metod, których celem jest wytowrzenie produktu. W porównaniu do innych wzorców kreacyjnych,
budowniczy nie jest ograniczony do jednego interfejsu produktu.


![CreationalDesignPattern-Builder drawio](https://user-images.githubusercontent.com/17592328/210840367-32bc40be-6562-411a-8107-5d136720b923.svg)

Wzorzec może zostać rozbudowany o Kierownika <Director>, którego zadaniem jest budowanie obiektów, według określonych z góry wymagań.
Pozwala to na tworzenie obiektów przy pomocy builderów oraz generowanie templatów przy pomocy kierowników.

<h2>Przykład</h2>
Dealer zajmuje się sprzedawaniem samochodów. Każdy z samochodów ma podstawowy zbiór infromacji, z których się składa.
  - Marka
  - Model
  - Wersja
  - Typ nadwozia
  - Silnik
W celu zwiększenia sprzedaży dealer postanowił stworzyc strone internetową, na której klienci będą mogli stworzyć swoje wymarzone auto.
Krok po kroku przechodzą kolejne zakładki z wybraniem marki, modelu, wyposarzenia. Na końcu klikają Zamów.
  
Z punktu wzorca budowniczego cały proces to budowniczy, który posiada zestaw metod, w który ustawia się markę, model, wyposarzenie. 
Przycisk Zamów kończy proces i sprowadza się do wywołania metody Build(), która generuje obiekt, który następnie jest wyświetlany użytkownikowi w formie podsumowania.
  
