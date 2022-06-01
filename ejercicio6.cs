 //Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta) si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado)
 Console.WriteLine ("Escribe el precio del producto");
            double precio = Convert.ToDouble(Console.ReadLine ());
 
            Console.WriteLine ("Escribe la forma de pago: tarjeta o efectivo");
            String forma = (Console.ReadLine()).ToLower();
 
            if (forma.Equals ("tarjeta")) {
 
                Console.WriteLine ("Introduce el numero de tarjeta");
                int numero_cuenta = Convert.ToInt32 (Console.ReadLine ());
 
                Console.WriteLine ("El producto con precio " + precio + " se ha pagado " +
                "con el numero de cuenta " + numero_cuenta);
 
 
            } else if (forma.Equals ("efectivo")) {
 
                Console.WriteLine ("El producto con precio " + precio + " se ha pagado");
 
            } else {
 
                Console.WriteLine ("La forma de pago no es correcta");
            }