<h1>Behavioral design pattern - Command</h1>
<h2>Cel</h2>
Łańcuch zobowiązań jest behawioralnym wzorcem projektowym, który pozwala przekazywać żądania wzdłuż łańcucha obiektów obsługujących dane żądanie. 
Kolejne ogniwa w łańcuchu decdują, czy żądanie powinno być kontynuowane, czy przerwane.

<h2>Rozwiązanie</h2>
Wzorzec polega na stworzeniu samodzielnych obiektów, których celem jest możliwość wywoływania kolejnych ogniw. Diagram UML oraz implementacja przypominają nieco wzorzec dekorator.
Zazwyczaj Ogniwa posiadają jedną metodę Handle(requestContext), której zadaniem jest wywołanie logiki biznesowej oraz na podstawie rezultatu zdecydować 
czy dane żądanie może zostać przekazane dalej, czy też powinno zakończyć się jakiegoś rodzaju błędem.

![BehavioralDesignPattern-ChainOfResponsibility drawio](https://user-images.githubusercontent.com/17592328/211206416-0c93f20e-ea0a-42b9-81b1-751a5ec9bca5.svg)

Na początku należy stworzyć wspołny interfejs dla poziomu abstrakcji z metodą Handle() oraz w niektórych przypadkach SetNextHandler, która będzie mówić o następnym ogniwie w łańcuchu.
Aczkolwiek zależy to od implementacji, ponieważ można to również rozwiązać poprzez pole o poziomie dostępu protected oraz konstruktor w klasie bazowej.
Następnie należy stworzyć klasę bazową, która będzie implementować interfejs IHandler. Dodatkowo klasa może posiadać wspomniane pole z inforamcją o następnym ogniwie ustawiane przez konstruktor.
Konkretne ogniwa dziedziczą po HandlerBase i implementują swoje zadanie w metodzie Handle.

Po stronie klienta zostaje stworzony łańcuch, który wowołuje się w głąb, a nastepnie wraca z rezultatem.

var respositoryHandler = new RepositoryHandler(null); //Ostatnie ogniwo, więc kolejne nie jest potrzebne.
var validationHandler = new ValidationHendler(respositoryHandler);
var authorizationHandler = new AuthorizationHandler(validationHandler);

Wywołanie:
authorizationHandler.Handle(requestContext);

<h2>Przykład</h2>
Jako przykład może posłużyć płatna aplikacja, której zadaniem jest zwracanie informacji o tym czy dana reustaracja pasuje do naszych wymagań. Jeżeli reustaracja spełnia nasze wymagania zwracana jest lokalizacja.
Jako, że aplikcja jest płatna to posiada jakiś moduł autoryzacyjny.
Następnie aplikacja waliduje czy istnieje reustaracja pasująca do naszych wymagań.
Na koniec wołany jest serwis, który pobiera lokalizację reustaracji, a następnie ją zwraca.

Chain of Responibility pozwoli na stworzenie scieżki z serwisów/modułów, gdzie każdy z nich reprezentuje dane ogniwo. Każde ogniwo posiada własną odpoweidzialność oraz jest niezależne od pozostałych.
Jeżeli jesteśmy zalogowanym użytkownikiem oraz istnieje odpowiednia dla nas reustaracja, to zostanie nam zwrócona jej lokalizacja.

<h2>Zastosowanie</h2>
- Stosowany jeżeli program ma obsługiwać różne rodzaje żądań na różne sposoby, ale dokładne typy żądań i ich sekwencje nie są wcześniej znane.
Pozwala na połączenie wielu obiektów w łańcuch, w którym każde ogniwo jest odpytywane niezależnie.
- Stosowany kiedy potrzeba uruchomić wiele obiektów w sekwencji.
Pozwala na tworzenie róznych sekwencji oraz dopasowywanie łańcucha w trakcie działania programu.
