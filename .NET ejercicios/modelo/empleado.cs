using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Modelo
{
    public class Empleado : Persona

    //sealed - no vapoder ser heredada
    {
        private int _salarioBruto;


        public string Ocupacion { get; set; }
        public string Empresa { get; set; }
        public string ObraSocial { get; set; }
        public string salario { get; set; }
       
        public int SalarioBruto { 
        
         set => _salarioBruto = value; }
        

        private int SalarioNeto(){
            var SalarioNeto = _salarioBruto -*0.85;
            return (int)SalarioNeto; //convertir a int .. truncamiento del dato.
        }

        public int Salerio_Neto { get => SalarioNeto(); }

        }
        }