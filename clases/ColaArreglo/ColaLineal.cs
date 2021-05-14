using System;
using System.Collections.Generic;
using System.Text;

namespace colas1.clases.ColaArreglo
{
    class ColaLineal
    {
        protected int fin;
        private static int MAXTAMQ = 39;
        protected int frente;

        protected Object[] listaCola;

        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            listaCola = new object[MAXTAMQ];
        }

        public bool colaVacia()
        {
            return frente > fin;
        }

        public bool colaLlena()
        {
            return fin == MAXTAMQ-1;
        }

        //OPARACIONES CON COLAS
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                listaCola[++fin] = elemento;
            }
            else
            {
                throw new Exception("Overflow de la cola");
            }
        }

        // quitar elementos

        public Object quitar()
        {
            if (!colaVacia())
            {
                return listaCola[frente++];
            }
            else
            {
                throw new Exception("Cola vacía");
            }
        }
        // limpiar cola
        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }

        // acceso a la cola

        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];
            }
            else
            {
                throw new Exception("Cola vacía");
            }
        }

    
       
    }// end class
}
