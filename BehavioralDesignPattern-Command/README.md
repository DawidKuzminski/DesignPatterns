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

<h2>Przykład</h2>
 
