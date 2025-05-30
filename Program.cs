int altura, largura;

Console.WriteLine("--- Retangulo Contorno ---\n");

Console.Write("Largura: ");
largura = int.Parse(Console.ReadLine()!);

Console.Write("Altura: ");
altura = int.Parse(Console.ReadLine()!);

Console.WriteLine("".PadRight(largura,'*'));

for (int i = 1; i < altura - 1; i++)
{
    Console.Write("*".PadRight(largura - 1, ' '));
    Console.Write("*\n");
}

Console.WriteLine("".PadRight(largura,'*'));