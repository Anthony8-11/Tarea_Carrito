using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    class ClsAuto
    {

        public string marca { get; }
        public int vel_max { get; }
        public int cambios { get; set; }
        private int velocidadActual { get; set; }
        
        private bool encendido = false;
        public string color { get; set; }




        


        public bool EstaEncendido()
        {
            return encendido;
        }

        public int VelocActual()
        {
            return velocidadActual;
        }



        public string Acelerar()
        {

            velocidadActual = velocidadActual + 10;
            if (velocidadActual > vel_max)
            {
                return "Lo lamento llegaste a la velocidad maxima";
            }
            else
            {
                return $"vas a {velocidadActual} KPH";
            }




        }

        public string Cambios()
        {
            cambios = velocidadActual;
            if (cambios == 0)
            {
                return " ";
            }
            if (cambios == 30)
            {
                return "Realice el cambio";
            }
            if (cambios == 60)
            {
                return "Realice el cambio";
            }
            if (cambios == 90)
            {
                return "Realice el cambio";
            }
            if (cambios == 120)
            {
                return "Realice el cambio";
            }
            else
            {
                return "Siga acelerando";
            }


        }



        public string Frenar()
        {

            if (velocidadActual == 0)
            {
                return "El carro esta parado";
            }
            else
            {
                velocidadActual = velocidadActual - 10;
                return $"vas a {velocidadActual} KPH";
            }

        }

        public string FrenarTodo()
        {
            velocidadActual = 0;

            return "El carro esta parado";
        }





        public ClsAuto(string marcaCarro, int velocidadMx)
        {
            this.marca = marcaCarro;
            this.vel_max = velocidadMx;
        }

        public string EncenderMotor()
        {
            if (encendido)
            {
                return "El carro ya esta encendido";
            }

            else
            {
                this.encendido = true;
                velocidadActual = 0;
                return "Listo!!! Carro Encendido";


            }


        }

        public string ApagarMotor()
        {
            if (encendido)
            {
                if (velocidadActual != 0)
                {
                    return "Antes de apagar pare el carro";
                }
                this.encendido = false;
                velocidadActual = 0;
                return "Listo!!! Carro apagado";

            }
            else
            {
                return "El carro ya esta apagado";
            }
        }
    }
}
