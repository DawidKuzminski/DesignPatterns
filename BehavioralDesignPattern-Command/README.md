<h1>Behavioral design pattern - Command</h1>
<h2>Cel</h2>
Polecenie to behavioralny wzorzec projektowy, który zmienia żądanie w samodzielny obiekt zawierający wszyskie informacje o tym żądaniu.
Taka transformacja pozwala na parametryzowanie metod przy użyciu różnych żądań.

<h2>Rozwiązanie</h2>
Wzorzec polecenie polega na stworzeniu klas komend, które opsują zadanie do wykonania oraz dodatkowej warstwy obsługującej te komendy.

![BehavioralDesignPattern-Command drawio](https://user-images.githubusercontent.com/17592328/211167159-b65c3add-0b6b-41c6-b012-f15d76999fae.svg)

Klasa Invoker jest odpowiedzialna za wykonywanie żądań. Posiada ona referencje do poleceń.
Invoker uruchamia polecenia zamiast przesyłać ządania beżpośrednio do odbiorców.

Interfejs ICommand zwykle deklaruje pojedyńczą metodę, służącą do wykonania polecenia.
Konkretne polecenia implementują różne zachowania. Nie powinny one wykonywac pracy, a delegować ją do obiektów logiki biznesowej.
Dodatkowe parametry danego polecenia są implementowane jako pola w danej klasie polecenia.
Klasa Receiver zawiera jakąś logike biznesową, która wykonuje daną czynność. Polecenie służy tylko do wywołania danej logiki biznesowej.
Na poziomie Client'a zostają skonfigurowane konkretne obiekty żądań. Klient musi przesłać wszyskie parametry żądania włącznie z referencjami do odbiorcy.
Następnie dane polecenie można skojarzyć z jednym lub wieloma nadawcami.

Wzorzec bardzo często wykorzystywany jest przy tworzeniu funckjonalności przywracania/powrotu stanu (CTRL+Z).

<h2>Przykład</h2>
Aplikacja posiada funkcjonalności kopiuj oraz wklej. Na początku operacje dostępne są tylko poprzez przyciski, aczkolwiek później okazuje się, że potrzeba zaimplementować te funkcjonalności również dla menu kontesktowego oraz skrótów klawiszowych.

Behawioralny wzorzec projektowy - Polecenie pozwoli na implementację rozwiązania w jednym miejscu, a następnie wywoływanie go z wielu miejsc poprzez komendę.

<h2>Zastosowanie</h2>
- Gdy chcesz parametryzować obiekty za pomocą działań
Wzorzec pozwala przekształcić wywołąnie metody w samodzielny obiekt. Taka zmiana pozwala na przekazywanie poleceń jako argumenty, przechowywać je w innych obiektach, zamieniać powiązane zadania w trakcie działania programu. Np. zachowanie Zapisz co x czasu, Zapisz po każdej zmianie
- Pozwala układać kolejki zadań, ustalać harmonogram ich wykonania, bądz uruchamiać je zdalnie.
Jak każdy inny obiekt Polecenie można serializować, co oznacza przekształcenie go w łańcuch znaków, który można w łatwy i szybki sposób zapisać w bazie danych lub pliku. Dzięki temu można później taki łańcuch znaków deserializować. Idąc dalej można opóźniać wykonanie polecenia, kolejkowac je, lub wysyłać przez sieć.
- Można na nim oprzeć funkcjonalność związaną z operacjami odwracalnymi.
Istnieje wiele sposobów na implementację tego zachwoania, aczkolwiek wzorzec polecenie jest najpopularniejszy.
W celu zaimplementowania rozwiązania, należy stworzyć historię wykonywanych działań. Historia poleceń jest stosem zawierającym wszystkie obiekty wykonanych poleceń wraz ze skojarzonymi z nimi stanami aplikacji. Do zapisywania stanu aplikacji przydaje się wzorzec Pamiątka.
