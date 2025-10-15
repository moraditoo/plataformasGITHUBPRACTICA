namespace saludo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuál es tu nombre? ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Hola, " + nombre + "!");
        }
    }
}
