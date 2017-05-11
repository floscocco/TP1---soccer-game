using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soccer_game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iniciando partido nuevo");

            Console.WriteLine("-------------------------------------------------------");

            Jugador jug = new Jugador();

            Console.WriteLine("Ingrese el numero de jugadores de ambos equipos:");

            String jugadores = Console.ReadLine();
            jug.Numero = Convert.ToInt32(jugadores);

            Console.WriteLine("Se generaron dos equipos con " + jugadores + " jugadores cada uno.");

            Console.WriteLine("-------------------------------------------------------");

            Cancha canchaNueva = new Cancha();

            Console.WriteLine("Ingrese el tamaño de X de la cancha:");

            String tamañoX = Console.ReadLine();
            canchaNueva.TamañoX = Convert.ToInt32(tamañoX); 

            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Ingrese el tamaño de Y de la cancha:");

            String tamañoY = Console.ReadLine();
            canchaNueva.TamañoY = Convert.ToInt32(tamañoY);

            Console.WriteLine("La cancha mide "+tamañoX+" x "+tamañoY+" metros.");

            Console.WriteLine("-------------------------------------------------------");

            Pelota pelotaNueva = new Pelota();

            Console.WriteLine("Ingrese el tamaño de la pelota:");

            String tamaño = Console.ReadLine();
            pelotaNueva.Tamaño = Convert.ToInt32(tamaño);

            Console.WriteLine("La pelota tiene un tamaño de: "+tamaño+" pulgadas.");

            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Inicio del partido");

            Console.WriteLine("-------------------------------------------------------");

            int resultado1;
            int resultado2;

            Random r1 = new Random();
            Random r2 = new Random();
            resultado1 = r1.Next(0, 10);
            resultado2 = r2.Next(0, 10);   

            Console.WriteLine("Final del partido. Resultado: "+resultado1+ " a "+resultado2);

            Console.ReadLine();
        }
        
    }
}
