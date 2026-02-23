// 5) Evaluación de préstamo bancario por reglas
string aprobado = "";

Console.WriteLine("MENU");
Console.WriteLine("1 Empleo Fijo");
Console.WriteLine("2  Temporal");
Console.WriteLine("3 Independiente");
Console.WriteLine("4 Estudiante");

int tipo = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su ingreso mensual");
double ingreso = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese Antiguedad laboral en meses");
int antiguedad = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese monto solicitado");
double monto = double.Parse(Console.ReadLine());

Console.WriteLine("Historial Creditico");
Console.WriteLine("1 Excelente");
Console.WriteLine("2 Bueno");
Console.WriteLine("3 Regular");
Console.WriteLine("4 Malo");

int historial =  int.Parse(Console.ReadLine());

Console.WriteLine("Tiene fiador? (S/N)");
string fiador = Console.ReadLine().ToUpper();


