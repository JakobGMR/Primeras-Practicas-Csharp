class Program
{
    int[,] matriz3x3 = new int[3,3];
    int[, ,] matriz3x3x3 = new int[3,3,3];
    static void Main(string[] args)
    {
        Program ejecutar = new Program();
        ejecutar.Menu();
    }

    public void Menu() {
        while(true)
        {
            System.Console.WriteLine("Elija la acción \n");

            System.Console.WriteLine("1. Matriz 2 dimenciones");
            System.Console.WriteLine("2. Matriz 3 dimenciones");
            System.Console.WriteLine("3. Cerrar \n");

            string eleccion = Console.ReadLine()!;

            switch(eleccion)
            {
                case "1":
                Console.Clear();
                Matriz3x3();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                Matriz3x3x3();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                System.Console.Write("Cerrando..."); Thread.Sleep(1000);
                return;

                default:
                Console.Clear();
                System.Console.Write("Error. Pulse una tecla para continuar");  Console.ReadKey();
                Console.Clear();
                break;
            }
        }

    }

    public void Matriz3x3() {
        System.Console.WriteLine("Ingrese los números a almacenar en la matriz 3x3 \n");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                System.Console.Write("Ingrese el número :"); int dato = int.Parse(Console.ReadLine());

                matriz3x3[i,j] = dato;
            }
        }

        System.Console.WriteLine();

        System.Console.WriteLine("¿Quiere ver los datos almacenados?");
        string eleccion = Console.ReadLine()!.ToLower();

        if(eleccion == "si" || eleccion == "s") {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    System.Console.Write(matriz3x3[i,j] + " ");
                }

                System.Console.WriteLine();
            }

            System.Console.Write("\nPulse una tecla para continuar"); Console.ReadKey();
        }
    }

    public void Matriz3x3x3() {
        System.Console.WriteLine("Ingrese los números a almacenar en la matriz 3x3 \n");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    System.Console.Write("Ingrese el número :"); int dato = int.Parse(Console.ReadLine());

                    matriz3x3x3[i,j,k] = dato;
                }
            }
        }

        System.Console.WriteLine();

        System.Console.WriteLine("¿Quiere ver los datos almacenados?");
        string eleccion = Console.ReadLine()!.ToLower();

        if(eleccion == "si" || eleccion == "s") {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        System.Console.Write(matriz3x3x3[i,j,k] + " ");
                    }
                }

                System.Console.WriteLine();
            }

            System.Console.Write("\nPulse una tecla para continuar"); Console.ReadKey();
        }
    }
}