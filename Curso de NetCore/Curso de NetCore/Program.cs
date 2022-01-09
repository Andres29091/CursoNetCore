namespace MyApp // Note: actual namespace depends on the project name.
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //TIPO DE VARIABLES//

      //int year = Convert.ToInt32("12");
      //double decimales = 2.5;
      //string nombre = "Felipe";
      //String nombres = "Andrés Felipe";
      //decimal decimals = 2.07M;
      //float flotante = 4.0F;
      //bool valor = true;
      //char letra = 'A';
      //Decimal de = 28.2M;

      //Console.WriteLine(nombres + " {0} {1} {2} {3} {4} {5} {6} {7}", year, decimales, nombre, decimals, flotante, valor, letra, de);

      //-----------------------------------------------------------------//

      //OPERADORES ARITMETICOS//

      //int valor1 = 3;
      //int valor2 = 6;
      //var suma = valor1 + valor2;

      //Console.WriteLine( "La suma entre {0} y {1} es: {2} ", valor1, valor2, suma);

      //-----------------------------------------------------------------//

      //OPERADORES DE ASIGNACION (+, -, *, /, %,) //

      //int valor1 = 3;
      //int valor2 = 6;
      //valor2 += valor1;
      //valor2 -= valor1;
      //valor2 *= valor1;
      //valor2 /= valor1;
      //valor2 %= valor1;

      //Console.WriteLine("Resultado: {0}", valor2);

      //-----------------------------------------------------------------//

      //OPERADORES DE COMPROBACION DE TIPOS Y RELACIONALES ( >=, >, <=, < )//

      //int valor1 = 5;
      //int valor2 = 10;
      //var data = valor1 <= valor2;

      //Console.WriteLine("Resultado: {0}", data);

      //-----------------------------------------------------------------//

      //OPERADORES DE IGUALDAD ( ==, != )//

      //int valor1 = 5;
      //int valor2 = 10;
      //var data = valor1 != valor2;

      //Console.WriteLine("Resultado: {0}", data);

      //-----------------------------------------------------------------//

      //ESTRUCTURA IF Y LOS OPERADORES CONDICIONALES//

      //int value = 5;
      //int value2 = 10;
      //double value3 = 6;
      //double value4 = 3;
      //var data = value != value2;

      //if (value != value2 || value3 == value4)
      //{
      //  Console.WriteLine("The condition is true");
      //}
      //else
      //{
      //  Console.WriteLine("The condition is false");
      //}

      //-----------------------------------------------------------------//

      //ESTRUCTURA IF ANIDADA//

      //int value = 5;
      //int value2 = 10;
      //double value3 = 12;
      //double value4 = 152;
      //var data = value == value2;

      //if (value != value2 || value3 == value4)
      //{
      //  Console.WriteLine("The condition #1 is true");

      //  if (data)
      //  {
      //    Console.WriteLine("The condition #2 is true");
      //  }
      //  else
      //  {
      //    Console.WriteLine("The condition #2 is false");
      //  }
      //}
      //else
      //{
      //  Console.WriteLine("The condition #1 is false");
      //}

      //-----------------------------------------------------------------//

      //OPERADOR CONDICIONAL//

      //int value = 5;
      //int value2 = 10;
      //double value3 = 12;
      //double value4 = 152;
      //string name = String.Empty;
      //var data = value == value2;

      //name = data ? "Andrés" : "Felipe";

      //Console.WriteLine("Resultado {0} ", name);

      //-----------------------------------------------------------------//

      //ARRAY DE TIPO STRING//

      //string[] cadena = new string[5];
      //cadena[0] = "Andrés";
      //cadena[1] = "Felipe";
      //cadena[2] = "Marin";
      //cadena[3] = "Marin";
      //cadena[4] = "Oreo";
      //string[] name = { "Andrés", "Felipe", "Marin", "Marin" };
      //Console.WriteLine("Resultado: {0}", cadena[0] + " " + cadena[1]);

      //-----------------------------------------------------------------//

      //ARRAY DE TIPO INT//

      int[] age = new int[5];

      age[0] = 14;
      age[1] = 18;
      age[2] = 30;
      age[3] = 70;
      age[4] = 9;

      Console.WriteLine("Resultado: {0}", age[0] + " " + age[3]);

      Console.ReadLine();
    }
  }
}
