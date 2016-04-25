using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace invoper_cli
{ 
    public class Utilities
    {
        /// <summary>
        /// Load the current configuration
        /// </summary>
        public void Init()
        {
            // Load configuration file 
            string configFilePath = AppDomain.CurrentDomain.BaseDirectory + "config.json";
            using (StreamReader r = new StreamReader(configFilePath))
            {
                string json = r.ReadToEnd();
                Entities.Configuration currentConfig = JsonConvert.DeserializeObject<Entities.Configuration>(json);
                Console.WriteLine("\r\n ██╗███╗   ██╗██╗   ██╗ ██████╗ ██████╗ ███████╗██████╗ \r\n██║████╗  ██║██║   ██║██╔═══██╗██╔══██╗██╔════╝██╔══██╗\r\n██║██╔██╗ ██║██║   ██║██║   ██║██████╔╝█████╗  ██████╔╝\r\n██║██║╚██╗██║╚██╗ ██╔╝██║   ██║██╔═══╝ ██╔══╝  ██╔══██╗\r\n██║██║ ╚████║ ╚████╔╝ ╚██████╔╝██║     ███████╗██║  ██║\r\n╚═╝╚═╝  ╚═══╝  ╚═══╝   ╚═════╝ ╚═╝     ╚══════╝╚═╝  ╚═╝\r\n                                                       ");
                Console.WriteLine("Configuración actual: \r\n Idioma: " + currentConfig.LanguageName + "\r\n");
            }
        }
    }
}
