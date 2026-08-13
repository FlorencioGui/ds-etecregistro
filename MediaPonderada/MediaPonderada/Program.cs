double[] notas = new double[3];
double media;
Console.Write("Escreva sua primeira nota (peso 2): ");
notas[0]=double.Parse(Console.ReadLine());
Console.Write("Escreva sua segunda nota (peso 3): ");
notas[1] = double.Parse(Console.ReadLine());
Console.Write("Escreva sua terceira nota (peso 5): ");
notas[2] = double.Parse(Console.ReadLine());

media = notas[0]*0.2+ notas[1] * 0.3 + notas[2] * 0.5;

Console.WriteLine("Sua média final foi: " + media);
Console.ReadKey();
