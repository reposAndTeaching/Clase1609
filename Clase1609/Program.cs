using System;
using Clase1609.model;

namespace Clase1609
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaración
            int[] misNumeros;
            //inicialización
            misNumeros = new int[3];

            //todo junto
            int[] misNumerosv2 = new int[3];

            int numeroUno = 50;
            int numeroDos = 102;

            //Ingresando a Posiciones de array (modificar / establecer)
            misNumeros[0] = numeroUno;
            misNumeros[1] = numeroDos;
            misNumeros[2] = 34;

            //Ingresamos a posiciones de array (ver /obtener)
            Console.WriteLine(misNumeros[0]);
            Console.WriteLine(misNumeros[1]);
            Console.WriteLine(misNumeros[2]);
            Console.WriteLine("*****************");
            //Error - Excepción, el index está fuera del rango de la lista
            //misNumeros[3] = 10;
            //Console.WriteLine(misNumeros[3]);

            //Diferentes maneras de inicializar un array
            int[] listaDeNumeros = new int[4] {2, 56, 47, 999};
            int[] listaDeNumerosv2 = new int[] { 2, 56, 47, 999 };

            Console.WriteLine(listaDeNumerosv2[0]);
            Console.WriteLine(listaDeNumerosv2[1]);
            Console.WriteLine(listaDeNumerosv2[2]);
            Console.WriteLine(listaDeNumerosv2[3]);
            Console.WriteLine("*****************");
            Console.WriteLine(listaDeNumerosv2.Length); //Propiedad Length que nos permite en una lista conocer el largo

            Console.WriteLine("*****************");

            //array implícito
            var marcas = new[] { "Sony" , "LG" , "Lenovo" };//implícito
            string[] marcasv2 = new string[] { "Sony", "LG", "Lenovo" };

            //array de objetos
            Videojuego[] listaDeConsolas = new Videojuego[2];//declaro e inicializo la lista de objetos Videojuego
            listaDeConsolas[0] = new Videojuego("Nintendo Switch", "Negro");//agrego en el espacio 0, un nueva consola.

            Videojuego xboxs = new Videojuego("Xbox Series S", "Blanca");
            listaDeConsolas[1] = xboxs;

            //array de tipos o clases anónimas
            var listaRegiones = new[]
            {
                new{Nombre="Valparíso", Posicion=5},
                new{Nombre="Libertador General Bernardo O'Higgins", Posicion=6}
            };

            Console.WriteLine("***********************");

            //Bucle for -> inicializar variable / Condición / Incremento o decremento
            for(int i = 0 ; i<listaDeConsolas.Length ; i++)
            {
                Console.WriteLine(listaDeConsolas[i].Nombre);
                Console.WriteLine(listaDeConsolas[i].Color);
            }

            //Bucle while imitando comportamiento del for
            int index = 0;
            while(index < listaDeConsolas.Length) // 0<2 // 1<2 // 2<2
            {
                Console.WriteLine(listaDeConsolas[index].Nombre);
                Console.WriteLine(listaDeConsolas[index].Color);
                index++;
            }

            Console.WriteLine("************");

            //Bucle foreach(por cada), para recorrer objetos iterables, como listas, array, colecciones, matrices, etc.
            foreach(var item in listaDeConsolas)
            {
                Console.WriteLine(item.Nombre);
                Console.WriteLine(item.Color);
            }

            Console.WriteLine("***************************************");

            Console.WriteLine("Bienvenido");
            Console.Write("¿Cuántas consolas desea crear?: ");
            int opcion = Convert.ToInt32(Console.ReadLine()); //Console readline, ingresar datos por consola(string) // convert to int 32, convierte un valor a INT si puede.
            Videojuego[] miListaDeConsolas = new Videojuego[opcion];
            for(int i = 0; i<opcion; i++)
            {
                Console.WriteLine($"Ingrese Nombre para la consola número {i+1}: ");
                string nombreConsola = Console.ReadLine();
                Console.WriteLine($"Ingrese Color para la consola número {i+1}: ");
                string colorConsola = Console.ReadLine();
                Videojuego nuevaConsola = new Videojuego(nombreConsola, colorConsola);
                miListaDeConsolas[i] = nuevaConsola;
            }

            Console.WriteLine("Se han ingresado las nuevas consolas exitosamente!");

            foreach(Videojuego consola in miListaDeConsolas)
            {
                Console.WriteLine($"La consola {consola.Nombre} es de color {consola.Color}");
            }
        }
    }
}
