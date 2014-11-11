using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Gatito : IGatito
    {

        public void saludar()
        {
            Console.WriteLine("Hola soy un gatito...");
            Console.ReadKey();
        }

        public void correr()
        {
            Console.WriteLine("Estoy corriendo a 100k/hrs");
            Console.ReadKey();
        }

        public void comer()
        {
            Console.WriteLine("Me voy a colacion con el pato son las 13:00...");
            Console.ReadKey();
        }

        public void jugar()
       { 
            Console.WriteLine("Estoy jugando como loco...");
            Console.ReadKey();
        }

        public void despedirse()
        {
            Console.WriteLine("chau.u ya me voy.....");
            Console.ReadKey();
        
        }
    }
}
