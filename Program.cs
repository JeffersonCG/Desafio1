// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.Write("Digite o nome do herói: ");
    var nome = Console.ReadLine();

    Console.Write("Digite a quantidade de XP do herói: ");
    var xpInput = Console.ReadLine();
    if (!int.TryParse(xpInput, out int xp))
    {
        Console.WriteLine("XP inválido. Tente novamente.\n");
        continue;
    }

    string nivel = xp switch
    {
        < 1000 => "Ferro",
        <= 2000 => "Bronze",
        <= 5000 => "Prata",
        <= 7000 => "Ouro",
        <= 8000 => "Platina",
        <= 9000 => "Ascendente",
        <= 10000 => "Imortal",
        _ => "Radiante"
    };

    Console.WriteLine($"\nO Herói de nome **{nome}** está no nível de **{nivel}**\n");

    Console.Write("Deseja testar outro herói? (s/n): ");
    if (Console.ReadLine()?.ToLower() != "s")
        break;

    Console.WriteLine();
}

