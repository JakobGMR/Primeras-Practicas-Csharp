internal class Program
{
    private static void Main(string[] args)
    {
        IngresarNombrePerros();

        Console.ReadKey();
    }

    static void IngresarNombrePerros()
    {
        int cantPerros;
        string eleccion;
        string[] nombrePerros;
        bool repetir = true;

        System.Console.WriteLine("Ingrese la cantidad de perros a los que le quiere asignar raza");
        cantPerros = int.Parse(Console.ReadLine());

        nombrePerros = new string[cantPerros];

        System.Console.WriteLine();
        do
        {
            System.Console.WriteLine("Elija el metodo a usar: \n");
            System.Console.WriteLine("1. Metodo For()");
            System.Console.WriteLine("2. Metodo Foreach");
            System.Console.WriteLine("3. Salir \n");
            eleccion = Console.ReadLine();

            System.Console.WriteLine();

            
            switch(eleccion)
            {
                case "1":
                Console.Clear();
                metodoFor(cantPerros, nombrePerros);
                Console.ReadKey();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                metodoForEach(nombrePerros);
                Console.ReadKey();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                System.Console.Write("Saliendo...");
                repetir = false;
                break;

                default:
                Console.Clear();
                System.Console.WriteLine("Necesita escribir los números especificos");
                Console.ReadKey();
                Console.Clear();
                break;
                }
        } while(repetir);
    }

    static void metodoFor(int cantPerros, string[] nombrePerros)
    {
        System.Console.WriteLine("Estas usando el método For \n");

        for (int i = 0; i < cantPerros; i++)
        {
            System.Console.Write("Escriba la raza del perro #" + (i+1) + ": "); nombrePerros[i] = Console.ReadLine();
        }

        System.Console.Write("Finalizando...");
    }

    static void metodoForEach(string[] nombrePerros)
    {
        int i = 0;
        System.Console.WriteLine("Estas usando el método ForEach \n");
        foreach (var item in nombrePerros)
        {
            System.Console.WriteLine($"La raza del perro #{(i +1)} es: {item}");
            i++;
        }
    }
}