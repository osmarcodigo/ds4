internal class Program
{
    static void Main(string[] args)
    {
        int suma, cant, valor, prom;
        string linea;
        suma = 0;
        cant = 0;
        do
        {
            Console.Write("Ingrese un numero (0 para finalizar):   ");
            linea = Console.ReadLine();
            valor = int.Parse(linea);
            if (valor != 0)
            {
                suma = suma + valor;
                cant++;
            }
        }while (valor != 0);
        if (cant != 0) {
            prom = suma / cant;
            Console.Write("El promedio de los valores ingresados es:");
            Console.Write(prom);
        }
        else
        {
            Console.Write("No se ingresaron valores");

        }
        Console.WriteLine();

    }
}