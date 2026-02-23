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
            if (antiguedad >= 12)
            {
                if (ingreso >= monto * 0.30)
                {
                    decision = "Aprobado";
                    motivo = "Estabilidad laboral suficiente";
                }
                else
                {
                    decision = "Aprobado con condiciones";
                    motivo = "Ingreso justo para el monto";
                }
            }

            else
            {
                decision = "Aprobado con condiciones";
                motivo = "Poca antiguedad laboral";
            }

            break;

        case 2:

            if (antiguedad >= 18)
            {
                if (fiador == "S")
                {
                    decision = "Aprobado con condiciones";
                    motivo = "Contratado temporal respaldado por fiador";
                }
                else
                {
                    decision = "Rechazado";
                    motivo = "Contrato temporal sin respaldo";
                }
            }
            else
            {
                decision = "Rechazado";
                motivo = "Muy poca estabilidad laboral";
            }
            break;

        case 3:
            if (ingreso >= monto * 0.50)
            {
                if (antiguedad >= 24)
                {
                    decision = "Aprobado";
                    motivo = "Actividad independiente";
                }
                else
                {
                    decision = "Aprobado con condiciones";
                    motivo = "Ingreso alto pero antiguedad";
                }
            }
            else
            {
                decision = "Rechazado";
                motivo = "Ingreso insuficiente para independiente";
            }
                break;

        case 4:
            if (fiador == "S")
            {
                if (monto < 3000)
                {
                    decision = "Aprobado con condiciones";
                    motivo = "Prestamo estudiantil con fiador";
                }
                else
                {
                    decision = "Rechazado";
                    motivo = "Monto alto para perfil estudiantil";
                }
            }

            else
            {
                decision = "Rechazado";
                motivo = "Estudiante sin fiador";
            }

                break;

        default:
            Console.WriteLine("Tipo de solicitud invalida");
            break;

    }


}


