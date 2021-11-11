using System;

namespace Acceso_al_Parque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al parque Vuelta al Mundo");
            Console.WriteLine("Por favor, introduce tu nombre:");
            string username = "";
            string cadena = "";
            username =  Console.ReadLine();
            Console.WriteLine("Por favor ingresa tu edad:");
            int edad = 0;
            cadena = Console.ReadLine();
            edad = Convert.ToInt32(cadena);
            if ( edad < 15)
            {
                Console.WriteLine("No puedes entrar sin un representante");
            } 
            else
                {
                    Console.WriteLine("Por favor ingresa tu altura, en metros: ");
                    double altura = 0.0;
                    cadena = Console.ReadLine();
                    altura = Convert.ToDouble(cadena);
                    
                    if (altura <= 1.60 )
                    {
                        Console.WriteLine("Bienvenido al parque, cuídate y diviértete.");

                     }
                else {
                    Console.WriteLine("Diviértete!! Puedes ir a la Montaña Rusa, {0}.", username);}
                }
        }   
    }
}
