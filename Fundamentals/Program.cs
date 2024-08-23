int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 128;

Console.WriteLine("laço realizado com For");
for (int i = 0; i < arrayInteiros.Length; i++)
{ 
    Console.WriteLine($"posição Nº {i} - {arrayInteiros[i]}");
}

Console.WriteLine();
Console.WriteLine("Percorrendo o array com foreach");
int contador = 0;

foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição Nº {contador} - {valor}");
    contador++;
}