using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Numero:Comparable
    {
        private int valor;

        public Numero(int valor) 
        {
            this.valor = valor;
        }
        public int getValor() 
        {
            return this.valor;
        }
        public bool SosIgual(Comparable c) 
        {
            if (this.valor == ((Numero)c).getValor()) 
            {
                return true;
            }
            else
                return false;
        }

        public bool SosMayor(Comparable c) 
        {
            if (this.valor > ((Numero)c).getValor())
            {
                return true;
            }
            else
                return false;
        }
        public bool SosMenor(Comparable c) 
        {
            if (this.valor < ((Numero)c).getValor())
            {
                return true;
            }
            else
                return false;
        }
    }
}
