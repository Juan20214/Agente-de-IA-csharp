using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace AgenteIA
{
    public class Agente 
    {
        private List<Mensaje> memoria = new List<Mensaje>();


        private string ruta = "memoria.json";

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

            if (File.Exists(ruta))
            {
                string json = File.ReadAllText(ruta);
                memoria = JsonSerializer.Deserialize<List<Mensaje>>(json) ?? new List<Mensaje>();
            }

            memoria.Add(new Mensaje
            {
                Usuario = palabra,
                Agente = respuesta
            });

            string nuevoJson = JsonSerializer.Serialize(memoria, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(ruta, nuevoJson);

          
            return respuesta;


        }

        public void MostrarMemoria()
        {
            Console.WriteLine("\n--- HISTORIAL ---");

            if (File.Exists(ruta))
            {
                string json = File.ReadAllText(ruta);
                var lista = JsonSerializer.Deserialize<List<Mensaje>>(json);

                foreach (var item in lista)
                {
                    Console.WriteLine($"Usuario: {item.Usuario}");
                    Console.WriteLine($"Agente: {item.Agente}");
                }
            }
            else
            {
                Console.WriteLine("No hay historial.");
            }

            Console.WriteLine("-----------------\n");

        }
    }
}
