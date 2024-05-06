namespace MyApp.Exercicios
{
    public class Pilha
    {
        public void Func1()
        {
            Stack<int> stack = new();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Removendo o ultimo item usando pop()");
            stack.Pop();

            foreach (int item in stack)
            {
                Console.WriteLine(item);

            }
        }
    }
}