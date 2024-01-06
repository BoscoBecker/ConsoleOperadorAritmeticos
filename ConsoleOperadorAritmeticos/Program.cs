// See https://aka.ms/new-console-template for more information

 Console.WriteLine("Hello, World!");

int x = 3 + 4 * 2; // 11
Console.WriteLine(x);

int y = (3 + 4) * 2;// 14
Console.WriteLine(y);

int z = 17 % 3;
Console.WriteLine(z);

double w = 10 / 8;// essa divisão retornará um inteiro = 1
Console.WriteLine(w);

double k = 10.0 / 8;// essa divisão retornará um double pois existe pelo menos um double na divisão = 1,25
Console.WriteLine(k);


//Criando uma equação do 2º Grau, formula de báscara

double a = 1.0, b = -3.0, c = -4.0;
double delta = b * b - 4.0 * a * c; // or double delta = Math.Pow(b,2) - 4.0 * a * c;
double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
Console.WriteLine(delta);
Console.WriteLine(x1);

