internal class Program
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero, radio;

        Console.Write("Introduce el primer numero:  ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo numero:  ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el radio del circulo:  ");
        radio = Convert.ToInt32(Console.ReadLine());

        CalculosMatematicos calc = new CalculosMatematicos();



        int resul = calc.Calcular(primerNumero, segundoNumero);

        double area = calc.calculoArea(radio);

        Console.WriteLine("El resultado del calculo es: {0}", resul);

        Console.WriteLine("El Area del crculo es: {0}", area);

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
    }


}