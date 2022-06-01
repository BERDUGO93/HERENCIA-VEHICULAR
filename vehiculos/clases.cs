using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{

    internal class Clase : Carro
    {
        private int puertas;
        private int suspension;
        private string trasmision;
        private string traccion;
        private string sistemadefrenos;

        public int Puertas { get => puertas; set => puertas = value; }
        public int Suspension { get => suspension; set => suspension = value; }
        public string Trasmision { get => trasmision; set => trasmision = value; }
        public string Traccion { get => traccion; set => traccion = value; }
        public string Sistemadefrenos { get => sistemadefrenos; set => sistemadefrenos = value; }

        public Clase(string combustible, int ruedas, string color, int precio, int modelo, string uso, int capacidad, string marca, string carroceria, int cilindraje, string motor, string accesorios, int puertas, int suspension, string trasmision, string traccion, string sistemadefrenos) : base(combustible, ruedas, color, precio, modelo, uso, capacidad, marca, cilindraje, carroceria, motor, accesorios, puertas, suspension, trasmision, traccion, sistemadefrenos)

        {

        }

 


    }

}



