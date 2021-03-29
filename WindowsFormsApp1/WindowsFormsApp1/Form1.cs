using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Clases;
using WMPLib;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        ClsAuto carrito;




        public Form1()
        {


            InitializeComponent();

        }

        

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            //crear el carro
            carrito = new ClsAuto("Delorian", 150);

            carrito.color = "blanco";
        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {

                SoundPlayer sonidoAccion = new SoundPlayer(Application.StartupPath+@"\Sonidos\Encender.wav");
                sonidoAccion.Play();

                string respuesta = carrito.EncenderMotor();
                labelDatos.Text = respuesta;
            
           
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            SoundPlayer sonidoAccion = new SoundPlayer(Application.StartupPath + @"\Sonidos\aceleracion.wav");
            sonidoAccion.Play();


            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.Acelerar();
                labelCambios.Text = carrito.Cambios();

            }
            else
            {
                MessageBox.Show($"Lo lamento El {carrito.marca} esta apagado");
            }
        }

        private void buttonFrenar_Click(object sender, EventArgs e)
        {

            SoundPlayer sonidoAccion = new SoundPlayer(Application.StartupPath + @"\Sonidos\frenarpoco.wav");
            sonidoAccion.Play();

            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.Frenar();
                labelCambios.Text = carrito.Cambios();
            }
            else
            {
                MessageBox.Show($"Lo lamento El {carrito.marca} esta apagado");
            }

        }

        private void buttonFrenar2_Click(object sender, EventArgs e)
        {

            SoundPlayer sonidoAccion = new SoundPlayer(Application.StartupPath + @"\Sonidos\frenar.wav");
            sonidoAccion.Play();

            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.FrenarTodo();
                labelCambios.Text = carrito.Cambios();
            }
            else
            {
                MessageBox.Show($"Lo lamento El {carrito.marca} esta apagado");
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            string respuesta = carrito.ApagarMotor();
            labelDatos.Text = respuesta;
        }

        private void buttonCambio_Click(object sender, EventArgs e)
        {

            SoundPlayer sonidoAccion = new SoundPlayer(Application.StartupPath + @"\Sonidos\Cambios.wav");
            sonidoAccion.Play();



            if (carrito.EstaEncendido())
            {

                labelCambios.Text = "Siga acelerando";

            }
            else
            {
                MessageBox.Show($"Lo lamento El {carrito.marca} esta apagado");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonClaxon_Click(object sender, EventArgs e)
        {
            SoundPlayer sonidoAccion = new SoundPlayer(Application.StartupPath +@"\Sonidos\claxon.wav");
            sonidoAccion.Play();
        }

        private void buttonCinturon_Click(object sender, EventArgs e)
        {
            SoundPlayer sonidoAccion = new SoundPlayer(Application.StartupPath + @"\Sonidos\Cinturon.wav");
            sonidoAccion.Play();
        }

        private void buttonBrisas_Click(object sender, EventArgs e)
        {
            SoundPlayer sonidoAccion = new SoundPlayer(Application.StartupPath + @"\Sonidos\brisas.wav");
            sonidoAccion.Play();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        bool Play = false;
        string[] ArchivoMP3;
        string[] rutasArchivoMP3;


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusqueda = new OpenFileDialog();
            CajaDeBusqueda.Multiselect = true;
            if (CajaDeBusqueda.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArchivoMP3 = CajaDeBusqueda.SafeFileNames;
                rutasArchivoMP3 = CajaDeBusqueda.FileNames;
                foreach (var ArchivoMP3 in ArchivoMP3)
                {
                    listCansiones.Items.Add(ArchivoMP3);
                }

                Reproductor.URL = rutasArchivoMP3[0];
               listCansiones.SelectedIndex = 0;

                
            }



        }



        private void listCansiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = rutasArchivoMP3[listCansiones.SelectedIndex];


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            switch (Play)
            {
                case true:
                    Reproductor.Ctlcontrols.pause();
                    pictureBox4.Image = Properties.Resources.play;
                    Play = false;
                    break;
                
                case false:
                    Reproductor.Ctlcontrols.play();
                    pictureBox4.Image = Properties.Resources.pause;
                    Play = true;
                    break;
            }
        }
    }
}
