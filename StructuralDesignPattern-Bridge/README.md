<h1>Structural design pattern - Bridge</h1>
<h2>Cel</h2>
Most to strukturalny wzorzec projektowy, którego celem jest rozdzielenie dużej klasy lub zestawu spokrewnoinych klas na dwie hierarchie - abstrakcję oraz implementację.

<h2>Rozwiązanie</h2>
Pojęcie Abstrakcji oznacza jakąś część aplikacji - klasę, która odpowiada za jakąś abstrakcję sterowania. To znaczy udostępnia jakiś interfejs, który wykonuje jakąś określoną pracę na warstwie implementacji.
Implementacja oznacza obiekty, które są odpowiedzialną za jakąś konkretną czynność.

![StructuralDesignPattern-Bridge drawio](https://user-images.githubusercontent.com/17592328/212389575-a144ee43-dbe1-4543-91f5-2e1bf1ddc6f5.svg)

<h2>Przykład</h2>
Jako przykad moze posłużyć pilot - RemoteControl oraz telewizor - TV.
TV to część implementacji, która wykonuje konkretne czynności.
Pilot natomiast to część abstakcji, musi on na przykład sprawdzić połączenie, zanim wyślę jakieś żądanie do TV.

Innym przykadem może być klasa abstrakcyjna Figura.
Możemy dodać wiele figur, ale w momencie dodania np. jakiegoś konkretnego koloru figury, ilość klas zaczyna się bardzo szybko mnożyć.
Dlatego też należy wdrożyć Most, którego zadaniem będzie wyekstrahować Kolor do osobnej klasy implementacji.
Tak samo jak Pilot zna swój telewizor, ale nie jest telewizorem, więc nie powinen posiadać implementacji wpływającej bezpośrednio na telewizor.

<h2>Zastosowanie</h2>
- Kiedy chce się rozdzielić monolityczną klasę posiadającą wiele wariantów takiej samej funkcjonalnośći.
- Kiedy chce się rozszerzyć klasę na kilka niezależnych płaszczyzn.
- Most pozwala spełnić wymóg możliwosci wyboru implementacji w trakcie działania programu.
