using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
  public class Program
  {
    public static void Main(string[] args)
    {
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

      int valor1 = 3;
      int valor2 = 6;
      var suma = valor1 + valor2;

      Console.WriteLine( "La suma entre {0} y {1} es: {2} ", valor1, valor2, suma);

      Console.ReadLine();
    }
  }
}
