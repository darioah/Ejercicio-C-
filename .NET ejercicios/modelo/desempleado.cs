using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
 
 namespace ConsoleApp1.Modelo
 {
    //sealed - no vapoder ser heredada
     public class Desempleado : Persona
     {
        public string UltimaOcupacion { get; set; }
        public string UltimaEmpresa { get; set; }
        public bool EsDiscapacitado { get; set; }


     public int ObtenerValordePension(){

            var valorPension = 0;
            if (EsDiscapacitado)
            {
                valorPension = 100;
            }
            else
            {
                valorPension = 200;
            }
            return valorPension;
     }

     }


     }


