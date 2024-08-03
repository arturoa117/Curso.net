//Realizar la carga de dos números enteros por teclado e imprimir su suma y su producto.

using System.Diagnostics.CodeAnalysis;


Console.WriteLine("Ingrese el primer numero ");
int num1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Ingrese el primer numero ");
int num2 = Convert.ToInt32(Console.ReadLine());


int suma = num1 + num2;
int multiplicacion = num1 * num2;

Console.WriteLine("El resualtado de la suma es: " + suma + ". Y la multiplicación es igual a: " + multiplicacion);


