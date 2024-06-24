int cantIteraciones = 5;
string[] vector =  new string[cantIteraciones];
for (int i = 0; i < cantIteraciones; i++)
{
    vector[i] = Console.ReadLine();
}
Console.Clear();
for (int i = cantIteraciones - 1; -1 < i; i--)
{
    Console.WriteLine(vector[i]);
}