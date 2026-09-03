double validos, branco, nulo, total;
Console.Write("Digite a quantidade de votos válidos: ");
validos = double.Parse(Console.ReadLine());
Console.Write("Digite a quantidade de votos em branco: ");
branco = double.Parse(Console.ReadLine());
Console.Write("Digite a quantidade de votos nulos: ");
nulo = double.Parse(Console.ReadLine());

total = validos+branco+nulo;

Console.WriteLine(validos / total * 100 + "% de votos foram Válidos!");
Console.WriteLine(branco / total * 100 + "% de votos foram em Branco!");
Console.WriteLine(nulo / total * 100 + "% de votos foram Nulos!");

Console.ReadKey();