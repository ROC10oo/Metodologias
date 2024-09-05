using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class ColeccionMultiple:Coleccionable
    {
        private Pila pila = new Pila();
        private Cola cola = new Cola();

        public ColeccionMultiple(Pila pila, Cola cola) 
        {
            this.pila = pila;
            this.cola = cola;
        }

        public void agregar(Comparable c) 
        {
        }

        public int cuantos() 
        {
            return pila.cuantos() + cola.cuantos();
        }
        
        public bool contiene(Comparable c)
        {
            bool esta = false;

            if (pila.contiene(c))
                esta = true;
            else
            {
                if (cola.contiene(c))
                    esta = true;
            }
            return esta;
        }
        
        public Comparable maximo() 
        {
            Comparable max;
            Comparable numP = ((Comparable)pila.maximo());
            Comparable numC = ((Comparable)cola.maximo());

            if (numP.SosMayor(numC)) 
            {
                max = numP;
            }
            else 
                max = numC;
            return max;
        }

        public Comparable minimo() 
        {
            Comparable min;
            Comparable numP = ((Comparable)pila.minimo());
            Comparable numC = ((Comparable)cola.minimo());

            if (numP.SosMenor(numC))
            {
                min = numP;
            }
            else
                min = numC;
            return min;
        }

    }
}
