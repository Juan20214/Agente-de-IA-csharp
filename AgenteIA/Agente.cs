using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgenteIA
{
    public class Agente 
    {
        private List<string> memoria = new List<string>();


        private string ruta = "memoria.txt";

        public string Procesar(string palabra)
        {
            palabra = palabra.ToLower();

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

            File.AppendAllText(ruta, "Usuario: " + palabra + Environment.NewLine);
            File.AppendAllText(ruta, "Agente: " + respuesta + Environment.NewLine);
         


            return respuesta;


        }

        public void MostrarMemoria()
        {
            Console.WriteLine("\n--- HISTORIAL ---");

            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);

                foreach (var linea in lineas)
                {
                    Console.WriteLine(linea);
                }
            }
            else
            {
                Console.WriteLine("No hay historial guardado.");
            }

            Console.WriteLine("-----------------\n");
        }

    }
}
