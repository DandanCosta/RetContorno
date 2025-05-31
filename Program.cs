int altura, largura;

Console.WriteLine("--- Retangulo Contorno ---\n");

do
{
    Console.Write("Largura: ");
    largura = int.Parse(Console.ReadLine()!);
} while (largura < 1 || largura > 10);

do
{
    Console.Write("Altura: ");
    altura = int.Parse(Console.ReadLine()!);
} while (altura < 1 || altura > 10);

Console.WriteLine("".PadRight(largura, '*'));

for (int i = 1; i < altura - 1; i++)
{
    Console.Write("*".PadRight(largura - 1, ' '));
    Console.Write("*\n");
}

Console.WriteLine("".PadRight(largura,'*'));