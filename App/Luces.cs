using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Luces : ILuces
    {
        public void sistemaElectrico() 
        {
            Console.WriteLine("Sistema electrico OK!");
        }

        public void sistemaLuces() 
        {
            Console.WriteLine("¡Luces encendidas!");
        }

    }
}
