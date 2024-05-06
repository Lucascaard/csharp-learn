using System.Collections;

namespace MyApp.Exercicios
{
    public class Filas
    {
        public void Func1()
        {

            Queue<int> fila = new Queue<int>();
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);
            fila.Enqueue(5);
            fila.Enqueue(6);
            fila.Enqueue(10);

            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Removendo o primeiro elemento da fila {fila.Dequeue()}");


            Console.WriteLine("Foreach dnv...");
            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }
        }
    }
}