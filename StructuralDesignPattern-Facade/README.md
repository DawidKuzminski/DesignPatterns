<h1>Structural design pattern - Facade</h1>
<h2>Cel</h2>
Fasada to strukturalny wzorzec projektowy, którego zdaniem jest stworzenie uproszczonego interfejsu dla złożonej logiki klas. 

<h2>Rozwiązanie</h2>
Zewnętrzne zależnosci bardzo często potrzebują zaawansowanej logiki, aby wykonać jakieś działanie. Może to wymagać na przykład wywołania 3 metod, 
gdzie zadaniem dwóch pierwszych jest przygotowanie danych, a ostania wykonuje jakąś pracę i zwraca jej rezultat.
W celu nie mieszania implementacji biblioteki z naszym kodem biznesowym można zastosować fasadę, tak więc warstwę pośrednią, której zadaniem jest uproszczenie logiki biblioteki z punktu widzenia klienta.
Tak więc fasada będzie agregować wsyztkie wymagane obiekty z biblioteki, wykonywać wszytkie trzy operacje oraz zwracać wynik.

<h2>Przykład</h2>
Jako przykład może posłużyć aplikacja do deserialziacji skomplikowanego pliku json do obiektu. Aby zbudować obiekt należy zawołać dwie meotdy, z których po id projektu wyciągane są kolejno dane o projekcie oraz inforamcje o stronach znajdujących się w projekcie.
Do obu należy przesłać referencje obiektu docelowego, do którego dane mają się dopisać.

![StructuralDesignPattern-Facade drawio](https://user-images.githubusercontent.com/17592328/212749329-7a2f5907-d440-400f-8c63-a82ff814f8ef.svg)

Tak więc w podejściu bez fasady, programista będzie zmuszony do wytworzenia zmiennej przechowyującej referencje obiektu głownego.
Następnie będzie musiał zawołać dwie metody, najpierw pierwszą, wyciagjącą informacje o projekcie, a następnie o stronach danego projektu.
Kod ten będzie zmieszany z implementacją serwisu, którego zadaniem jest zwrócenie obiektu. Dodatkowo dojdzie implementacja związana z bezpieczeństwem aplikacji, logowaniem stanu aplikacji oraz przechywaniem wyjątków z biblioteki.

W taki sposób kod naszego serwisu, który być może również sprawdza czy użytkownik ma dostęp do źródła pliku json zostanie wymieszany, a dana metoda zacznie odpowiadać za wiele złożonych akcji.
Z pomocą przychodzi fasada, która może zagregować bibliotekę lub serwis do generowania obiektu z pliku json. Wytowrzenie referencji, wywołanie metod oraz cała otoczka logowania i bezpieczeństwa moze zostać przeniesiona na barki Fasady, co za tym idzie - serwis staje się czytelniejszy, a kod łatwiejszy w analizie i rozszerzeniu.

<h2>Zastosowanie</h2>
- Kiedy potrzebny jest ograniczony, łatwy w obsłudze inteerfejs.
- W razie potrzeby ustrukturyzowania podsystemów w warstwy.
