using colas1.clases.ColaArreglo;
using colas1.clases.Pila_Lista;
using System;
using System.Collections;

namespace colas1
{
    class Program
    {


        private static bool valido(String numero)
        {
            bool sw = true;
            int i = 0;
            while (sw && (i < numero.Length))
            {

                Char c;
                c = numero[i++];
                sw = (c >= '0' && c <= '9');

            }
            return sw;


        }
        static void Main(string[] args)
        {
            // programa capicua

            bool capicua;
            string numero;

           //PilaLista pila = new PilaLista();
           // ColaCircular circula_Cola = new ColaCircular();
            Stack pila = new Stack();
            Queue cola = new Queue();

            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("\nTeclea un numero: ");
                        numero = Console.ReadLine();
                    } while (!valido(numero));

                    //pone en la cola y en la pila cada digito
                    for (int i = 0; i < numero.Length; i++)
                    {
                        Char c;
                        c = numero[i];
                        cola.Enqueue(c);
                        pila.Push(c);
                    }

                    //se retira de la cola y pila para comparar
                    do
                    {
                        Char d;
                        d = (Char)cola.Dequeue();
                        capicua = d.Equals(pila.Pop()); //compara la igualdad
                    } while (capicua && cola.Count!=0);

                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} es capicua");
                    }
                    else
                    {
                        Console.WriteLine($"Número {numero} no es capicua");
                        Console.WriteLine("intente otro");
                    }

                    // vaciar estructuras

                   cola.Clear();
                   pila.Clear();


                }
            }
            catch (Exception errores)
            {
                Console.WriteLine($"Error en {errores.Message}");
            }

            //Queue qt = new Queue();
            //qt.Enqueue("1");
            //qt.Enqueue("2");
            

            //Console.WriteLine($"La cola tiene {qt.Count} elementos"); 
            //Console.WriteLine($"Desencolado {qt.Dequeue()}");
            





            // Console.WriteLine("Hello World!");
        }
    }
}
