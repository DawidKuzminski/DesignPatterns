<h1>Structural design pattern - Adapter</h1>
<h2>Cel</h2>
Adapter to strukturalny wzorzec projektowy, którego zadaniem jest umożliwienie współpracy dwóm klasom o różnych interfejsach. Adapter przekształca interfejs jednej z klas w interfejs drugiej klasy.

<h2>Rozwiązanie</h2>
Adapter jest swojego rodzaju przejściówką z jednego interfejsu na drugi. Jeżeli w aplikacji posiadamy jakiś wydzielony interfejs, a chcemy użyć biblioteki, zewnętrznej, którą reprezentuje zupełnie inny interfejs, to obiekt adaptera będzie miał za zadanie przetłumaczyć daną funkcjonalność w taki sposób, aby biblioteka zewnętrzna pasowała do wewnętrznie używanego interfejsu.

Adapter to klasa, która implementuje docelowy interfejs. Obiekt adaptera posiada zależności do obiektu, który nie spełnia założeń implementowanego interfejsu. 
W implementowanych metodach z docelowego interfejsu należy przygotować dane, wywołać z nimi obiekt, który nie pasuje do naszego interfejsu, a na koniec sprowadzić rezultat do typu zwracanego przez daną metodę w interfejsie.

![StructuralDesignPattern-Adapter drawio](https://user-images.githubusercontent.com/17592328/211635358-53eefc94-544e-44f5-aefd-5cf60346ccab.svg)

<h2>Przykład</h2>
Jako przykład może posłużyć funkcjonalność generowania faktur. Pierwotnie w aplikacji zostały zaimplementowane generoatory typu Excel oraz World.
Z biegiem czasu klienci poprosili o możliwość generowania faktur, również do typu PDF. Firma postanowiła wykorzystać istniejące rozwiązanie, aczkolwiek nie jest ono zgodne z interfejsem IFileGenerator, używanym w firmie, który posiada metodę Generate. Okazało się, że biblioteka od generatora pliku PDF potrzebuje większej ilości danych wejściowych oraz samo generowanie pliku jest reprezentowane przez metodę GeneratePDF(). W celu ujednolicenie implementacji w aplikacji, należy wytworzyć adapter, który będzie implementował IFileGenerator, a w implementacji metody Generate, należy stworzyć opakowanie dla GeneratePDF z zewnętrznej biblioteki. Generate będzie posiadać implementację, która przygotuje wszelkie dane wejściowe dla GeneratePDF, wywoła tą metodę oraz sprowadzi jej wynik do typu jaki zwraca Generate z IFileGenerate.

<h2>Zastosowanie</h2>
- kiedy interfejs istniejącej klasy nie jest kompatybilny z resztą rozwiązania
- do rozszerzenia istniejącego rozwiązania - jeżeli posiadamy wiele klas, o takim samym interfejsie, a które trzeba rozszerzyć o jakąś funkcjonalność.
