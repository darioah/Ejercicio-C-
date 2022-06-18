using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

    namespace ConsoleApp1.Modelo
    {
        //sealed - no vapoder ser heredada
        public class RepositorioPersonas 
        {
           public List<Persona> Personas { get; set; } 

           

           public RepositorioPersonas()
           {
               Personas = new List<Persona>();
           }

            
            public void AgregarPersona(Persona persona)
            {
                Personas.Add(persona);
            }

            public void EliminarPersona(string dni)
            {
                var persona = Personas.FirstOrDefault(p => p.Dni == dni);
                Personas.Remove(persona);
            }

            public void ModificarPersona(Persona persona)
            {
               foreach (var p in Personas)
                {
                    if (p.Dni == persona.Dni)
                    {
                        p.Nombre = persona.Nombre;
                        p.Apellido = persona.Apellido;
                        p.FechaNacimiento = persona.FechaNacimiento;
                        p.Dni = persona.Dni;
                        p.Ocupacion = persona.Ocupacion;
                        p.Empresa = persona.Empresa;
                        p.ObraSocial = persona.ObraSocial;
                        p.SalarioBruto = persona.SalarioBruto;
                        p.UltimaOcupacion = persona.UltimaOcupacion;
                        p.UltimaEmpresa = persona.UltimaEmpresa;
                        p.EsDiscapacitado = persona.EsDiscapacitado;
                    }
                }  
            }
        }
        
        }