using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_01
{
    public class Poblacion
    {
        private readonly ISerVivo serVivo;

        public Poblacion(ISerVivo serVivo)
        {
            this.serVivo = serVivo;
        }

        public void comunicarse()
        {
            serVivo.emitirSonido();
        }

        public void sonido(string sonido)
        {
            serVivo.setSonido(sonido);
        }

        public void proceso()
        {
            Console.WriteLine(serVivo.serviceLifetime);
        }
    }
}
