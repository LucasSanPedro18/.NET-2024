
string inputTexto = Console.ReadLine();

if (inputTexto == null) Console.WriteLine("No se escribio nada");
else
{
    Console.WriteLine("Elija una de las opciones:");
    Console.WriteLine("1 - Frase en mayúsculas");
    Console.WriteLine("2 - Frase en minúsculas");
    Console.WriteLine("3 - Cantidad de caracteres de la frase");
    ConsoleKeyInfo opcion = Console.ReadKey();
    Console.WriteLine();
    if (opcion.Key == ConsoleKey.D1)
    {
        Console.WriteLine(inputTexto.ToUpper());
        Console.ReadLine();
    }
    else if(opcion.Key == ConsoleKey.D2)
    {
        Console.WriteLine(inputTexto.ToLower()); 
        Console.ReadLine();
    }
    else if (opcion.Key == ConsoleKey.D3)
    {
        Console.WriteLine(inputTexto.Length);
        Console.ReadLine();
    }
    else Console.WriteLine("No eligió ninguna opción correcta");
}