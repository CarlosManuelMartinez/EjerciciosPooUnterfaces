using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Vector3D
{
    public class Conjunto {
        public string Nombre { get; set; }
        private HashSet<int> miConjunto;
        public Conjunto(string nombre) {
            this.miConjunto = new HashSet<int>();
            this.Nombre = nombre;
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
            c.miConjunto.Clear();
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
                Console.WriteLine("El numero {0} esta en la lista", numero);
            }
            else
            {
                Console.WriteLine("El numero {0} No esta en la lista", numero);
            }

            return esMiembro;
        }

        //EsIgual (devuelve un valor booleano si los dos conjuntos son iguales)

        public bool EsIgual(Conjunto c)
        {
            return this.miConjunto.SetEquals(c.miConjunto);
        }
        //ToString() (convierte a una versión formateada el conjunto)
        public override string ToString()
        {
            string text = "";
            foreach (int n in this.miConjunto)
            {
                text += " numero "+ n.ToString()+"\n";
            }
            return text;
        }
        //EsVacio() (devuelve un valor booleano si el conjunto no tiene elementos)
        
        public bool EstaVacio()
        {
            bool vacio = false;
             if(this.miConjunto.Count == 0)
            {
                vacio = true;
            }

            return vacio;
        }
        //Cardinal() (devuelve un entero con el número de elementos del conjunto)
        
        public int Cardinal()
        {
            return this.miConjunto.Count;
        }

        //Unión() (realiza la unión de dos conjuntos)
        /*Modifica el objeto HashSet<T> actual para que contenga todos los elementos 
         * que están presentes en él y en la colección especificada o en ambos.*/
        public void Union(Conjunto c)
        {
            this.miConjunto.Union(c.miConjunto);
        }

        //Intersección() (realiza la intersección de dos conjuntos)
        /*Modifica el objeto HashSet<T> actual para que solo contenga elementos que están presentes
         * en ese objeto y en la colección especificada.*/
        public void Interseccion(Conjunto c)
        {
            this.miConjunto.IntersectWith(c.miConjunto);
        }

        //Diferencia() (realiza la diferencia de dos conjuntos)
        /*ExceptWith : Quita del objeto HashSet<T> actual todos los elementos de la colección especificada.*/
        public void Diferencia(Conjunto c)
        {
           this.miConjunto.ExceptWith(c.miConjunto);

        }

        //DiferenciaSimétrica() (realiza la diferencia simétrica de dos conjuntos)
        /* SymmetricExceptWith : Modifica el objeto HashSet<T> actual para que contenga únicamente 
         * los elementos que están presentes en ese objeto o en la colección especificada,
         * pero no en ambos.*/
        public void DiferenciaSimetrica(Conjunto c)
        {
            this.miConjunto.SymmetricExceptWith(c.miConjunto);

        }




    }
}
