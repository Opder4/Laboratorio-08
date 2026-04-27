int numproductos = 0;
int numcategorias = 0;
int valorproducto = 0;
int buscarvalor = 0;
int encontrado = 0;
int contencontrado = 0;
int fila = 0;
int columna = 0;

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
    while (!int.TryParse(Console.ReadLine(), out numproductos) || numproductos <= 0)
    {
        Error();
    }
    Console.WriteLine();
    Console.WriteLine("Ingrese el número de evaluaciones: ");
    Console.WriteLine();
    while (!int.TryParse(Console.ReadLine(), out numcategorias) || numcategorias <= 0)
    {
        Error();
    }
    Limpiar();
}


void IngresarValor(int[,] cali)
{
    for (int i = 0; i < numproductos; i++)
    {
        for (int j = 0; j < numcategorias; j++)
        {
            Console.WriteLine();
            Console.WriteLine($"Ingrese el valor : ");
            Console.WriteLine();
            while (!int.TryParse(Console.ReadLine(), out cali[i, j]))
            {
                Error();
            }
            Limpiar();
        }
    }
}

void ValorABuscar()
{
    Console.WriteLine();
    Console.WriteLine("Ingrese el valor a buscar en el inventario");
    Console.WriteLine();
    while (!int.TryParse(Console.ReadLine(), out buscarvalor))
    {
        Error();
    }
    Limpiar();
}

void Buscar(int[,] pro)
{
    for (int i = 0; i < numproductos;i++)
    {
        for (int j = 0; j < numcategorias; j++)
        {
            if (pro[i,j] == buscarvalor)
            {

            }
        }
    }
}

PedirValores();
int[,] productos = new int[numproductos, numcategorias];
IngresarValor(productos);
ValorABuscar();


