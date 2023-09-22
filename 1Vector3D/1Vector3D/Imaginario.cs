using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Vector3D
{
    public class Imaginario
    {

        public double D { get; set; }
        //private double d;
        private String i;

        public Imaginario(double d)
        {
            this.D = d;
            this.i = "i";
        }
        // Constructoer de copia
        public Imaginario(Imaginario imaginario)
        {
            imaginario.D = this.D;
            this.i = "i";
        }
        //public double D { get; set; }
        /*public double D
        {
            get { return d; }
            set { d = value; }
        }*/

        override
            public String ToString()
        {
            return this.D.ToString("F2") + "" + i;
        }

    }
}
