using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 
using Newtonsoft.Json;  

namespace CaravanInstructor.Evaluation
{
    class PruebaClase
    {
        string nombre;
        string apellido;
        int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }

        PruebaClase p = JsonConvert.DeserializeObject<PruebaClase>(File.ReadAllText("Prueba1.js")); 

       
    }



}
