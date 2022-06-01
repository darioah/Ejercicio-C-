// Escribe un programa que:

// 1) Pida 10 números al usuario.
// 2) Obtener la suma de todos los números ingresados.
// 3) Obtener cual es el mayor de todos los números.
// 4) Obtener cual es el menor de todos los números.
// 5) Obtener el promedio de todos los números.
// 6) Mostrar todos los números ingresados por pantalla.
// 7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.

// Recuerden que no nos deben adjuntar archivos comprimidos ni imagenes.
// Pueden adjuntarnos el archivo .cs, o el codigo como texto.


int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Ingrese el numero {i+1} ");
    numeros[i] = int.Parse(Console.ReadLine());
}

int suma = 0;
for (int i = 0; i < 10; i++)
{
    suma = suma + numeros[i]; 
//suma de los numeros    
}
//----------------------------
//// 3) Obtener cual es el mayor de todos los números.
int mayor = numeros[0];

for (int i = 0; i < 10; i++)
{
    if (numeros[i] > mayor )
    {
     mayor = numeros[i];   
//al final del bucle es mi mayor     
    }
}
// 4) Obtener cual es el menor de todos los números.
int menor = numeros[0];
for (int i = 0; i < 10; i++)
{
    if (numeros[i] < menor  )
    {
     mayor = numeros[i];   
//al final del bucle es mi menor   
    }
}
// 5) Obtener el promedio de todos los números.
double promedio = suma/10d;
Console.Write("Los numeros ingresados son:  ");

for (int i = 0; i < 10; i++)
{
    Console.Write( numeros[i] + " ");
}

Console.WriteLine("La suma es : " + suma);
Console.WriteLine("El mayor es: " + mayor);
Console.WriteLine("El menor es : " + menor);
Console.WriteLine("El promedio es: " + promedio);
