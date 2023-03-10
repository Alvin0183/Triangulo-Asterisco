
Console.WriteLine("---------------------------------------");
Console.WriteLine("Por favor, introduce un número entero:");
Console.WriteLine("---------------------------------------");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("---------------------------------------");
for (int i = 1; i <= numero; i++)
{
    for (int xd = 1; xd <= i; xd++)
    {
       Console.Write("*");
    }
       Console.WriteLine();
}
Console.WriteLine("---------------------------------------");