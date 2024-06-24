string inputTexto = Console.ReadLine();
Console.WriteLine("Elija una de las opciones:");
Console.WriteLine("1 - Frase en mayúsculas");
Console.WriteLine("2 - Frase en minúsculas");
Console.WriteLine("3 - Cantidad de caracteres de la frase");
ConsoleKeyInfo opcion = Console.ReadKey();
Console.WriteLine();
switch (opcion.Key)
{
    case ConsoleKey.D1:
        Console.WriteLine(inputTexto.ToUpper());
        break;
    case ConsoleKey.D2:
        Console.WriteLine(inputTexto.ToLower());
        break;
    case ConsoleKey.D3:
        Console.WriteLine(inputTexto.Length);
        break;
}