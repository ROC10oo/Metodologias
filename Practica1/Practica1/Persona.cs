using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Persona:Comparable
    {
        private string nombre;
        private int dni;

        public Persona(string nombre, int dni) 
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public string getNombre() 
        {
            return this.nombre;
        }

        public int getDni() 
        {
            return this.dni;
        }



        //public bool SosIgual(Comparable c)
        //{
        //    if (this.dni == ((Persona)c).getDni())
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}

        //public bool SosMayor(Comparable c)
        //{
        //    if (this.dni > ((Persona)c).getDni())
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}

        //public bool SosMenor(Comparable c)
        //{
        //    if (this.dni < ((Persona)c).getDni())
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}

        virtual public bool SosIgual(Comparable c)
        {
            if (this.dni == ((Persona)c).getDni())
            {
                return true;
            }
            else
                return false;
        }

        virtual public bool SosMayor(Comparable c)
        {
            if (this.dni > ((Persona)c).getDni())
            {
                return true;
            }
            else
                return false;
        }
        
        virtual public bool SosMenor(Comparable c)
        {
            if (this.dni < ((Persona)c).getDni())
            {
                return true;
            }
            else
                return false;
        }


    }
}
