using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Vector3D
{
    /*Crea la clase Conjunto que gestiones un conjunto de números enteros (integer)
con ayuda de un vector ordenado de tamaño infinito y que se caracteriza por el
hecho de cada elemento del conjunto es único. Implementar también las
siguientes operaciones para el conjunto:
• Vaciar (vacía el conjunto)
• Agregar (añade un elemento al conjunto)
• Eliminar (integer c) (elimina el entero c del conjunto)
• Copiar (copia un conjunto en otro)
• EsMiembro (integer c) (devuelve un valor booleano si el conjunto
contiene el entero dado).
Antonio Javier Rodríguez Bas Página 22 de 23
• EsIgual (devuelve un valor booleano si los dos conjuntos son
iguales)
• ToString() (convierte a una versión formateada el conjunto)
• EsVacio() (devuelve un valor booleano si el conjunto no tiene
elementos)
o Cardinal() (devuelve un entero con el número de elementos
del conjunto)
o Unión() (realiza la unión de dos conjuntos)
o Intersección() (realiza la intersección de dos conjuntos)
o Diferencia() (realiza la diferencia de dos conjuntos)
o DiferenciaSimétrica() (realiza la diferencia simétrica de dos
conjuntos)
Para más información sobre la teoría de conjuntos ver */
    internal class Conjunto {

        private HashSet<int> miConjunto;
        public Conjunto() {
            this.miConjunto = new HashSet<int>();
        }
        //Vaciar (vacía el conjunto).
        public void Vaciar()
        {
            this.miConjunto.Clear();
        }
        //Agregar (añade un elemento al conjunto).
        public void  Agregar(int n)
        {
            this.miConjunto.Add(n);
        }
        //Eliminar (integer c) (elimina el entero c del conjunto).
        public void Eliminar(int n)
        {
            this.miConjunto.Remove(n);
        }
        //Copiar (copia un conjunto en otro).
        public void Copiar(Conjunto c)
        {
            try
            {
                foreach (int num in this.miConjunto)
                {
                    c.Agregar(num);
                }
            }
            catch (Exception e)
            {


                Console.WriteLine(e.Message);
            }
            
        }

        //EsMiembro (integer c) (devuelve un valor booleano si el conjunto
        //contiene el entero dado)

        public bool EsMiembro(int numero)
        {
            bool esMiembro = false;
            if (miConjunto.Contains(numero))
            {
                esMiembro = true;
            }
            return esMiembro;
        }
    }
}
