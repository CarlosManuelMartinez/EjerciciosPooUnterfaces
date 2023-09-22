using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Vector3D
{
    public class Vector
    {
        private int x;
        private int y;
        private int z;

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public bool Igual(Vector vector)
        {
            bool igual = false;
            if (this.NormaMax() == vector.NormaMax())
                igual = true;
            return igual;
        }

        public double NormaMax()
        {
            double norma = (this.x ^ 2) + (this.y ^ 2) + (this.z ^ 2);
            norma = Math.Sqrt(norma);
            return norma;
        }
    }
}
