using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_01
{
    public interface ISerVivo
    {
        ServiceLifetime serviceLifetime { get; }
        void emitirSonido();
        void setSonido(string sonido);
    }
}
