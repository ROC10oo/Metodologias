using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Alumno : Persona
    {
        int legajo;
        float promedio;
        
        public Alumno(string nombre, int dni, int legajo, float promedio):base(nombre, dni) 
        {
            this.promedio = promedio;
            this.legajo = legajo;
        }

        public int getLegajo() 
        {
            return this.legajo;
        }

        public float getPromedio() 
        {
            return this.promedio;
        }

        override public bool SosIgual(Comparable c)
        {
            if (this.legajo == ((Alumno)c).getLegajo())
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        override public bool SosMayor(Comparable c)
        {
            if (this.legajo > ((Alumno)c).getLegajo())
            {
                return true;
            }
            else
                return false;
        }
        
        override public bool SosMenor(Comparable c)
        {
            if (this.legajo < ((Alumno)c).getLegajo())
            {
                return true;
            }
            else
                return false;
        }

    }
}
