<h1>Behavioral design pattern - Observer</h1>
<h2>Cel</h2>
Obserwator to behawioralny wzorzec projrktowy, który pozwala obiektom powiadamiać inne obiekty o zmianach swojego stanu.

<h2>Rozwiązanie</h2>
Obserwator polega na stworzeniu obserwatorów oraz źródła, które jest obserwowane. Nazywane dalej publisherem.
Kiedy stan publishera się zmienia, wszyscy jego obserwatorzy otrzymują inforamcję o zmianie jego stanu oraz odpowiednio reagują.

![BehavioralDesignPattern-Observer drawio](https://user-images.githubusercontent.com/17592328/214344364-2df3d2d5-5307-4c5d-b74d-da9f5cb1e9c3.svg)

Obserwatorzy decydują czy chcą być informowani o zmianie stanu publishera.

<h2>Przykład</h2>
Jako przykład można obrać to w jaki sposób działa subskrybcja jakiegoś miesięcznika. 
Obserwator decyduje czy chce otrzymywać daną gazetę i w każdej chwili może się wypisać z jej otrzymywania.
Każdego miesiąca Publisher wysyła gazety do osób, które posiada na swojej liście obserwujących.

<h2>Zastosowanie</h2>

- Stosuj wzorzec Obserwator gdy zmiany stanu jednego obiektu mogą wymagać zmiany w innych obiektach, a konkretny zestaw obiektów nie jest zawczasu znany lub ulega zmianom dynamicznie.
- Stosuj ten wzorzec gdy jakieś obiekty w twojej aplikacji muszą obserwować inne, ale tylko przez jakiś czas lub w niektórych przypadkach.
