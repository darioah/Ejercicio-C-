
Console.WriteLine("Ingrese por favor la cantidad de filas");
var filas = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese porfavor la cantidad de columnas");
var columnas = int.Parse(Console.ReadLine());
int[,] Numeros = new int[filas, columnas];

//recorre la matriz para cargar numeros
for (int i=0; i<columnas; i++)
{

    Console.WriteLine($"Ingrese el numero en la posicion Columna N° {i+1}");
    for (int n=0;n<filas; n++)
    {
        Console.Write($"Fila N° {n+1}: ");
        Console.WriteLine("");

        Numeros[i,n]=int.Parse(Console.ReadLine());

    }
}
//recorre la matriz para leer los numeros cargados
for (int i = 0; i<columnas; i++)
{
    Console.WriteLine(" El numero en la pocision : ");
    Console.Write($"columna N°: {i+1} ");

    for (int n = 0; n<filas; n++)
    {
        Console.WriteLine($"fila N°{n+1} " );

        Console.WriteLine($"Es : {Numeros[i,n]}");

    }
}
//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios

double[] promedios = new double[columnas];
for (int i=0; i<columnas; i++)
{
int suma = 0;

    for (int n=0; n<filas; n++)
    {

            suma = suma+Numeros[n,i];
            Console.WriteLine($"la suma es: {suma}");

    }
   double prom = (double)suma/filas;
   promedios[0] =prom;

} 
for (int i = 0; i<promedios.Length; i++)
{
    Console.WriteLine($"Promedio columna n°{i} = {promedios[i]}");
}
