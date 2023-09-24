using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Vector3D
{
    public class Complejo
    {
        private double entero;
        private Imaginario imaginarioComplejo;

        public Complejo(double entero, Imaginario imaginario)
        {
            this.entero = entero;
            this.imaginarioComplejo = imaginario;
        }

        // Constructor de copia.
        public Complejo(Complejo c)
        {
            entero = c.entero;
            imaginarioComplejo = c.imaginarioComplejo;
        }

        public double Entero
        {
            get { return entero; }
            set { entero = value; }
        }
        public Imaginario ImaginarioComplejo 
        { 
            get { return imaginarioComplejo; } 
            set { imaginarioComplejo = value; }
        }
        override
        public string  ToString()
        {
            return this.entero.ToString("F2") + "+" + this.imaginarioComplejo.ToString();
        }

        public Complejo Suma(Complejo c)
        {
            Imaginario imaginarioSuma = new Imaginario(this.ImaginarioComplejo.D + c.ImaginarioComplejo.D);
            Complejo suma = new Complejo(this.Entero + c.Entero, imaginarioSuma);
            return suma;
        }
        //Resta():a-c = (A-C, (B-D) i)

        public Complejo Resta(Complejo c)
        {
            Imaginario imaginarioResta = new Imaginario(this.ImaginarioComplejo.D - c.ImaginarioComplejo.D);
            Complejo resta = new Complejo(this.Entero - c.Entero, imaginarioResta);
            return resta;
        }
        //Multiplicación(c1,c2): dos número complejos. a*c = (A*C-B*D,(A* D+B* C)i)

        public Complejo Multiplicacion(Complejo c)
        {
            Imaginario imaginarioMultiplicacion = new Imaginario(this.ImaginarioComplejo.D * c.ImaginarioComplejo.D);
            Complejo producto = new Complejo(this.Entero * c.Entero, imaginarioMultiplicacion);
            return producto;
        }

        //Multiplicación(x,c1): un real por un número complejo. x * a =(xA, xBi)
        public Complejo Multiplicacion(double x, Complejo c)
        {
            Complejo producto2 = new Complejo(c.Entero * x, c.imaginarioComplejo);
            return producto2;
        }

        ~Complejo(){
            Console.WriteLine("He destruido algo");
        }


    }
}
