using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Pila:Coleccionable
    {
        List<Comparable> elementos;

        public Pila()
        {
            elementos = new List<Comparable>();
        }

        public void agregar(Comparable c)
        {
            elementos.Add(c);
        }

        public Comparable desapilar()
        {
            Comparable aux;
            int tam = elementos.Count;
            aux = (Comparable)elementos[tam - 1];
            elementos.Remove(aux);
            return aux;
        }
        public bool EsVacia()
        {
            return elementos.Count == 0;
        }

        public int cuantos()
        {
            return elementos.Count;
        }

        public bool contiene(Comparable c)
        {

            bool esta = false;

            foreach (Comparable elem in elementos)
            {
                if (elem.SosIgual(c))
                {
                    esta = true;
                }
            }
            return esta;
        }

        public Comparable minimo()
        {
            Comparable min = elementos[0];
            foreach (Comparable elem in elementos) //5 6 7 2
            {
                if (min.SosMayor(elem)) //Si mi minimo(5) es mayor al elem(6) 
                {
                    min = elem; //mi minimo es 6
                }
            }
            return min;//Sino mi minimo sigue siendo el 5
        }

        public Comparable maximo()
        {
            Comparable max = elementos[0]; // 5 6 7 2
            foreach (Comparable elem in elementos)
            {
                if (!max.SosMayor(elem)) //Si mi maximo(5) no es mayor que el elem(6)
                {
                    max = elem; // mi nuevo maximo es(6)
                }
            }
            return max; //mi maximo es 5
        }


    }
}
