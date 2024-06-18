
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton - Start\n");

            Console.WriteLine($"Valor inicial: {Singleton.Instance.value}");

            Console.WriteLine("Tentando criar instancia s1.");

            Singleton s1 = Singleton.Instance;

            Console.WriteLine($"Valor s1: {s1.value}");

            Console.WriteLine("Tentando criar instancia s2.");

            Singleton s2 = Singleton.Instance;

            Console.WriteLine($"Valor s2: {s2.value}");


            if (s1 == s2)
            {
                Console.WriteLine("Existe somente uma instancia (s1 é igual a s2)");
            }
            else
            {
                Console.WriteLine("Existem instancias diferentes (s1 e s2)");
            }

            Console.WriteLine("\nSingleton - End");
        }
    }
}
