void Somar(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}

void Subtrair(int x, int y)
{
    Console.WriteLine($"{x} - {y} = {x - y}");
}

void Divisao(int x, int y)
{
    Console.WriteLine($"{x} / {y} = {x / y}");
}

void Multiplicacao(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}

void Potencia(int x, int y)
{
    double pot = Math.Pow(x, y);
    Console.WriteLine($"{x} ^ {y} = {pot}");
}

void Seno(double angulo)
{
   double radiano = angulo * Math.PI / 180;
   double seno = Math.Sin(radiano);
   Console.WriteLine($"Seno de {angulo} º = {Math.Round(seno,4)}");
}


void Coseno(double angulo)
{
   double radiano = angulo * Math.PI / 180;
   double coseno = Math.Cos(radiano);
   Console.WriteLine($"Coseno de {angulo} º = {Math.Round(coseno,4)}");
}


void Tangente(double angulo)
{
   double radiano = angulo * Math.PI / 180;
   double tangente = Math.Tan(radiano);
   Console.WriteLine($"tangente de {angulo} º = {Math.Round(tangente,4)}");
}

Somar(10,5);
Subtrair(110, 8);
Divisao(70, 2);
Multiplicacao(30,2);
Potencia(4,2);
Seno(30);
Coseno(30);
Tangente(30);
