int numproductos = 0;
int numdias = 0;
int valor = 0;
int filaver = 0;

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
    Console.WriteLine("Ingrese el número de produtos: ");
    Console.WriteLine();
    while (!int.TryParse(Console.ReadLine(), out numproductos) || numproductos <= 0)
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


void IngresarCantidadVentas(int[,] cantvent)
{
    for (int i = 0; i < numproductos; i++)
    {
        for (int j = 0; j < numdias; j++)
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese la primera cantidad vendidad");
            Console.WriteLine();
            while (!int.TryParse(Console.ReadLine(), out cantvent[i, j]))
            {
                Error();
            }
            Limpiar();
        }
    }
}

void PedirFila()
{
    Console.WriteLine();
    Console.WriteLine("Ingrese la fila del producto que desea ver las cantidades de ventas");
    Console.WriteLine();
    while (!int.TryParse(Console.ReadLine(),out filaver) || filaver < 0 || filaver>=numproductos)
    {
        Error();
    }
    Limpiar();
}

void MostrarCantidadVentas(int[,] cant)
{
    Console.WriteLine();
    Console.WriteLine("La cantidad de ventas de ese producto es de esta forma");
    Console.WriteLine();
    for (int i = 0; i<numdias;i++)
    {
        Console.Write(cant[filaver, i] + " ");
    }
    Limpiar();
}

PedirValores();
int[,] cantidadventas = new int[numproductos, numdias];
IngresarCantidadVentas(cantidadventas);
PedirFila();
MostrarCantidadVentas(cantidadventas);



