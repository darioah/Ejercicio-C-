using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Modelo
{
    public abstract class Persona
    {
        private DateTime _fechaNacimiento;
        private int _dni ;

        public string nombre { get; set; } 
        public string apellido { get; set; }
        public string dni { 
            get {
                return _dni.ToString(); 
            }

        
         set {

                // _dni = int.Parse(value);

                var sePuedeConvertir = int.TryParse( value, out _dni) ; //devuelve una salida de tipo bool
                if (!sePuedeConvertir)
                {
                    _dni = 0;
                }
                else
                {
                    throw new Exception("El DNI no es valido");
                }
                {
                    
                }
            }
          }
        public string fechaNacimiento { get {
                return _fechaNacimiento.ToString("dd/MM/yyyy");
            }
            set {
                _fechaNacimiento = DateTime.Parse(value); 
                // _fechaNacimiento = Convert.ToDateTime(value); // Parsear la fecha
            }
        }
        
         //publicanmente la estoy exponiendo como string, se guardara como datetime

       public int ObtenerEdad(){
        var fechaActual = DateTime.Today;
        var edad = fechaActual.Year - _fechaNacimiento.Year;
        return (int)edadDateTime.TotalDays/365;
    }  

    }

   
    
    }