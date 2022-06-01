//  Pedir el nombre de la semana al usuario y decirle si es fin de semana o no.  En caso de error, indicarlo. 

Console.WriteLine ("Escribe un dia de la semana");
            String dia = Console.ReadLine ();
 
            switch(dia.ToLower()){
 
            case "lunes":
            case "martes":
            case "miercoles":
            case "jueves":
            case "viernes":
                Console.WriteLine ("No es fin de semana");
                break;
            case "sabado":
            case "domingo":
                Console.WriteLine ("Es fin de semana");
                break;
 
            default:
                Console.WriteLine ("Ese dia no es correcto");
                break;
            }
 