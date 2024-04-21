using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;

namespace A2Practivca_Formativa

{
    internal class Program
    {


        public class Televisor
        {
            // atributos 
            String marca;
            String modelo;
            int pulgadas;
            bool estado;
            int canal;


            //contructor
            public Televisor(string marca, string modelo, int pulgadas, bool estado, int canal)
            {
                this.Marca = marca;
                this.Modelo = modelo;
                this.Pulgadas = pulgadas;
                this.Estado = estado;
                this.Canal = canal;

            }
            // escapsulamiento (setters y getters)
            public string Marca { get => marca; set => marca = value; }
            public string Modelo { get => modelo; set => modelo = value; }
            public int Pulgadas { get => pulgadas; set => pulgadas = value; }
            public bool Estado { get => estado; set => estado = value; }
            public int Canal { get => canal; set => canal = value; }


            public int obtenerCanalActual()
            {
                return this.canal;
            }
            public void cambiarCanal(int canal)
            {
                if (estado)
                {
                    this.canal = canal;
                }
            }
            public bool verPrendido()
            {
                return estado;
            }
            public void cambiarEstado()
            {
                this.estado = !(this.estado);
            }


            //Sobrecarga toString
            public override string ToString()
            {
                return "marca: " + marca + " - modelo: " + modelo + " - pulgadas: " + pulgadas + " - canal: " + canal;
            }
        }

        public class Persona
        {
            String nombre;
            Domicilio domicilio;

            public Persona(string nombre, Domicilio domicilio)
            {
                this.nombre = nombre;
                this.Domicilio = domicilio;
            }

            public string Nombre { get => nombre; set => nombre = value; }
            public Domicilio Domicilio { get => domicilio; set => domicilio = value; }

            public override string ToString()
            {
                return "Nombre: " + nombre + " - Domicilio: " + domicilio;
            }
        }

        public class Domicilio
        {
            String calle;
            int numero;
            String barrio;
            Televisor tv;

            public Domicilio(string calle, int numero, string barrio, Televisor tv)
            {
                this.calle = calle;
                this.numero = numero;
                this.barrio = barrio;
                this.tv = tv;
            }

            public string Calle { get => calle; set => calle = value; }
            public int Numero { get => numero; set => numero = value; }
            public string Barrio { get => barrio; set => barrio = value; }
            public Televisor Tv { get => tv; set => tv = value; }
            //Sobrecarga toString
            public override string ToString()
            {
                return "Calle: " + calle + " - Numero: " + numero + " - Barrio: " + barrio;
            }
        }


        static void Main(string[] args)
        {
            
            Televisor tv1 = new Televisor("Samsung", "CX1050", 40, true, 10);
            Domicilio dir1 = new Domicilio("Jonte", 5299, "Monte Castro", tv1);
            Persona facundo = new Persona("Facundo", dir1);
            Persona camila = new Persona("Camila", dir1);

            Console.WriteLine("TV1: " + tv1);
            Console.WriteLine("DIR1: " + dir1);
            Console.WriteLine("PERSONA1: " + facundo);

            //camila.Domicilio.Tv.cambiarEstado();
            Console.WriteLine(facundo.Domicilio.Tv);
            facundo.Domicilio.Tv.cambiarCanal(12);
            Console.WriteLine(facundo.Domicilio.Tv);
            camila.Domicilio.Tv.cambiarCanal(14);
            Console.WriteLine(facundo.Domicilio.Tv);
         
        }
    }
}
