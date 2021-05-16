using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    //Miguel Daniel Reyes Martinez
    //Maynor Antonio Torres Hernandez

    public partial class Form1 : Form
    {

        int intentos = 0;       //un contador de intentos de login

        DateTime dt = DateTime.Now;  //Hay que declarar la fecha globalmente para que funcione

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string[] Correo = { "admin@gmail.com", "gerente@gmail.com", "auxiliar@gmail.com", "produccion@gmail.com" }; //array de los mails
            string[] Password = { "krodpxqgr", "dgplqe", "whvwhu", "ghvduuroodgru" };   //array de los passwords

            if (Correo.Contains(textUser.Text) && Password.Contains(textPass.Text) && Array.IndexOf(Correo, textUser.Text) == Array.IndexOf(Password, textPass.Text))
            {                                                           //logica de evaluacion, compara si en las textboxs hay un elemento de los contenidos dentro del array y se usa el metodo indexof para compararlos con el numero de indice
                MessageBox.Show("Acceso al sistema" + dt.ToString());   //mensaje de confirmacion si el correo y el password son corrrectos                
            }

            if(Correo.Contains(textUser.Text) && Password.Contains(textPass.Text) && Array.IndexOf(Correo, textUser.Text) != Array.IndexOf(Password, textPass.Text)) //evaluacion si el correo y el pass no son iguales por su numero de indice
            {
                MessageBox.Show("Error de Acceso" + dt.ToString()); //mensaje de error de acceso
            }

            else
            {
                textUser.Clear(); // evaluacion si el campo del correo esta vacio
                textPass.Text = ""; // evaluacion si el password esta vacio
                textUser.Focus(); // evaluar si vuelve a intentarlo con el campo vacio
                intentos += 1; // contador de numero de intentos

                MessageBox.Show("Debes ingresar un correo y una contraseña");  //mensaje de alerta si alguno de los campos esta vacio. 



                if (intentos == 3) //si el contador llega a 3
                {
                    MessageBox.Show("Intentalo mas Tarde"); //mensaje de alerta
                    Application.Exit(); //cierra la aplicacion
                }

            }

           

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //NO ERA NECESARIO, IGNORAR
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //TAMPOCO ERA NECESARIO, IGNORAR
        }
    }
}
