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
            IGatito gatito = new Gatito();
            gatito.saludar();
            gatito.correr();        
            gatito.jugar();
            gatito.comer();
            gatito.despedirse();
        }
    }
}
