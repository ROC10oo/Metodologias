using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public interface Comparable
    {
        bool SosIgual(Comparable c);
        bool SosMayor(Comparable c);
        bool SosMenor(Comparable c);
    }
}
