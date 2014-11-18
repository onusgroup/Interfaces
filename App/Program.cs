using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato();
            Automovil();  
            
        }

        private static void Gato()
        {
            //  TODO: 
            //- Una interfaz define un contrato que puede ser implementado por clases y estructuras.
            //- Una interfaz puede contener metodos, propiedades, eventos e indexadores.

            IGatito gatito = new Gatito();
            gatito.saludar();
            gatito.correr();
            gatito.jugar();
            gatito.comer();
            gatito.despedirse();
        }
        private static void Automovil()
        {
            //  TODO:
            //  Una interfaz no proporciona implementaciones de los miembros que define sino simplemente 
            //  especifica los miembros que deben ser suministrados por clases o estructuras que implementan la interfaz
            //  y en en conclusión una interfaz únicamente dice QUÉ acciones se van a realizar, pero no CÓMO se realizarán.
            Console.WriteLine("\nInterfaces Motor\n");
            IMotor motor = new Motor();
            ILuces luces = new Luces();
            motor.Encender();
            luces.sistemaElectrico();
            luces.sistemaLuces();
            motor.Detener();
        }
    }
}
