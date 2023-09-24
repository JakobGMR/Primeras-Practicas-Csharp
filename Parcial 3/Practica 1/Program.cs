class Program
{
    static void Main(string[] args)
    {
        Program ejecuta = new Program();
        ejecuta.Menu();
    }

    public void Menu() {
        while (true)
        {
            System.Console.WriteLine("Elija su opción \n");

            System.Console.WriteLine("1. Menor a Mayor");
            System.Console.WriteLine("2. Mayor a Menor");
            System.Console.WriteLine("3. Cerrar \n");

            string eleccion = Console.ReadLine()!;

            switch (eleccion)
            {
                case "1":
                Console.Clear();
                MenAMay();
                Console.ReadKey();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                MayAMen();
                Console.ReadKey();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                System.Console.WriteLine("Cerrando..."); Thread.Sleep(1000);
                return;

                default:
                Console.Clear();
                System.Console.WriteLine("Error. Pulse una tecla."); Console.ReadKey();
                Console.Clear();
                break;
            }
        }   
    }

    public void MenAMay() {
        // definir variables
        int[] a = new int[3];
        int i,j,aux; // se definen las variables
        a[0] = 10;
        a[1] = 4;
        a[2] = 2;

        // mostrar arreglo
        for (i = 0; i <= 2; i++)
        {
            System.Console.Write(a[i] + " "); // imprime los valores tal cual como estan definidos
        }

        System.Console.WriteLine(" ");

        // proceso
        for (i = 0; i <= 1; i++)
        {
            for (j = 0; j <= 1; j++)
            {
                if(a[j] > a[j+1]) { // evalua si el primer numero de "a" es mayor que su consecutivo se realiza lo siguiente
                    aux = a[j];     // la variable aux va ser igual que el primer valor de "a", o sea se va almacenar como un tipo de backup
                    a[j] = a[j+1];  // ahora el primer valor de "a" va ser igual a su consecutivo
                    a[j+1] = aux;   // y el "a" consecutivo va ser igual a "aux", que viene siendo el valor anterior de "a"
                }
            } // esto lo realiza dos veces, osea un numero antes de la matriz total, si lo hace una vez mas se rompe el codigo por la longitud de la matriz
        }
        
        for (i = 0; i <= 2; i++)
        {
            System.Console.Write(a[i] + " "); // imprime de nuevo la matriz ya ordenada de menor a mayor
        }

        System.Console.WriteLine(" ");
    }

    public void MayAMen() {
        // definir variables
        int[] a = new int[3];
        int i,j,aux; // se definen las variables
        a[0] = 2;
        a[1] = 4;
        a[2] = 10;

        // mostrar arreglo
        for (i = 0; i <= 2; i++)
        {
            System.Console.Write(a[i] + " "); // imprime los valores tal cual como estan definidos
        }

        System.Console.WriteLine(" ");

        // proceso
        for (i = 0; i <= 1; i++)
        {
            for (j = 0; j <= 1; j++)
            {
                if(a[j] < a[j+1]) { // evalua si el primer numero de "a" es mayor que su consecutivo se realiza lo siguiente
                    aux = a[j];     // la variable aux va ser igual que el primer valor de "a", o sea se va almacenar como un tipo de backup
                    a[j] = a[j+1];  // ahora el primer valor de "a" va ser igual a su consecutivo
                    a[j+1] = aux;   // y el "a" consecutivo va ser igual a "aux", que viene siendo el valor anterior de "a"
                }
            } // esto lo realiza dos veces, osea un numero antes de la matriz total, si lo hace una vez mas se rompe el codigo por la longitud de la matriz
        }
        
        for (i = 0; i <= 2; i++)
        {
            System.Console.Write(a[i] + " "); // imprime de nuevo la matriz ya ordenada de menor a mayor
        }

        System.Console.WriteLine(" ");
    }
}