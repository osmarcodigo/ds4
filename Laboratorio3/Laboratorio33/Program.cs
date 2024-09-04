internal class Program
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero, radio, longitud, ancho;

        Console.Write("Introduce el primer numero:  ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo numero:  ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el radio del circulo:  ");
        radio = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce la longitud del rectangulo:  ");
        longitud = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el ancho del rectangulo:  ");
        ancho = Convert.ToInt32(Console.ReadLine());


        CalculosMatematicos calc = new CalculosMatematicos();

        int resul = calc.Calcular(primerNumero, segundoNumero);

        double area = calc.calculoArea(radio);

        double peri = calc.calculoPerimetro(longitud, ancho);

        Console.WriteLine("El resultado del calculo es: {0}", resul);

        Console.WriteLine("El Area del crculo es: {0}", area);

        Console.WriteLine("El Perimetro del rectangulo es: {0}", peri);

    }



    public class CalculosMatematicos
    {
        public int Calcular(int a, int b)
        {
            return (a + b) * (a - b);
        }

        public double calculoArea(double c)
        {
            return Math.PI * Math.Pow(c, 2);
        }

        public double calculoPerimetro(double d, double e)
        {
            return 2 * d + 2 * e;
        }
    }

}