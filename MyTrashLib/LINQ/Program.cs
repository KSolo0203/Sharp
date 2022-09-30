// LINQ это способ обрабатывать массивы и List, Set, Dictionary, ...
// Language Integrated Query
// язык в языке

int[] numbers = { 1, 2, 3, 4, 5 };

// LINQ в функциональной форме, Where, Select, OrderBy, ...
int[] filtered = numbers.Where (n => n % 2 != 1).ToArray ();   // { 1, 3, 5 }

// LINQ в форме запроса
IEnumerable<int> filtered = 
    from n in numbers
    where n % 2 != 1
    select n;  // SQL