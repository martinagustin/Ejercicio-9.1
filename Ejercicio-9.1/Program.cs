// See https://aka.ms/new-console-template for more information
//variables
int size=0;
Console.WriteLine("Indicar longitud del vector");
size = int.Parse(Console.ReadLine());
//declaramos array's
int[] vectorDirecto=new int[size];
int[] vectorOpuesto = new int[size];
//funcion Random
Random aleatorio=new Random();
//bucle de carga de vector
for(int i = 0; i < size; i++)
{
    vectorDirecto[i] =aleatorio.Next(1,101);
}
Console.WriteLine("------------------");
//bucle de mostrar elementos del vector
Console.WriteLine("Elementos dentro del vector");
foreach(int i in vectorDirecto)
{
    Console.Write($"{i} ");
}
Console.WriteLine("");

//bucle para invertir vector
