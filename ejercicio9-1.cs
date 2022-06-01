Console.WriteLine("Creador de Vector");
Console.WriteLine("Ingrese por favor la longitud del vector"); 
var dato=Console.ReadLine();
int longitud = int.Parse(dato);
int[] vector;
 vector=new int[longitud];
Random random = new Random();

for (int i = 0; i <vector.Length; i++)
{
    vector[i] =random.Next(100);
}

Console.WriteLine("Su vector es");
Console.Write("[");

for (int i = 0; i < vector.Length; i++)
{
    Console.Write($"{vector[i]} ");

}
Console.WriteLine("]");

Console.WriteLine("Su nuevo vector es:");
Console.Write("[");
for (int posicion=vector.Length - 1; posicion >= 0; posicion--)
{

    Console.Write($"{vector[posicion]} ");
}
Console.Write("]");