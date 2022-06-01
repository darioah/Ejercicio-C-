//3) Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: “Te llamas ” <nombre> ” y tienes ” <años> ” años”
Console.WriteLine ("Escribe tu nombre");
            String nombre = Console.ReadLine ();
 
            Console.WriteLine ("Escribe tu edad");
            String texto = Console.ReadLine ();
 
            int edad = Convert.ToInt32 (texto); 
//Conver.Toint32 lo parsea a entero             
            Console.WriteLine ("Te llamas "+nombre+" y tienes "+edad+ " años");
 