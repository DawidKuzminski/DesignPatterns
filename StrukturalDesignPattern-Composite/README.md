<h1>Structural design pattern - Composite</h1>
<h2>Cel</h2>
Kompozyt to strukturalny wzorzec projektowy pozwalający komponować obiekty w struktury drzewiaste, a następnie traktowac te struktury jakby były osobnymi obiektami.
Stosowanie tego wzorca ma sens tylko w przypadku, gdy stosowany model można przestawić w formie drzewa.

<h2>Rozwiązanie</h2>

![StructuralDesignPattern-Composite drawio](https://user-images.githubusercontent.com/17592328/214888249-a3d28ee5-966e-425b-ab57-95aebba9f060.svg)

Kompozyt polega na stworzeniu wspólnego interfejsu dla liścia oraz kompozytu.
Kompozyt to kompoennty, które mogą przechwywać w sobie inne kompozyty oraz liście.
Liście reprezentują koniec zbioru więc, punkt, który jest komponentem, ale nie posiada dzieci.

<h2>Przykład</h2>
Jako przykład może posłużyć firma, której zadaniem jest pakowanie towarów w kartony.
W duży karton, który reprezentuje kompozyt może wejść kolejny karton, również kompozyt. 
Mogą one mieć w sobie również niezależnie produktu, które reprezentują liście.

<h2>Zastosowanie</h2>

- Stosuj wzorzec Kompozyt gdy musisz zaimplementować drzewiastą strukturę obiektów.
- Stosuj ten wzorzec gdy chcesz, aby kod kliencki traktował zarówno proste, jak i złożone elementy jednakowo.
