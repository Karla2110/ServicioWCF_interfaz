using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Alumno ObtenerAlumno(int codigo);

        [OperationContract]
        Semestre NumeroAlumnos(string carrera);

        [OperationContract]
        Turno ObtenerHorario (char turno);

        [OperationContract]
        Calculadora BasicCalculadora (decimal numero1, decimal numero2, char operacion);

        [OperationContract]
        Educacion NivelAcademico(int edad);

    }

 

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Alumno
    {
        internal string Error;

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string ApellidoP { get; set; }

        [DataMember]
        public string ApellidoM { get; set; }

        [DataMember]
        public string Carrera { get; set; }

    }

    public class Semestre
    {
        internal string Error;

        [DataMember]
        public string Carrera { get; set; }

        [DataMember]
        public int NumAlumnos { get; set; }

        [DataMember]
        public string Turno { get; set; }

    }

    public class Turno
    {
        internal string Error;
     
        [DataMember]
        public string HoraI { get; set; }

        [DataMember]
        public string HoraF { get; set; }

        [DataMember]
        public int NumAlumnos { get; set; }

    }

    public class Calculadora
    {
        internal string Error;

        [DataMember]
        public string Operacion { get; set; }

        [DataMember]
        public decimal Resultado { get; set; }
    }

    public class Educacion
    {
        internal string Error;
        [DataMember]
        public int Edad { get; set; }

        [DataMember]
        public string NivelAcadem { get; set; }

        [DataMember]
        public string AñosRestantes { get; set; }
    }
}
