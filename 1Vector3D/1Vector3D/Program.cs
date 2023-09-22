using _1Vector3D;
using System.Globalization;

internal class Vector3D
{
    /*Crea la Clase Vector3D que permita manipular vectores de tres componentes,
    (coordenadas x, y, z) teniendo en cuenta los siguientes criterios:
    Sólo debe de poseer un método constructor.
    Método Igual() que permite sabes si dos vectores son iguales.
    Método NormaMax(), que permite obtener la norma del vector.
    v=(x,y,z) raiz de x
*/
    
    private static void Main(string[] args)
    {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("VECTORES");
        Console.WriteLine();

        Vector v1 = new Vector(2, 3, 4);
        Vector v2 = new Vector(2, 4, 3);
        Console.WriteLine("La norma del vector " + v1.ToString() + " es : " + v1.NormaMax());
        Console.WriteLine("La norma del vector " + v2.ToString() + " es : " + v2.NormaMax());

        
       
        if (v2.Igual(v1))
        {
            Console.WriteLine("Los vectores " + v1.ToString() + " y " + v1.ToString() + " son iguales");
        }
        else
        {
            Console.WriteLine("Los vectores " + v1.ToString() + " y " + v1.ToString() + " NO son iguales");
        }
        Console.WriteLine();


        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("NUMEROS COMPLEJOS");
        Console.WriteLine();

        Imaginario i1 = new Imaginario(2.3d);
        Imaginario icopia = new Imaginario(i1);
        icopia.D = 23;
        Console.WriteLine(icopia.ToString());
          
        Console.WriteLine("este es el double del imaginario: {0}",i1.D);
        Imaginario i2 = new Imaginario(11d);
        Complejo c1 = new Complejo(4.3d, i1);
        Complejo c2 = new Complejo(2.3d, i2);

        Console.WriteLine(c1.ToString());
        Console.WriteLine("La suma de "+c1.ToString()+" + "+c2.ToString()+" da como resultado "+ c1.Suma(c2));
        Console.WriteLine("La resta de " + c1.ToString() + " - " + c2.ToString() + " da como resultado " + c1.Resta(c2));
        Console.WriteLine("La multipicacion de " + c1.ToString() + " por " + c2.ToString() + 
            " da como resultado " +c1.Multiplicacion(c2));

    }
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