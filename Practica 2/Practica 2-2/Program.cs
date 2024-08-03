
try
{
    Console.WriteLine("Ingrese la primera calificación: ");
    int cal1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese la segunda calificación: ");
    int cal2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese la tercera calificación: ");
    int cal3 = Convert.ToInt32(Console.ReadLine());


    int promedio = (cal1 + cal2 + cal3) / 3;

    if (promedio >= 7)
    {
        Console.WriteLine("Su promedio es de: " + {promedio} + " Usted ha aprobado!!!");
    }
    else
    {
        Console.WriteLine("Su promedio es de: " + {promedio} + " Usted se quemó");
    }

}
catch (Exception e) {
    
    Console.WriteLine("Ha ocurrido un error " + {e.Message});
}