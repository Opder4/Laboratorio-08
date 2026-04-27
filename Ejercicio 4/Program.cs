int numestudiantes = 0;
int numevaluaciones = 0;
int calificacion = 0;
int mayor = int.MinValue;

void Error()
{
    Console.WriteLine();
    Console.WriteLine("Dato no válido");
    Console.WriteLine();
}

void Limpiar()
{
    Console.WriteLine();
    Console.WriteLine("Presione ENTER para continuar");
    Console.WriteLine();
    Console.ReadLine();
    Console.Clear();
}

void PedirValores()
{
    Console.WriteLine("Ingrese el número de estudiantes: ");
    Console.WriteLine();
    while (!int.TryParse(Console.ReadLine(), out numestudiantes) || numestudiantes <= 0)
    {
        Error();
    }
    Console.WriteLine();
    Console.WriteLine("Ingrese el número de evaluaciones: ");
    Console.WriteLine();
    while (!int.TryParse(Console.ReadLine(), out numevaluaciones) || numevaluaciones <= 0)
    {
        Error();
    }
    Limpiar();
}


void IngresarCalificaciones(int[,] cali)
{
    for (int i = 0; i < numestudiantes; i++)
    {
        for (int j = 0; j < numevaluaciones; j++)
        {
            Console.WriteLine();
            Console.WriteLine($"Ingrese la calificación: ");
            Console.WriteLine();
            while (!int.TryParse(Console.ReadLine(), out cali[i, j]))
            {
                Error();
            }
            Limpiar();
        }
    }
}

int BuscarMayor(int[,] mayo)
{
    for (int i = 0; i < numestudiantes; i++)
    {
        for (int j = 0; j < numevaluaciones; j++)
        {
            if (mayo[i,j]>mayor)
            {
                mayor=mayo[i,j];
            }
        }
    }
    return mayor;
}

PedirValores();
int[,] calificaciones = new int[numestudiantes, numevaluaciones];
IngresarCalificaciones(calificaciones);
Console.WriteLine();
Console.WriteLine($"La mayor calificación fue de {BuscarMayor(calificaciones)} puntos");
Console.WriteLine();
