using AgenteIA;
using System;

class Program
{
    static void Main(string[] args)
    {
        Agente agente = new Agente();

        while (true)
        {
            Console.WriteLine("Escribe la palabra al Agente IA");
            string input = Console.ReadLine();

            if (input.ToLower() == "memoria")
            {
                agente.MostrarMemoria();
                continue;
            }

            string respuesta = agente.Procesar(input);

            if (respuesta == "salir")
                break;

            Console.WriteLine("Agente: " + respuesta);
        }



       
    }
}

