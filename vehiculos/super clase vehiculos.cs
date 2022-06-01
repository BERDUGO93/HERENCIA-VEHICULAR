using System;

namespace vehiculos
{
    internal class Vehiculos

    {
        private string combustible;
        private int ruedas;
        private string color;
        private int precio;
        private int modelo;
        private string uso;
        private int capacidad;
        private string marca;
        private int cilindraje;
        private string carroceria;
        private string motor ;
        private string accesorios;
        private int puertas;
        private int suspencion;
        private string trasmision;
        private string traccion;
        private string sistemadefrenos;

        public Vehiculos(string combustible, int ruedas, string color, int precio, int modelo, string uso, int capacidad, string marca , int cilindraje , string carroceria , string motor , string accesorios )

        {
            this.combustible = combustible;
            this.ruedas = ruedas;
            this.color = color;
            this.precio = precio;
            this.modelo = modelo;
            this.uso = uso;
            this.capacidad = capacidad;
            this.marca = marca;
            this.cilindraje = cilindraje;   
            this.carroceria = carroceria;
            this.motor = motor;
            this.accesorios = accesorios;



        }

        public Vehiculos(string combustible, int ruedas, string color, int precio, int modelo, string uso, int capacidad, string marca, int cilindraje, string carroceria, string motor, string accesorios, int puertas, int suspencion, string trasmision, string traccion, string sistemadefrenos) : this(combustible, ruedas, color, precio, modelo, uso, capacidad, marca, cilindraje, carroceria, motor, accesorios)
        {
            this.puertas = puertas;
            this.suspencion = suspencion;
            this.trasmision = trasmision;
            this.traccion = traccion;
            this.sistemadefrenos = sistemadefrenos;
        }

        public string getcombustible() { return combustible; }
        
       
        
        public int getruedas() { return ruedas; }
     
        public string getcolor() { return color; }
        public int getprecio () { return precio; }
        public int getmodelo() { return modelo; }
        public string getuso() { return uso; }
        public int  getcapacidad() { return capacidad; }
        
        public string getmarca() { return marca; }

        public int getCilindraje() { return cilindraje; }
        public string getcarroceria() { return carroceria; }
        public string getmotor() { return motor; }
        public string getaccesorios() { return accesorios; }
        
        
    }

}