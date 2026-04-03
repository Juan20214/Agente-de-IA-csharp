using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgenteIA
{
    public class Agente 
    {
        private List<string> memoria = new List<string>();

        
        public string Procesar(string palabra)
        {
            palabra = palabra.ToLower();

            memoria.Add(palabra);
            
            string respuesta;

            if (palabra == "hola")
            {

                respuesta = "Hola!";
           
            }
            
            else if (palabra == "hora")
            {
               
                respuesta = DateTime.Now.ToShortTimeString();
            
            }
            
            else if (palabra == "fecha")
            {
               
                respuesta = DateTime.Now.ToShortDateString();
           
            }
            
            else if (palabra == "salir")
            {
               
                respuesta = "salir";
           
            }
           
            else
            {
               
                respuesta = "No entiendo";
           
            }

            memoria.Add("Agente:" + respuesta);

            return respuesta;


        }

        public void MostrarMemoria()
        {
            Console.WriteLine("\n--- HISTORIAL ---");

            foreach (var item in memoria)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------\n");
        }

    }
}
