//Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.

using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Introduce el primer número: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduce el primer número: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduce el primer número: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduce el primer número: ");
int num4 = Convert.ToInt32(Console.ReadLine());

int suma = num1 + num2 + num3 + num4;

int promedio = suma / 4;

Console.WriteLine("La suma es total es de: " + suma + ". Y el promedio es de: " + promedio);