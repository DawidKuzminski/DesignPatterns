<h1>Structural design pattern - Proxy</h1>
<h2>Cel</h2>
Pełnomocnik to strukturalny wzorzec projektowy, któego celem jest stworzenie obiektu zastępczego w miejsce innego obiektu.
Zadaniem Pełnomocnika jest kontrola dostępu do pierwotnego obiektu umożliwiając mu wykonanie czynności przed lub po wywołaniu metody ze wspomnianego obiektu.

<h2>Rozwiązanie</h2>
Pełnomocnik zakłada stwrzenie klasy pośredniczącej w komuniakcji z obiektem docelowym. Pełnomocnik implementuje ten sam interfejs co pierwotny obiekt.
Następnie należy zaktualizować główny program tak by korzystał z pełnomocnika. Przy aplikacji, która oparta jest od Dependency Injection, będzie to podmiana klasy w inicjalizacji serwisów itp.
Pełnomocnik po otrzymaniu żądania od warstwy klienta wykonuje porządaną logikę, określając czas, kiedy pierwotny obiekt ma zostac zainicjalizowany oraz użyty.

![StructuralDesignPattern-Proxy drawio](https://user-images.githubusercontent.com/17592328/211599165-aa7d6ad2-8fe4-4341-bd00-abaf0f2a8ebc.svg)

<h2>Przykład</h2>
Jako przykład można podać serwis do pobierania danych, na przykłąd video z bazy danych. 
Filmy potrafią posiadać znaczą wielkość, więc pobieranie filmów, z każdym kliknięciem Pobierz mogłoby być długotrwałe, szczególnie, jeżeli użytkownik chciałby pobrać film ponownie z jakiegoś powodu.
Dzięki pełnomocnikowi możliwe jest zasąpienie pierwotnego obiektu warstwą pośrednią, a następnie dopisanie na przykład funkcjonalnośći cachującej, która by w podanym przykładzie wysłała do użytkownika film przechowywany w cache aplikacji.

<h2>Zastosowanie</h2>
- Leniwa inicjalizacja 
Zamiast tworzyć duze skomplikowane obiekty podczas uruchamiania aplikacji, można odroczyć ten czas do momentu kiedy obiekt faktycznie będzie potrzebny.
- Kontrola dostępu - Przydatne kiedy chce się pozwolić tylko niektórym klientom na korzystanie z obiektu usłygi.
Pełnomocnik przekaże żądanie do usługi tylko jeżeli klient przedstawi odpowienie poświadczenia.
- Lokalne uruchamianie zdalnej usługi - gdy obiekt usługi znajduje się na zdalnym serwerze.
Pełnomocnik bierze na siebie odpowiedzialność związaną z komunikacją po sieci.
- Prowadzenie dziennika żądań - Pełnomocnik może być obiektem, który przechowuje historię komunikacji do usługi.
- Przechowaywanie w pamięci podręcznej - cachowanie często używanych zasobów w pamięci w celu odciążenia sieci.
- Sprytne referencje - pełnomocnik może kontrolować ilość referencji do usługi oraz likwidować zasoby usługi, jeżeli ta nie jest używana.
