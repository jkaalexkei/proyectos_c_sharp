using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ejemplo_practico_encapsulacin_excepciones
{
    class Persona
    {
        // Auto-properties simples
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        // Con validación en el set
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                _nombre = value;
            }
        }

        private int _edad;
        public int Edad
        {
            get { return _edad; }
            set
            {
                if (value < 0 || value > 120)
                    throw new ArgumentException("Edad inválida.");
                _edad = value;
            }
        }

        private string _correo;
        public string Correo
        {
            get { return _correo; }
            set
            {
                if (!value.Contains("@"))
                    throw new ArgumentException("Correo inválido.");
                _correo = value.ToLower(); // normalización
            }
        }

        // Propiedad calculada (no necesita campo privado)
        public bool EsMayorDeEdad => Edad >= 18;

        // Constructor para inicializar la clase
        public Persona(string nombre, int edad, string correo, string direccion, string telefono)
        {
            Nombre = nombre;
            Edad = edad;
            Correo = correo;
            Direccion = direccion;
            Telefono = telefono;
        }

        // Método de utilidad
        public override string ToString()
        {
            return $"{Nombre}, {Edad} años, correo: {Correo}, dirección: {Direccion}, teléfono: {Telefono}";
        }
    }
}
