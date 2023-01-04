<h1>Creational design pattern - Fabryka Abstrakcyjna</h1>
<h2>Cel</h2>
Fabryka abstrakcyjna jest kreacyjnym wzorcem projektowym, którego celem jest dostareczenie interfejsu do towrzenia różnych obiektów jednego typu dla tej samej rodziny klas. Umożliwia jednemu obiektowi tworzenie róznych, powiązanych ze sobą, reprezentacji podobiektów.

<h2>Rozwiązanie</h2>
Fabryka abstrakcyjna jest rozszerzeniem wzorca kreacyjengo metody wytwórczej. Fabryka jest kontenerem na zbiór metod wytwórczych wytwarzających obiekty z tej samej rodziny.
W celu wytworzenia fabryki abstrakcyjnej należy najpierw określić interfejsy dla podobiektów z tej samej rodziny. Na przykład mając sklep meblowy, można założyć różne style krzeseł, stołów, czy kanap. Pomimo tego najprawdopodobniej można z nich wyciągnąć konkretne interfejsy IChair, ITable, ISofa

![CreationalDesignPattern-AbstractFactoryInterface drawio](https://user-images.githubusercontent.com/17592328/210596686-1468c683-3120-41b5-9426-88071877fb19.svg)

Posiadając wiele interfejsów tej samej rodziny, np Retro oraz Modern można przystąpić do stworzenia interfejsu lub klasy bazowej IFurnitureFactory, który zawiera metody kreacyjne dla wszyskich produktów danej rodziny. Wspomniane metody mogą wyłącznie zwracać abstrakcyjne typy lub interfejsy produktów.

Na koniec należy stworzyć fabryki dla każdej z rodziny produktów. Fabryka dziedziczy lub implementuje wcześniej stworzonego IFurnitureFactory. 

![CreationalDesignPattern-AbstractFactoryFactories drawio](https://user-images.githubusercontent.com/17592328/210599296-cbc08ad5-4659-41dd-a3dd-d25d8c56a52f.svg)

Diagram obrazujący pełną implementację wzorca:

![CreationalDesignPattern-AbstractFactory drawio](https://user-images.githubusercontent.com/17592328/210601419-ab2cdfec-73dc-4605-8fa1-ca67ce43bd15.svg)

<h2>Przykład</h2>
Jako inny przykład można sobie wyobrazić firmę transportową.
Wg. wzorca kreacyjnego fabryki wytwórczej został stworzony schemat, który obrazuje sytuację kiedy trasport dzieli się na morski, lądowy oraz powietrzny.
Firma się rozwija i nadszedł czas, aby wprowadzić różne rodzaje przesyłek: dużą, śrenią oraz małą.
Każdy z rozmiarów przesyłek to implementacja jakiegoś środka transportu, który jest w stanie dany rozmiar przetransportować.

Na przykład dla małej paczki ISmallCargo, transportem z rodziny lądowej moze być np. skuter, dla morskiej: skuter..tyle że wodny, a dla powietrznej: może być to dron.
Podobnie dla średniej może to być kolejno: ciężarówka, statek, samolot, a dla dużej: pociąg, kontenerowiec, samolot transportowy.

Tak więc fabryka abstrakcyjna jest tworzona poprzez dodanie kolejnej warstwy abstrakcji, która grupuje jakąś określoną rodzinę produktów.
