using _1Vector3D;

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

        Console.WriteLine("este es el double del imaginario: {0}", i1.D);
        Imaginario i2 = new Imaginario(11d);
        Complejo c1 = new Complejo(4.3d, i1);
        Complejo c2 = new Complejo(2.3d, i2);

        Console.WriteLine(c1.ToString());
        Console.WriteLine("La suma de " + c1.ToString() + " + " + c2.ToString() + " da como resultado " + c1.Suma(c2));
        Console.WriteLine("La suma de {0} + {1} da como resultado {2}", c1, c2, c1.Suma(c2));
        Console.WriteLine("La resta de " + c1.ToString() + " - " + c2.ToString() + " da como resultado " + c1.Resta(c2));
        Console.WriteLine("La multipicacion de " + c1.ToString() + " por " + c2.ToString() +
            " da como resultado " + c1.Multiplicacion(c2));

        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("CONJUNTO NUMEROS");

        Console.WriteLine();

        Conjunto pares = new Conjunto("Pares");
        Console.WriteLine(pares.Nombre);
        Conjunto impares = new Conjunto("Impares");
        Conjunto tresEnTres = new Conjunto("Tres en tres");
        Conjunto seguidos = new Conjunto("seguidos");
        Conjunto vacio = new Conjunto("Vacio");
        int sum = 0;
        for (int i = 1; i <= 10; i+=2)
        {
            sum += 3;
            impares.Agregar(i);
            pares.Agregar(i+1);
            tresEnTres.Agregar(sum);
        }

        for (int i = 0; i < 10; i++)
        {
            seguidos.Agregar(i);
        }

        int num = 4;
        int num2 = 200;

        pares.EsMiembro(num);
        pares.EsMiembro(num2);
        Console.WriteLine("NUMEROS PARES:\n{0}", pares.ToString());
        Console.WriteLine("NUMEROS INPARES:\n{0}", impares.ToString());
        Console.WriteLine("NUMEROS DE 3 EN 3:\n{0}", tresEnTres.ToString());
        Console.WriteLine("NUMEROS DE SEGUIDOS:\n{0}", seguidos.ToString());
        Console.WriteLine("Que el conjunto d y el conjunto c son iguales es: " + pares.EsIgual(impares));
        Console.WriteLine("Que el conjunto e y el conjunto c son iguales es: " + pares.EsIgual(tresEnTres));
        Console.WriteLine("Que el conjunto e y el conjunto d son iguales es: " + impares.EsIgual(tresEnTres));
        Console.WriteLine("Que el conjunto e esta vacio es: " + tresEnTres.EstaVacio());
        string verdaderoOFalso = tresEnTres.EstaVacio() ? "verdadero" : "falso";
        Console.WriteLine("Que el conjunto e esta vacio es " + verdaderoOFalso);
        Console.WriteLine("La diferencia entre el conjunto {0} y/e {1} es: ",pares.Nombre,seguidos.Nombre);
        seguidos.Diferencia(pares);
        Console.WriteLine(seguidos);
        Console.WriteLine("La diferencia simetrica entre el conjunto {0} y/e {1} es: ", pares.Nombre, impares.Nombre);
        pares.DiferenciaSimetrica(impares);
        Console.WriteLine(pares);

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