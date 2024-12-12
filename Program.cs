// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x = 10;

double y = x;

float x1 = 12000;
//float ha un range più grande  di int quindi senza dichiarare i casting otterremmo un errore
int y1 = (int)x1;
//y2 ha il valore di y1 ma una volta assegnato aumetera di uno il valore di y1
int y2 = y1++;

int x2 = Convert.ToInt32("12345");

Console.WriteLine($"{x},{y}");
Console.WriteLine($"{x1},{y1}");
Console.WriteLine($"{x2},{y2}");