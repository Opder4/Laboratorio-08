int numapartamentos = 0;
int numdias = 0;
double consum = 0;
double total = 0;

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
    Console.WriteLine("Ingrese el número de apartamentos: ");
    Console.WriteLine();
    while (!int.TryParse(Console.ReadLine(), out numapartamentos) || numapartamentos <= 0)
    {
        Error();
    }
    Console.WriteLine();
    Console.WriteLine("Ingrese el número de días: ");
    Console.WriteLine();
    while (!int.TryParse(Console.ReadLine(), out numdias) || numdias <= 0)
    {
        Error();
    }
    Limpiar();
}


void IngresarConsumo(double[,] consum)
{
    for (int i = 0; i < numapartamentos; i++)
    {
        for (int j = 0; j < numdias; j++)
        {
            Console.WriteLine();
            Console.WriteLine($"Ingrese el consumo: ");
            Console.WriteLine();
            while (!double.TryParse(Console.ReadLine(), out consum[i, j]))
            {
                Error();
            }
            Limpiar();
        }
    }
}

double TotalConsumo(double[,] totale)
{
    for (int i = 0; i < numapartamentos; i++)
    {
        for (int j = 0; j < numdias; j++)
        {
            consum += totale[i, j];
        }
    }
    return consum;
}

PedirValores();
double[,] consumo = new double[numapartamentos, numdias];
IngresarConsumo(consumo);
Console.WriteLine();
Console.WriteLine($"EL total de consumo es de {TotalConsumo(consumo)}");
Console.WriteLine();