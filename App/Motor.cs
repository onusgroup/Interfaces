using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Motor : IMotor
    {
        public void Encender()
        {
            Console.WriteLine("El motor acaba de encender...");
        }

        public void Detener()
        {
            Console.WriteLine("El motor se detubo...");
        }
    }
}
