// 5) Evaluación de préstamo bancario por reglas

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

string decision = "Rechazado";
string motivo = "";

if (ingreso <= 0 || monto <= 0 || antiguedad < 0)
{
    Console.WriteLine("Datos Invalidos");
}

else if (historial == 4)
{
    if (fiador == "S")
    {
        if (monto  <= 5000)
        {
            decision = "Aprobado con condiciones";
            motivo = "Historial malo compensado con fiador";
        }

        else
        {
            decision = "Rechazado";
            motivo = "Monto alto con historial";
        }
    }

    else
    {
        decision = "Rechazado";
        motivo = "Historial credito malo";
    }


}

else
{
    switch (tipo)
    {

        case 1:

            break;

        case 2:

            break;

        case 3:

            break;

        case 4:

            break;

        default:
            Console.WriteLine("Tipo de solicitud invalida");
            break;

    }


}


