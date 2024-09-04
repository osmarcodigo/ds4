using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero;

        Console.Write("Introduce el primer numero:  ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo numero:  ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        CalculosMatematicos calc = new CalculosMatematicos();


        int resul = calc.Calcular(primerNumero, segundoNumero);


        Console.WriteLine("El resultado es {0}", resul);
    }

  

public class CalculosMatematicos
    {
        public int Calcular(int a, int b)
        {
            return (a + b) * (a - b);
        }

    }


}