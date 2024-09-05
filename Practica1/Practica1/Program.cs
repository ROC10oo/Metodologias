using System;

namespace Practica1
{

    class Program
    {
        private static void Main(string[] args)
        {
            //Cola cola = new Cola();
            //llenar(cola);
            //informar(cola);
            //Pila pila = new Pila();
            //llenar(pila);
            //informar(pila);
            //Console.WriteLine("Entre ambos");
            //ColeccionMultiple cole = new ColeccionMultiple(pila, cola);
            //informar(cole);

            
            
            //Cola personitas = new Cola();
            //llenarPersonas(personitas);
            //Pila perso = new Pila();
            //llenarPersonas(perso);
            //ColeccionMultiple total = new ColeccionMultiple(perso, personitas);  
            //informarPersona(total);


            //Cola alimnis = new Cola();
            //llenarAlumnos(alimnis);
            //Pila alums = new Pila();
            //llenarAlumnos(alums);

            //ColeccionMultiple colecc = new ColeccionMultiple(alums, alimnis);
            //informarAlumnos(colecc);


            
            Console.ReadKey(true);



        }

        public static void llenar(Coleccionable coleccion)
        { 
            Random random = new Random();
            int numero;
            for (int i = 0; i < 20; i++) 
            {
                numero = random.Next(1,800);
                Comparable com= new Numero(numero);
                coleccion.agregar(com);
                Console.WriteLine(numero);
            }
        }

        public static void llenarPersonas(Coleccionable coleccion) 
        {
            Random random = new Random();
            int dni;
            string[] nombres = 
            {"Pedro", "Juan", "Juana", "Roco", "Rocio", "Pepe", "Joaquin", "Emiliano", "Logan", "Emilia",
            "Martina", "Sofia", "Tomas", "Teresa", "Micaela", "Camila", "Luna", "Peter", "Gio", "Oriana",
            "Noah", "Angeles", "Lucas", "Mia", "Aiden", "Olivia", "Ethan", "Sophia", "Michael", "Ava",
            "Daniel", "Isabella", "Matthew", "Charlotte", "James", "Amelia", "Alexander", "Evelyn", "David", "Harper",
            "William", "Ella", "Jacob", "Abigail", "Benjamin", "Lily", "Logan", "Samantha", "Henry", "Madison",
            "Sebastian", "Grace", "Jack", "Chloe", "Owen", "Emily", "Samuel", "Zoe", "Joseph", "Mila",
            "Matthew", "Ella", "Nolan", "Scarlett", "Leo", "Aria", "Jackson", "Hannah", "Caleb", "Avery",
            "Isaiah", "Eleanor", "Liam", "Natalie", "Gabriel", "Sophie", "Ryan", "Riley", "Charles", "Peyton",
            "Asher", "Victoria", "Elijah", "Addison", "Luke", "Lucy", "Isaac", "Stella", "Ezra", "Alice" 
            };
        
            for (int i = 0; i < 20; i++) 
            {
                dni = random.Next(10000000, 60000000);
                Comparable comparable = new Persona(nombres[i], dni);
                coleccion.agregar(comparable);
                Console.WriteLine("{0}, dni: {1}", nombres[i], dni);
            }
        }

        public static void llenarAlumnos(Coleccionable coleccion)
        {
            Random random = new Random();
            int dni;
            int legajo;
            float promedio;
            string[] nombres =
            {"Pedro", "Juan", "Juana", "Roco", "Rocio", "Pepe", "Joaquin", "Emiliano", "Logan", "Emilia",
            "Martina", "Sofia", "Tomas", "Teresa", "Micaela", "Camila", "Luna", "Peter", "Gio", "Oriana",
            "Noah", "Angeles", "Lucas", "Mia", "Aiden", "Olivia", "Ethan", "Sophia", "Michael", "Ava",
            "Daniel", "Isabella", "Matthew", "Charlotte", "James", "Amelia", "Alexander", "Evelyn", "David", "Harper",
            "William", "Ella", "Jacob", "Abigail", "Benjamin", "Lily", "Logan", "Samantha", "Henry", "Madison",
            "Sebastian", "Grace", "Jack", "Chloe", "Owen", "Emily", "Samuel", "Zoe", "Joseph", "Mila",
            "Matthew", "Ella", "Nolan", "Scarlett", "Leo", "Aria", "Jackson", "Hannah", "Caleb", "Avery",
            "Isaiah", "Eleanor", "Liam", "Natalie", "Gabriel", "Sophie", "Ryan", "Riley", "Charles", "Peyton",
            "Asher", "Victoria", "Elijah", "Addison", "Luke", "Lucy", "Isaac", "Stella", "Ezra", "Alice"
            };

            for (int i = 0; i < 20; i++)
            {
                dni = random.Next(10000000, 60000000);
                legajo = random.Next(100, 500);
                promedio = random.Next(1, 10);
                Comparable comparable = new Alumno(nombres[i], dni, legajo, promedio);
                coleccion.agregar(comparable);
                Console.WriteLine("Nombre: {0}, dni: {1}, legajo {2}, promedio {3}", nombres[i], dni, legajo, promedio);
            }
        }




        public static void informar(Coleccionable coleccion)
        {
            Console.WriteLine("Hay {0} elementos en la colección", coleccion.cuantos());
            Console.WriteLine("El elemento minimo es: {0}", (((Numero)coleccion.minimo()).getValor()));
            Console.WriteLine("El elemento maximo es: {0}", (((Numero)coleccion.maximo()).getValor()));

            int numeroTeclado;
            Console.Write("Ingrese un valor por teclado: ");
            numeroTeclado = int.Parse(Console.ReadLine());

            Comparable comparable = new Numero(numeroTeclado);

            if (coleccion.contiene(comparable))
                Console.WriteLine("El elemento leído está en la colección");
            else
                Console.WriteLine("El elemento leído no está en la colección");
        }


        public static void informarPersona(Coleccionable coleccion)
        {
            Console.WriteLine("Hay {0} elementos en la colección", coleccion.cuantos());
            Console.WriteLine("El elemento minimo es: {0}", (((Persona)coleccion.minimo()).getDni()));
            Console.WriteLine("El elemento maximo es: {0}", (((Persona)coleccion.maximo()).getDni()));

            int DniTeclado;
            Console.Write("Ingrese un dni por teclado: ");
            DniTeclado = int.Parse(Console.ReadLine());

            Comparable comparable = new Persona("", DniTeclado);

            if (coleccion.contiene(comparable))
                Console.WriteLine("El elemento leido esta en la coleccion");
            else
                Console.WriteLine("El elemento leído no está en la colección");
        }

        public static void informarAlumnos(Coleccionable coleccion)
        {
            Console.WriteLine("Hay {0} elementos en la colección", coleccion.cuantos());
            Console.WriteLine("El elemento minimo es: {0}", (((Alumno)coleccion.minimo()).getPromedio()));
            Console.WriteLine("El elemento maximo es: {0}", (((Alumno)coleccion.maximo()).getPromedio()));

            int DniTeclado;
            Console.Write("Ingrese un dni por teclado: ");
            DniTeclado = int.Parse(Console.ReadLine());

            Comparable comparable = new Alumno("", DniTeclado, 0, 0);

            if (coleccion.contiene(comparable))
                Console.WriteLine("El elemento leido esta en la coleccion");
            else
                Console.WriteLine("El elemento leído no está en la colección");
        }

    }

}
