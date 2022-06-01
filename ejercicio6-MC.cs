int numero_secreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

Console.WriteLine("Intente adivinar el número secreto.");
Console.WriteLine("--------------------------------------------");

var intentos = 0; //Contandor de intentos.
int numero_elegido;


do
{
    intentos++; //Sumo un intento.

    //Pido al usuario un número.
    Console.Write("Ingrese su número: ");
    numero_elegido = int.Parse(Console.ReadLine());


    //Evaluo los números y muestro el mensaje correspondiente.
    if (numero_elegido > numero_secreto)
    {
        
        Console.WriteLine("Su número es más muy grande vuelva a ingresar, intente otra vez");
    }
    else if (numero_elegido < numero_secreto)
    {
        
        Console.WriteLine("Su número es más chico vuelva a ingresar, intente otra vez");
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numero_secreto}");
        Console.WriteLine($"Lo has logrado en {intentos} intentos");
    }
}
while (numero_secreto != numero_elegido); //Siempre que el numero secreto sea distinto al que elija el usuario se repite el bucle