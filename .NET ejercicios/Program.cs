using ConsoleApp1.Modelo;
using ConsoleApp1.Repositorio;

// Gestor de personas trabajadoras empleados , desemlpeados , jubulados 
//insertar presonas a una base de datos a 
// dertem
var gestorPersonas = new GestorPersonas();

gestorPersonas
var Repositorio = new RepositorioPersonas();
//elegir una empresona para trabajar
Repositorio.AgregarPersona(new Empleado(
    nombre : "Juan",
    apellido : "Perez",
    dni : "12345678",
    fechaNacimiento : "01/01/1980",
    ocupacion : "Programador",
    empresa : "Microsoft",
    obraSocial : "OSDE",
    salarioBruto : 1000,
    ultimaOcupacion : "Programador",
    ultimaEmpresa : "Microsoft",
    esDiscapacitado : false
    
));