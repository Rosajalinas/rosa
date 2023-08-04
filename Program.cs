//definicion de arreglo de cadenas
string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
//este variable almacenará los resultados  de filtro
IEnumerable<string> query = names
//filtro para obtener los nombres que contiene a
.Where(n => n.Contains("a"))
//ordenados por el tamaño de caracteres
.OrderBy(n => n.Length)
//convertir los seleccionados a mmayuscula
.Select(n => n.ToUpper());
//mostrar los nombres con criterios indicados
foreach (var item in query)
    Console.Write($"{item} |");
