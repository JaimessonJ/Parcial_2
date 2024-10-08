internal class Program
{
    private static void Main(string[] args)
    {
        int rango;
        int numJugadores = 0;
        bool continuar = true;
        Random aleatorio = new Random();

        while (continuar)
        {
            Console.WriteLine("Bienvedido al juego de 'adivina el número' escoje el numero de jugadores (minimo 2 / maximo4): ");
            numJugadores = Convert.ToInt32(Console.ReadLine());

            while (numJugadores < 2 || numJugadores > 4) 
            {
                Console.WriteLine("Elige entre 2 a 4 jugadores; ");
                numJugadores = Convert.ToInt32(Console.ReadLine());
            }

            if (numJugadores == 2)
            {
                rango = 50;
            }
            else if (numJugadores == 3)
            {
                rango = 100;
            }
            else if (numJugadores == 4)
            {
                rango = 200;
            }
        }
    }
}   