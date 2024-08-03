//Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.

Console.WriteLine("Ingrese el precio del producto: ");

int producto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad: ");

int cantidad = Convert.ToInt32(Console.ReadLine());

int Total = producto * cantidad;

Console.WriteLine("El total a abonar es de: " + Total);
