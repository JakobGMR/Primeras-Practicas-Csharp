internal class Program
{
    private static void Main(string[] args)
    {
        Promedio();

        Console.ReadKey();
    }

    static void Promedio()
    {
        System.Console.WriteLine("Programa para sacar la media \n");

        int cantidad;
        double numeros;
        double resultado = 0;

        System.Console.WriteLine("¿De cuántos números se le sacara la media?");
        cantidad = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            System.Console.Write("Dame el resultado número {0}: ", (i+1));
            numeros = double.Parse(Console.ReadLine());

            resultado = resultado + numeros;
        }

        System.Console.WriteLine("La media del atleta es igual a: " + (resultado / cantidad));
    }
}