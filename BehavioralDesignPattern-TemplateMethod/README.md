<h1>Behavioral design pattern - Template Method</h1>
<h2>Cel</h2>
Metoda szblonowa to behavioralny  wzorzec projektowy definiujący szkielet algorytmu w klasie bazowej, ale pozwalający podklasom nadpisać pewnie etapy tego algorytmu bez koniecznosci zmiany jego struktury.

<h2>Rozwiązanie</h2>
Metoda szablonowa polega na stworzeniu klasy abstrakcyjnej wraz z publiczną metoda wykonująca jakieś działanie.
Ponadto klasa ta posiada również zbiór metod dostępnych tylko dla podtypów. Metody te są kolejnymi krokami algorytmu.
W zależności od potrzeb są one nadpisywane w podklasach

![BehavioralDesignPattern-TemplateMethod drawio](https://user-images.githubusercontent.com/17592328/212972119-92e1e409-946c-42ad-8b69-8d0c7b4c9ab8.svg)

<h2>Przykład</h2>
Jako przykład może posłużyć funkcjonalność, której zadaniem jest wytowrzenie pliku z raportem pewnych danych.
W celu przygotowaniu takiego pliku użytkownik musi:
- pobrać dane
- odpowiednio przetworzyć dane
- wygenerować raport
- oraz wytworzyć plik

W zależności od typu pliku klient musi wykonać róże działania, aczkowliek algorytm dla wszystkich formatów jest taki sam, tak więc można tutaj wykorzystać metodę szablonową, która posiada jakieś
bazowe rozwiązanie. Podklasy danych foramtów są rozszerzane przez klasę bazową oraz nadpisują kroki, które posiadają taki sam rezultat, ale dochodzą do niego w różny sposób.

<h2>Zastosowanie</h2>
- Stosowany kiedy klient ma mieć możliwość rozszerzenia niektórych części algorytmu
- Kiedy posiadamy wiele klas, które posiadają podobny algorytm, różniący się tylko jakimiś szczegółami
