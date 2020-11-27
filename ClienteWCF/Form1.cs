using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClienteWCF
{
    public partial class Form1 : Form
    {
        ServicioEscuela.Service1Client cliente = new ServicioEscuela.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            label20.Text = "¿Operacion?";
        }

        private void btnConsultarPro_Click(object sender, EventArgs e)
        {
            int alum = Convert.ToInt32(textBox1.Text);
            using (ServicioEscuela.Service1Client datos = new ServicioEscuela.Service1Client())
            {
                var alumnoDatos = datos.ObtenerAlumno(alum);
                var nombre = alumnoDatos.Nombre;
                var apellidop = alumnoDatos.ApellidoP;
                var apllidom = alumnoDatos.ApellidoM;
                var carrera = alumnoDatos.Carrera;

                textBox2.Text = alumnoDatos.Nombre.ToString();
                textBox3.Text = alumnoDatos.ApellidoP.ToString();
                textBox4.Text = alumnoDatos.ApellidoM.ToString();
                textBox5.Text = alumnoDatos.Carrera.ToString();


            }
        }

        private void btnConsultarEx_Click(object sender, EventArgs e)
        {
            var carrera = textBox6.Text;
            using (ServicioEscuela.Service1Client datos = new ServicioEscuela.Service1Client())
            {
                var obtieneNum = datos.NumeroAlumnos(carrera);
                var nombre = obtieneNum.NumAlumnos;
                var apellidop = obtieneNum.Turno;

                textBox7.Text = obtieneNum.NumAlumnos.ToString();
                textBox8.Text = obtieneNum.Turno.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var turno =Convert.ToChar(textBox9.Text);
            using (ServicioEscuela.Service1Client datos = new ServicioEscuela.Service1Client())
            {
                var horario = datos.ObtenerHorario(turno);
                var hi = horario.HoraI;
                var hf = horario.HoraF;
                var numAlum = horario.NumAlumnos;

                textBox10.Text = horario.HoraI.ToString();
                textBox11.Text = horario.HoraF.ToString();
                textBox12.Text = horario.NumAlumnos.ToString();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var operacion = Convert.ToChar(textBox13.Text);
            var num1 = Convert.ToInt32(textBox14.Text);
            var num2 = Convert.ToInt32(textBox15.Text);
            using (ServicioEscuela.Service1Client datos = new ServicioEscuela.Service1Client())
            {
                var resultado = datos.BasicCalculadora(num1, num2, operacion);
                var total = resultado.Resultado;

                textBox16.Text = resultado.Resultado.ToString();
                label20.Text = resultado.Operacion.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var edad = Convert.ToInt32(textBox17.Text);
            using (ServicioEscuela.Service1Client datos = new ServicioEscuela.Service1Client())
            {
                var nivelacademico = datos.NivelAcademico(edad);
                var nivel = nivelacademico.NivelAcadem;
                var años = nivelacademico.AñosRestantes;

                textBox18.Text = nivelacademico.NivelAcadem.ToString();
                textBox19.Text = nivelacademico.AñosRestantes.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
