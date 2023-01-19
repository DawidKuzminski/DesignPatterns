<h1>Behavioral design pattern - Visitor</h1>
<h2>Cel</h2>
Odwiedzający to behavioralny wzorzec projektowy pozwalający oddzielić algorytm od obiektów, które na nim pracują.
Na przykład na jego rezultacie.

<h2>Rozwiązanie</h2>
Wzorzec Odwiedzający polega na umieszczeniu nowych obiwiązków, które nie są związane z główną funkcjonalnością klasy w osobnej klasie nazywanej Odwiedzającym - Visitor.
Niestety wymaga on lekkiej modyfikacji istniejącego kodu, a mianowicie należy do danej klasy dodać metodę Accept, która przyjmuje Odwiedzającego oraz wywołuje daną metodę pomocniczą.

![BehavioralDesignPattern-Visitor drawio](https://user-images.githubusercontent.com/17592328/213539304-f8521520-4aad-48f1-8dc8-a7061d664117.svg)

Metoda Visitora ma pełny dostęp do funkcjonalności danego komponentu lub elementu, tak więc jest w stanie wykonać na nim dodatkowe operacje. Jak na przykład wygenerowanie pliku XML.

<h2>Przykład</h2>
Jako przykłąd może posłużyć firma sprzedająca polisy dla mieszkańców miasta oraz przemysłu.
Firma posiada dwa obiekty dla poszczególnych grup. Obiekty te wyliczają w jakiś sposób wysokość policy, czas polisy oraz podobne.
Po pewnym czasie sprzedawcy polis chcieliby, aby wyliczone polisy było można drukowac w formie raportu.

Aby nie łamać zasady pojedyńczej odpowiedzialności klas do wyliczeń polis, można użyć odwiedzającego, 
który wygeneruje dane potrzebne do raportu przy pomocy klasy do obliczeń. 

<h2>Zastosowanie</h2>
- Stosując wzorzec Visitor gdy istnieje potrzeba wykonywania jakiegoś działania na wszyskich elementach złożonej struktury obiektów
Wzorzec Odwiedzający pozwala wykonać jakieś działanie na zestawie obiektów różnych klas dzięki istnieniu obiektu odwiedzającego. On z kolei implementuje wiele wariantów tego działania, odpowiadających poszczególnym klasom docelowym.

- Stosowanie Odwiedzającego pozwala uprzątnąć logikę biznesową czynności pomocniczych.
Wzorzec Odwiedzający daje możliwość ograniczenia zakresu obowiązków głównych klas aplikacji tylko do tych najważniejszych poprzez ekstrakcję wszystkich innych obowiązków do zestawu klas odwiedzających.

- Warto stosować ten wzorzec gdy jakieś zachowanie ma sens tylko w kontekście niektórych klas wchodzących w skład hierarchii klas, ale nie wszystkich.
Możesz wyekstrahować główne obowiązki do osobnej klasy odwiedzający i zaimplementować tylko te metody odwiedzania, które przyjmują obiekty istotnych klas, zaś resztę metod pozostawić pustą.
