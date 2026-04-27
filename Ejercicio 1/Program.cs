int cantzonas = 0;
int cantdias = 0;
double valor = 0;

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
    Console.WriteLine("Ingrese la cantidad de zonas: ");
    Console.WriteLine();
    while (!int.TryParse(Console.ReadLine(), out cantzonas) || cantzonas<=0)
    {
        Error();
    }
    Console.WriteLine();
    Console.WriteLine("Ingrese la cantidad de días");
    Console.WriteLine();
    while (!int.TryParse(Console.ReadLine(), out cantdias) || cantdias<=0)
    {
        Error();
    }
    Limpiar();
}


void IngresarTemperaturas(double[,] temp)
{
    for (int i = 0; i<cantzonas; i++)
    {
        for (int j = 0; j<cantdias; j++)
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese la primera temperatura");
            Console.WriteLine();
            while (!double.TryParse(Console.ReadLine(), out temp[i, j]))
            {
                Error();
            }
            Limpiar();
        }
    }
}

void MostarTabla(double[,] temps)
{
    for (int i = 0; i < cantzonas; i++)
    {
        for (int j = 0; j < cantdias; j++)
        {
            Console.Write(temps[i, j] + " ");
        }
    }
    Limpiar();
}

PedirValores();
double[,] temperaturas = new double[cantzonas,cantdias];
IngresarTemperaturas(temperaturas);
MostarTabla(temperaturas);