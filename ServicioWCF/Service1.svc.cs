using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Alumno de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
       //Se ingresa el numero de control en la interfaz del cliente para poder visualizar los datos.
        public Alumno ObtenerAlumno(int codigo)
        {
            if (codigo == 17030084)
            {
                return new Alumno() { Nombre = "Karla", ApellidoP = "Garcia", ApellidoM = "Reza", Carrera="Informatica" };
            }
            else if (codigo == 17030085)
            {
                return new Alumno() { Nombre = "Evelyn", ApellidoP = "Garcia", ApellidoM = "Reza", Carrera = "Administracion" };
            }
            else if (codigo == 17030086)
            {
                return new Alumno() { Nombre = "Dulce", ApellidoP = "Garcia", ApellidoM = "Reza", Carrera = "Alimentarias" };
            }
            else
            {
                return new Alumno() { Error = "Alumno no encontrado" };
            }
        }

        public Semestre NumeroAlumnos(string carrera)
        {
            if (carrera == "INFO" || carrera == "info")
            {
                return new Semestre() {Carrera = "Informatica", NumAlumnos = 30, Turno="Matutino"}; 
            }
            else if (carrera == "ADMIN" || carrera == "admin")
            {
                return new Semestre() { Carrera = "Administracion", NumAlumnos = 50, Turno = "Matutino" };
            }
            else if (carrera == "MECA" || carrera == "meca")
            {
                return new Semestre() { Carrera = "Mecatronica", NumAlumnos = 40, Turno = "Matutino" };
            }
            else if (carrera == "ALIM" || carrera == "alim")
            {
                return new Semestre() { Carrera = "Alimentarias", NumAlumnos = 43, Turno = "Matutino" };
            }
            else if (carrera == "INDUS" || carrera == "indus")
            {
                return new Semestre() { Carrera = "Industrial", NumAlumnos = 48, Turno = "Matutino" };
            }
            else
            {
                return new Semestre() { Error = "ObtenerHorario no encontrada" };
            }
        }

        public Turno ObtenerHorario (char turno)
        {
            if (turno == 'M' || turno == 'm')
            {
                return new Turno() { HoraI ="8:00 am", HoraF="3:00pm", NumAlumnos= 180};
            }
            else if (turno == 'V'|| turno == 'v' )
            {
                return new Turno() { HoraI = "12:00 pm", HoraF = "7:00pm", NumAlumnos = 150 };
          
            }
            else
            {
                return new Turno() { Error = "Ese turno no existe" };
            }

        }
        public Calculadora BasicCalculadora (decimal numero1, decimal numero2, char operacion)
        {
            if(operacion == '+')
            {
                decimal sum;
                sum = numero1 + numero2;
                return new Calculadora() { Operacion = "Suma", Resultado= sum};
            }
            if (operacion == '*')
            {
                decimal multi;
                multi = numero1 * numero2;
                return new Calculadora() { Operacion = "Multiplicación", Resultado = multi };
            }
            if (operacion == '-')
            {
                decimal res;
                res = numero1 - numero2;
                return new Calculadora() { Operacion = "Resta", Resultado = res };
            }
            if (operacion == '/')
            {
                decimal div;
                div = numero1 / numero2;
                return new Calculadora() { Operacion = "División", Resultado = div };
            }
            else
            {
                return new Calculadora() { Error = "No se pudo realizar la opración" };
            }
        }

        public Educacion NivelAcademico(int edad)
        {
            if (edad >= 1 && edad <= 3)
            {
                return new Educacion() { Edad = edad, NivelAcadem = "Maternal", AñosRestantes = "24 a 21 años" };
            }
            if (edad >= 4 && edad <= 6)
            {
                return new Educacion() { Edad = edad, NivelAcadem = "Kinder/Preescolar", AñosRestantes = "20 a 19 años" };
            }
            if (edad >= 7 && edad <=12)
            {
                return new Educacion() { Edad = edad, NivelAcadem = "Primaria", AñosRestantes = "18 a 13 años" };
            }
            if (edad >= 13 && edad <= 15)
            {
                return new Educacion() { Edad = edad, NivelAcadem = "Secundaria", AñosRestantes = "12 a 10 años" };
            }
            if (edad >= 16 && edad <= 18)
            {
                return new Educacion() { Edad = edad, NivelAcadem = "Preparatotia", AñosRestantes = "9 a 7 años" };
            }
            if (edad >= 19 && edad <= 23)
            {
                return new Educacion() { Edad = edad, NivelAcadem = "Universidad", AñosRestantes = "6 a 2 años" };
            }
            else
            {
                return new Educacion() { Error = "Intente de nuevo" };
            }
        }
    }
 
}
