public void Sumar(int valor1, int valor2)
{
    int variableLocal = valor1 + valor2;
   Console.WriteLine(variableLocal);
}
//Console.WriteLine(variableLocal);


namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.FirstName = "Su_Nombre";
            client.LastName = "Su_Apellido";
            client.Age = 15;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());


        }



    }
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public ushort Age{ get; set; }

    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }
 }


}

public class MyClass
{
    public static int Valor;
}


public class Program2
{
    public static void Main()
    {
        MyClass.Valor = 1;
        Console.WriteLine(MyClass.Valor);
    }
}

public class MyClass
{
    public static int Valor;
}


int valor1 = 28;
valor2 = valor1;

MyClass object1 = new MyClass();
object1.Nombre = "Yeison";
object1.Edad = 28;

MyClass object2 = object1;

object2.Nombre = "Jose";

Console.WriteLine(object2.Nombre);
Console.WriteLine(object1.Nombre);

char caracter = 'A';
string cadena = "Cadena de caracteres";

bool condicion = true;
